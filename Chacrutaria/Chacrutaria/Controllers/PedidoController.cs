using Chacrutaria.Repositories.Interfaces;
using Chacrutaria.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Authorization;

namespace Chacrutaria.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IClienteRepository _clienteRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        public PedidoController(IPedidoRepository pedidoRepository, IClienteRepository clienteRepository, CarrinhoCompra carrinhoCompra)
        {
            _pedidoRepository = pedidoRepository;
            _clienteRepository = clienteRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Checkout(Cliente cliente)
        {
            
            var itens = _carrinhoCompra.GetCarrinhoCompraItems();
            _carrinhoCompra.CarrinhoCompraItems = itens;

            if (_carrinhoCompra.CarrinhoCompraItems.Count() == 0)
            {
                ModelState.AddModelError("", "Sua cesta de compra está vazia !!");
            }

            if (ModelState.IsValid)
            {
                int clienteId = _clienteRepository.CadastraCliente(cliente);

                var pedido = new Pedido()
                {
                    ClienteId = clienteId,
                    PedidoTotal = 0,
                    DataHoraPedido = System.DateTime.Now
                };

                _pedidoRepository.CriaPedido(clienteId, ref pedido);

                ViewBag.Cliente = cliente.Nome;
                ViewBag.TotalPedido = _carrinhoCompra.GetCarrinhoTotalCompra();
                ViewBag.CheckoutCompletoMensagem = "Obrigado pelo seu pedido :) ";

                _carrinhoCompra.LimparCarrinho();

                return View("~/Views/Pedido/CheckoutCompleto.cshtml", pedido);
            }

            return View(cliente);
        }
        public IActionResult CheckoutCompleto()
        {
            ViewBag.Cliente = TempData["Cliente"];
            ViewBag.DataPedido = TempData["DataPedido"];
            ViewBag.NumeroPedido = TempData["NumeroPedido"];
            ViewBag.TotalPedido = TempData["TotalPedido"];
            ViewBag.CheckoutCompletoMensagem = "Obrigado pelo seu pedido :) ";
            
            return View();
        }

        public IActionResult RetornarInicio()
        {
            return RedirectToAction("Index", "Home");
        }
    }
}
