using Chacrutaria.Context;
using Chacrutaria.Repositories.Interfaces;
using Chacrutaria.Models;
using System;


namespace Chacrutaria.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly CarrinhoCompra _carrinhoCompra;
        private decimal totalPedido;

        public PedidoRepository(AppDbContext appDbContext, CarrinhoCompra carrinhoCompra)
        {
            _appDbContext = appDbContext;
            _carrinhoCompra = carrinhoCompra;
        }
        public void CriaPedido(int clienteId, ref Pedido pedidoRetorno)
        {

            //var pedido = new Pedido() 
            //{
            //    ClienteId = clienteId,
            //    PedidoTotal = 0,
            //    DataHoraPedido = DateTime.Now
            //};

            _appDbContext.Pedidos.Add(pedidoRetorno);
            _appDbContext.SaveChanges();

            var carrinhoItens = _carrinhoCompra.CarrinhoCompraItems;

            foreach (var i in carrinhoItens)
            {
                var pedidoItem = new PedidoItem()
                {
                    Quantidade = i.QtdeItens,
                    ProdutoId = i.Produto.ProdutoId,
                    PedidoId = pedidoRetorno.PedidoId,
                    Preco = (i.Produto.Preco * i.QtdeItens)
                };

                _appDbContext.PedidoItens.Add(pedidoItem);

                totalPedido = (totalPedido + (i.Produto.Preco * i.QtdeItens));
            }

            pedidoRetorno.PedidoTotal = totalPedido;

            _appDbContext.Update(pedidoRetorno);

            _appDbContext.SaveChanges();
        }
    }
}
