using System;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Chacrutaria.Context;
using Chacrutaria.Models;
using System.Collections.Generic;

namespace Chacrutaria.Models
{
    public class CarrinhoCompra
    {
        private AppDbContext _context;

        public CarrinhoCompra(AppDbContext context)
        {
            _context = context;
        }

        public string CarrinhoCompraId { get; set; }
        public List<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }

        public static CarrinhoCompra GetCarrinho(System.IServiceProvider services)
        {
            // define uma sessão utilizando o contexto ( banco de dados ) atual
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;

            // Obtem um serviço do tipo do nosso contexto
            var context = services.GetService<AppDbContext>();

            // Obtem ou gera o Id do carrinho
            string carrinhoId = session.GetString("CarrinhoId") ?? Guid.NewGuid().ToString();

            // atribui o Id co carrinho na sessão
            session.SetString("CarrinhoId", carrinhoId);

            // retorna o carrinho com o contexto atual
            return new CarrinhoCompra(context)
            {
                CarrinhoCompraId = carrinhoId
            };
        }

        public void AdcionarAoCarrinho(Produto produto, int quantidade)
        {
            var carrinhoCompraItem = _context.CarrinhoCompraItens.SingleOrDefault(
                p => p.Produto.ProdutoId == produto.ProdutoId && p.CarrinhoCompraId == CarrinhoCompraId);

            // Verifica se o carrinho de compra existe, senão existir cria
            if (carrinhoCompraItem == null)
            {
                carrinhoCompraItem = new CarrinhoCompraItem
                {
                    CarrinhoCompraId = CarrinhoCompraId,
                    Produto = produto,
                    QtdeItens = 1
                };
                _context.CarrinhoCompraItens.Add(carrinhoCompraItem);
            }
            else // Se existir o carrinho com o item, então incrementa a quantidade
            {
                carrinhoCompraItem.QtdeItens++;
            }

            _context.SaveChanges();
        }

        public int RemoverDoCarrinho(Produto produto)
        {
            var carrinhoCompraItem = _context.CarrinhoCompraItens.SingleOrDefault(
                p => p.Produto.ProdutoId == produto.ProdutoId && p.CarrinhoCompraId == CarrinhoCompraId);

            var quantidadelocal = 0;

            // Verifica se o carrinho de compra existe, senão existir cria
            if (carrinhoCompraItem != null)
            {
                if (carrinhoCompraItem.QtdeItens > 1)
                {
                    carrinhoCompraItem.QtdeItens--;
                    quantidadelocal = carrinhoCompraItem.QtdeItens;
                }
                else
                {
                    _context.CarrinhoCompraItens.Remove(carrinhoCompraItem);
                }
            }

            _context.SaveChanges();

            return quantidadelocal;
        }

        public List<CarrinhoCompraItem> GetCarrinhoCompraItems()
        {
            return CarrinhoCompraItems ??
                (CarrinhoCompraItems =
                _context.CarrinhoCompraItens.Where(p => p.CarrinhoCompraId == CarrinhoCompraId)
                .Include(p => p.Produto)
                .ToList()
                );
        }

        public void LimparCarrinho()
        {
            var carrinhoItens = _context.CarrinhoCompraItens.Where(
                carrinho => carrinho.CarrinhoCompraId == CarrinhoCompraId);

            _context.CarrinhoCompraItens.RemoveRange(carrinhoItens);

            _context.SaveChanges();
        }

        public decimal GetCarrinhoTotalCompra()
        {
            var total = _context.CarrinhoCompraItens.Where(
                p => p.CarrinhoCompraId == CarrinhoCompraId)
                .Select(p => p.Produto.Preco * p.QtdeItens).Sum();

            return total;
        }

    }
}
