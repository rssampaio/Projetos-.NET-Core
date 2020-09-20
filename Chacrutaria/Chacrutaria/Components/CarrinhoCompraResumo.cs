using Microsoft.AspNetCore.Mvc;
using Chacrutaria.Models;
using Chacrutaria.ViewModels;
using System.Collections.Generic;

namespace Chacrutaria.Components
{
    public class CarrinhoCompraResumo : ViewComponent
    {
        private readonly CarrinhoCompra _carrinhocompra;

        public CarrinhoCompraResumo(CarrinhoCompra carrinhoCompra)
        {
            _carrinhocompra = carrinhoCompra;
        }

        public IViewComponentResult Invoke()
        {
            var itens = _carrinhocompra.GetCarrinhoCompraItems();

            //var itens = new List<CarrinhoCompraItem>() { new CarrinhoCompraItem(), new CarrinhoCompraItem() };

            _carrinhocompra.CarrinhoCompraItems = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhocompra,
                TotalCarrinho = _carrinhocompra.GetCarrinhoTotalCompra()
            };

            return View(carrinhoCompraVM);
        }
    }
}
