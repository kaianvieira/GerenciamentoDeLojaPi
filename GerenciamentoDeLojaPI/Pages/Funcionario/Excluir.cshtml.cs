using GerenciamentoDeLojaPI.Interfaces;
using GerenciamentoDeLojaPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace GerenciamentoDeLojaPI.Pages.Funcionario
{
    public class ExcluirModel : PageModel
    {
        private readonly ICrudRepository<FuncionarioModel> _funcionarioRepository;

        private readonly ICrudRepository<CargoModel> _cargoRepository;

        public ExcluirModel(ICrudRepository<FuncionarioModel> funcionarioRepository, ICrudRepository<CargoModel> cargoRepository)
        {
            _funcionarioRepository = funcionarioRepository;
            _cargoRepository = cargoRepository;
        }

        [BindProperty]
        public FuncionarioModel Funcionario { get; set; }

        public SelectList ListaCargo { get; set; }

        public IActionResult OnGet(Guid id)
        {
            Funcionario = _funcionarioRepository.Consultar(id);

            ListaCargo = new SelectList(_cargoRepository.Listar(), "Id", "Descricao");

            return Page();
        }

        public IActionResult OnPost(Guid id)
        {
            try
            {
                _funcionarioRepository.Excluir(id);
                return RedirectToPage("Listar");
            }
            catch (Exception)
            {
                throw;
            }                        
        }
    }
}