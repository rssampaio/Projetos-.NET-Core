using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Chacrutaria.Context;
using Chacrutaria.Models;
using Chacrutaria.Interfaces;

namespace Chacrutaria.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly AppDbContext _context;
        public ProdutoRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Produto> Produtos => _context.Produtos.Include(p => p.Categoria);

        public IEnumerable<Produto> ProdutoPreferido => _context.Produtos.Where(p => p.CarneDestaque).Include(p => p.Categoria);

        public Produto GetProdutoById(int produtoId)
        {
            return _context.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);
        }
    }
}
