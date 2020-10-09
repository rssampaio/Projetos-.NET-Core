using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chacrutaria.Models
{
    public class Pedido
    {
         public int PedidoId { get; set; }

        [ScaffoldColumn(false)]
        public decimal PedidoTotal { get; set; }
        public List<PedidoItem> PedidoItens { get; set; }
        public int ClienteId { get; set; }

        [Display(Name = "Data/Hora de Recebimento do Pedido")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime DataHoraPedido { get; set; }

        [Display(Name = "Data/Hora da Entrega do Pedido")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0: dd/MM/yyyy hh:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DtaPedidoEntregueEm { get; set; }


    }
}
