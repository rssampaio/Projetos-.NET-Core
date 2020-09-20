using Chacrutaria.Interfaces;
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
            var homeViewModel = new HomeViewModel
            {
                ProdutosPreferidos = _produtoRepository.ProdutoPreferido
            };

            return View(homeViewModel);
        }

    }
}
