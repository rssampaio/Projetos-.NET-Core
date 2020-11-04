using Chacrutaria.Models;
using System.Collections.Generic;

namespace Chacrutaria.ViewModels
{
    public class PedidoProdutosViewModel
    {
        public Pedido Pedido { get; set; }
        public IEnumerable<PedidoItem> PedidoItens { get; set; }
        public Cliente Cliente { get; set; }
    }
}
