using GerenciamentoDeLojaPI.Interfaces;
using GerenciamentoDeLojaPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace GerenciamentoDeLojaPI.Pages.Funcionario
{
    public class ListarModel : PageModel
    {
        private readonly ICrudRepository<FuncionarioModel> _funcionarioRepository;

        public ListarModel(ICrudRepository<FuncionarioModel> funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }

        public FuncionarioModel Funcionario { get; set; }

        public IEnumerable<FuncionarioModel> Lista { get; set; }

        public IActionResult OnGet()
        {
            Lista = _funcionarioRepository.Listar();

            return Page();
        }
    }
}