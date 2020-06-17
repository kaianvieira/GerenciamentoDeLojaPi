using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GerenciamentoDeLojaPI.Interfaces;
using GerenciamentoDeLojaPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;

namespace GerenciamentoDeLojaPI.Pages.Produto
{
    public class ExcluirModel : PageModel
    {
        private readonly ICrudRepository<ProdutoModel> _produtoRepository;
        private readonly ICrudRepository<FuncionarioModel> _funcionarioRepository;
        private readonly ICrudRepository<MarcaModel> _marcaRepository;
        private readonly ICrudRepository<SetorModel> _setorRepository;
        private readonly ICrudRepository<TipoModel> _tipoRepository;
        private readonly ICrudRepository<FornecedorModel> _fornecedorRepository;

        public ExcluirModel(ICrudRepository<ProdutoModel> produtoRepository,
            ICrudRepository<FuncionarioModel> funcionarioRepository,
            ICrudRepository<MarcaModel> marcaRepository,
            ICrudRepository<SetorModel> setorRepository,
            ICrudRepository<TipoModel> tipoRepository,
            ICrudRepository<FornecedorModel> fornecedorRepository)
        {
            _produtoRepository = produtoRepository;
            _funcionarioRepository = funcionarioRepository;
            _marcaRepository = marcaRepository;
            _setorRepository = setorRepository;
            _tipoRepository = tipoRepository;
            _fornecedorRepository = fornecedorRepository;
        }

        [BindProperty]
        public ProdutoModel Produto { get; set; }

        public SelectList ListaFuncionarios { get; set; }
        public SelectList ListaMarcas { get; set; }
        public SelectList ListaSetor { get; set; }
        public SelectList ListaTipos { get; set; }
        public SelectList ListaFornecedor { get; set; }

        public string Tamanho { get; set; }
        public string Cor { get; set; }

        public IActionResult OnGet(Guid id)
        {
            Produto = _produtoRepository.Consultar(id);

            ListaFuncionarios = new SelectList(_funcionarioRepository.Listar(), "Id", "Nome");
            ListaMarcas = new SelectList(_marcaRepository.Listar(), "Id", "Nome");
            ListaSetor = new SelectList(_setorRepository.Listar(), "Id", "Nome");
            ListaTipos = new SelectList(_tipoRepository.Listar(), "Id", "Nome");
            ListaFornecedor = new SelectList(_fornecedorRepository.Listar(), "Id", "Nome");

            Tamanho = Produto.Tamanho;
            Cor = Produto.Cor;

            return Page();
        }

        public IActionResult OnPost()
        {
            try
            {
                _produtoRepository.Excluir(Produto.Id);

                return RedirectToPage("Listar");
            }
            catch (Exception)
            {
                throw new Exception("Não foi possivel excluir esse produto.");
            }
        }
    }
}