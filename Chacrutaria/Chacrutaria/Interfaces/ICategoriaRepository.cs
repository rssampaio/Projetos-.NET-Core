using System.Collections.Generic;
using Chacrutaria.Models;

namespace Chacrutaria.Interfaces
{
    public interface ICategoriaRepository
    {
        IEnumerable<Categoria> Categorias { get; }
    }
}
