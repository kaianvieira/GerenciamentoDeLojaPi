using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciamentoDeLojaPI.Interfaces;
using GerenciamentoDeLojaPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace GerenciamentoDeLojaPI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ICrudRepository<ProdutoModel> _produtoRepository;

        public IndexModel(ILogger<IndexModel> logger, ICrudRepository<ProdutoModel> produtoRepository)
        {
            _logger = logger;
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<ProdutoModel> Produtos { get; set; }

        public IActionResult OnGet()
        {
            Produtos = _produtoRepository.Listar();

            return Page();
        }
    }
}
