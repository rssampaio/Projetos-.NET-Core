using System.ComponentModel.DataAnnotations;

namespace Chacrutaria.Models
{
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemId { get; set; }
        public Produto Produto { get; set; }
        public int QtdeItens { get; set; }

        [StringLength(200)]
        public string CarrinhoCompraId { get; set; }
    }
}
