using Microsoft.AspNetCore.Mvc;
using Chacrutaria.Repositories.Interfaces;
using Chacrutaria.Models;
using Chacrutaria.ViewModels;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Chacrutaria.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(IProdutoRepository produtoRepository, CarrinhoCompra carrinhoCompra)
        {
            _produtoRepository = produtoRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        [Authorize]
        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItems();
            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carrinhoCompraViewModel = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                TotalCarrinho = _carrinhoCompra.GetCarrinhoTotalCompra()
            };

            return View(carrinhoCompraViewModel);
        }

        [Authorize]
        public RedirectToActionResult AdicionarItemCarrinhoCompra(int produtoId)
        {
            var produtoSelecionado = _produtoRepository.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);

            if (produtoSelecionado != null)
            {
                _carrinhoCompra.AdcionarAoCarrinho(produtoSelecionado, 1);
            }

            return RedirectToAction("Index");
        }

        [Authorize]
        public RedirectToActionResult RemoverItemCarrinhoCompra(int produtoId)
        {
            var produtoSelecionado = _produtoRepository.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);


            if (produtoSelecionado != null)
            {
                _carrinhoCompra.RemoverDoCarrinho(produtoSelecionado);
            }

            return RedirectToAction("Index");
        }

        public IActionResult RetornarInicio()
        {
            return RedirectToAction("Loja", "Home");
        }
    }
}
