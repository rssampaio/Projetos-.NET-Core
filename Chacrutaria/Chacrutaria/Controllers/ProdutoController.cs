using Microsoft.AspNetCore.Mvc;
using Chacrutaria.Interfaces;
using Chacrutaria.ViewModels;

namespace Chacrutaria.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public ProdutoController(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository)
        {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult ListaProduto()
        {
            // Utiliza o Modelo para enviar os dados para a view
            //var produtos = _produtoRepository.Produtos;
            //return View(produtos);

            // Será utilizada a View Model para envio do modelo
            var ProdutoListViewModel = new ProdutoListViewModel();
            ProdutoListViewModel.Produtos = _produtoRepository.Produtos;
            ProdutoListViewModel.CategoriaAtual = "Categoria Atual";

            return View(ProdutoListViewModel);
        }
    }
}
