
using Chacrutaria.Context;
using System.Collections.Generic;

namespace Chacrutaria.Models
{
    public class CarrinhoCompra
    {
        private AppDbContext context;

        public CarrinhoCompra(AppDbContext context)
        {
            this.context = context;
        }

        public string CarrinhoCompraId { get; set; }
        public List<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }

    }
}
