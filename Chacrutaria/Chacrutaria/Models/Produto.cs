using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chacrutaria.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(100)]
        public string Descricao { get; set; }
        [StringLength(250)]
        public string DescDetalhada { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Preco { get; set; }

        [StringLength(200)]
        public string ImagemUrl { get; set; }
        [StringLength(200)]
        public string ImagemMinilUrl { get; set; }
        public bool CarneDestaque { get; set; }
        public bool TemEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
