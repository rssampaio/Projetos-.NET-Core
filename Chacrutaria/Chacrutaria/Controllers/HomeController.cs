using Chacrutaria.Repositories.Interfaces;
using Chacrutaria.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Chacrutaria.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;

        public HomeController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Loja()
        {
            var homeViewModel = new HomeViewModel
            {
                ProdutosPreferidos = _produtoRepository.ProdutoPreferido
            };

            return View(homeViewModel);
        }

        public ViewResult AccessDenied()
        {
            return View();
        }

    }
}
