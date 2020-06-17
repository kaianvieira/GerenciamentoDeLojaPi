using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciamentoDeLojaPI.Interfaces;
using GerenciamentoDeLojaPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GerenciamentoDeLojaPI.Pages.Produto
{
    public class ListarModel : PageModel
    {
        private readonly ICrudRepository<ProdutoModel> _produtoRepository;

        public ListarModel(ICrudRepository<ProdutoModel> produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public ProdutoModel Produto { get; set; }

        public IEnumerable<ProdutoModel> Lista { get; set; }

        public IActionResult OnGet()
        {
            Lista = _produtoRepository.Listar();

            return Page();
        }
    }
}