using System.Collections.Generic;
using Chacrutaria.Models;

namespace Chacrutaria.Repositories.Interfaces
{
    public interface IProdutoRepository
    {
        IEnumerable<Produto> Produtos { get; }
        IEnumerable<Produto> ProdutoPreferido { get; }
        Produto GetProdutoById(int produtoId);
    }
}
