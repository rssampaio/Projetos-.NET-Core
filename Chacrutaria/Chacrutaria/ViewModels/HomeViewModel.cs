using Chacrutaria.Models;
using System.Collections.Generic;

namespace Chacrutaria.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Produto> ProdutosPreferidos { get; set; }
    }
}
