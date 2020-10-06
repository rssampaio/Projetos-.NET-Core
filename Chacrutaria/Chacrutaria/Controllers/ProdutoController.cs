using Microsoft.AspNetCore.Mvc;
using Chacrutaria.Repositories.Interfaces;
using Chacrutaria.ViewModels;
using System.Collections.Generic;
using Chacrutaria.Models;
using System.Linq;
using System;

namespace Chacrutaria.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public ProdutoController(IProdutoRepository produtoRepository, ICategoriaRepository categoriaRepository)
        {
            _produtoRepository = produtoRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult ListaProduto(string categoria)
        {
            string _categoria = categoria;
            IEnumerable<Produto> produtos;
            string categoriaAtual = string.Empty;

            if (string.IsNullOrEmpty(categoria))
            {
                produtos = _produtoRepository.Produtos.OrderBy(p => p.ProdutoId);
                categoria = "Todos os Itens";
            }
            else
            {

                produtos = _produtoRepository.Produtos.Where(p =>
                           p.Categoria.NomeCategoria.Equals(_categoria, StringComparison.OrdinalIgnoreCase)).OrderBy(p => p.Nome);

                categoriaAtual = _categoria;
            }

            var produtosListViweModel = new ProdutoListViewModel
            {
                Produtos = produtos,
                CategoriaAtual = categoriaAtual.ToUpper()
            };

            return View(produtosListViweModel);
        }
        public IActionResult Details(int produtoId)
        {
            var produto = _produtoRepository.Produtos.FirstOrDefault(p => p.ProdutoId == produtoId);

            if (produto is null)
            {
                return View("~/Views/Error/Error.cshtml");
            }

            return View(produto);
        }

        public IActionResult Search(string searchstring)
        {
            string _searchstring = searchstring;
            IEnumerable<Produto> produtos;

            if (string.IsNullOrEmpty(_searchstring))
            {
                produtos = _produtoRepository.Produtos.OrderBy(p => p.Nome);
            }
            else
            {
                produtos = _produtoRepository.Produtos.Where(p => p.Nome.ToLower().Contains(_searchstring.ToLower()));
            }

            return View("ListaProduto", new ProdutoListViewModel { Produtos = produtos, CategoriaAtual = ""});
        }
    }
}
