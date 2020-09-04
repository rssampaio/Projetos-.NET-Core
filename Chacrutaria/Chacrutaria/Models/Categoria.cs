using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Chacrutaria.Models
{
    public class Categoria
    {
        public int CategoriaId { get; set; }

        [StringLength(100)]
        public string NomeCategoria { get; set; }
        [StringLength(200)]
        public string Descricao { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
