
using System.Collections.Generic;
using Chacrutaria.Context;
using Chacrutaria.Models;
using Chacrutaria.Interfaces;

namespace Chacrutaria.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbContext _context;
        public CategoriaRepository(AppDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Categoria> Categorias => _context.Categorias;
    }
}
