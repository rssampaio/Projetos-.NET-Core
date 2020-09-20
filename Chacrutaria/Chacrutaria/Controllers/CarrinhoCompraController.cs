using Microsoft.AspNetCore.Mvc;
using Chacrutaria.Interfaces;
using Chacrutaria.Services;
using Chacrutaria.Models;
using Chacrutaria.ViewModels;
using System.Linq;

namespace Chacrutaria.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly CarrinhoService _carrinhoCompraservice;
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraController(IProdutoRepository produtoRepository,
                                        CarrinhoService carrinhoCompraService)
        {
            _produtoRepository = produtoRepository;
            _carrinhoCompraservice = carrinhoCompraService;

        }
        public IActionResult Index()
        {
            var itens = _carrinhoCompraservice.GetCarrinhoCompraItems();
            _carrinhoCompra.CarrinhoCompraItems = itens;

            var carrinhoCompraViewModel = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                TotalCarrinho = _carrinhoCompraservice.GetCarrinhoTotalCompra()
            };

            return View(carrinhoCompraViewModel);
        }

        public RedirectToActionResult AdicionarItemCarrinhoCompra(int produtoId)
        {
            var produtoSelecionado = _produtoRepository.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);

            if (produtoSelecionado != null)
            {
                _carrinhoCompraservice.AdcionarAoCarrinho(produtoSelecionado, 1);
            }

            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoverItemCarrinhoCompra(int produtoId)
        {
            var produtoSelecionado = _produtoRepository.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);

            if (produtoSelecionado != null)
            {
                _carrinhoCompraservice.RemoverDoCarrinho(produtoSelecionado);
            }

            return RedirectToAction("Index");
        }
    }
}
