using System.Collections.Generic;
using Chacrutaria.Models;

namespace Chacrutaria.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
