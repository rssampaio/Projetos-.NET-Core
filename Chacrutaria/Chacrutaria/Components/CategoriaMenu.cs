using Microsoft.AspNetCore.Mvc;
using Chacrutaria.Repositories.Interfaces;
using System.Linq;

namespace Chacrutaria.Components
{
    public class CategoriaMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaMenu(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepository.Categorias.OrderBy(c => c.NomeCategoria);

            return View(categorias);
        }
    }
}
