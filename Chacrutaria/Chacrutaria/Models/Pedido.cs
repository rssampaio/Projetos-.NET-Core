using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chacrutaria.Models
{
    public class Pedido
    {
        [BindNever]
        public int PedidoId { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public decimal PedidoTotal { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime DataHoraPedido { get; set; }
        public List<PedidoItem> PedidoItens { get; set; }
        public int ClienteId { get; set; }
    }
}
