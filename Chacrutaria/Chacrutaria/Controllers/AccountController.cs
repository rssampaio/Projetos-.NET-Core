using Chacrutaria.Models;
using Chacrutaria.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Chacrutaria.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly SignInManager<IdentityUser> _signInManager;
        private readonly CarrinhoCompra _carrinhoCompra;

        public AccountController(UserManager<IdentityUser> userManager,
                                 SignInManager<IdentityUser> signInManager,
                                 CarrinhoCompra carrinhoCompra)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _carrinhoCompra = carrinhoCompra;
        }

        [HttpGet]
        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel()
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            if (!ModelState.IsValid)
                return View(loginVM);

            var user = await _userManager.FindByNameAsync(loginVM.UserEmail);

            if (user != null)
            {
                var result = await _signInManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(loginVM.ReturnUrl))
                    {
                        return RedirectToAction("Loja", "Home");
                    }
                    return Redirect(loginVM.ReturnUrl);
                }
            }

            ModelState.AddModelError("usuario.invalido", "Usuário/Senha inválidos ou não localizados");
            return View(loginVM);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(LoginViewModel registerVM)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(registerVM.UserEmail);

                if (user == null)
                {
                    var usercad = new IdentityUser() { UserName = registerVM.UserEmail };
                    var result = await _userManager.CreateAsync(usercad, registerVM.Password);

                    if (result.Succeeded)
                    {
                        //// Adiciona o usuário padrão ao perfil Member
                        await _userManager.AddToRoleAsync(usercad, "Membro");
                        await _signInManager.SignInAsync(usercad, isPersistent: false);

                        return RedirectToAction("Login", "Account");
                    }

                    ModelState.AddModelError("senha.invalido", "Senha inválida !");
                    ModelState.AddModelError("senha1.invalido","Deverá ter o mínimo de 8 caracteres");
                    ModelState.AddModelError("senha2.invalido","Deverá conter letras e número");

                    return View(registerVM);
                }

                ModelState.AddModelError("senha.invalido", "Email já existe cadastrado");
                return View(registerVM);
            }

            ModelState.AddModelError("senha.invalido", "Email/Senha inválidos");
            return View(registerVM);
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {

            var itens = _carrinhoCompra.GetCarrinhoCompraItems();
            _carrinhoCompra.CarrinhoCompraItems = itens;

            if (_carrinhoCompra.CarrinhoCompraItems.Count() > 0)
            {
                _carrinhoCompra.LimparCarrinho();
            }
            
            await _signInManager.SignOutAsync();

            return RedirectToAction("Loja", "Home");
        }
    }
}
