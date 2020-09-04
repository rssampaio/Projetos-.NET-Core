using System.Collections.Generic;
using Chacrutaria.Models;

namespace Chacrutaria.ViewModels
{
    public class ProdutoListViewModel
    {
        public IEnumerable<Produto> Produtos;
        public string CategoriaAtual { get; set; }

    }
}
