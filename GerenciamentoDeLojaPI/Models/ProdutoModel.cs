using System;
using System.ComponentModel.DataAnnotations;

namespace GerenciamentoDeLojaPI.Models
{
    public class ProdutoModel : BaseModel
    {
        [Display(Name = "Tamanho")]
        [Required(ErrorMessage = "Necessário informar o {0}.")]
        [MaxLength(15, ErrorMessage = "{0} pode conter no máximo {1} caractéres.")]
        public string Tamanho { get; set; }

        [Display(Name = "Cor")]
        [Required(ErrorMessage = "Necessário informar o {0}.")]
        [MaxLength(25, ErrorMessage = "{0} pode conter no máximo {1} caractéres.")]
        public string Cor { get; set; }

        [Display(Name = "Marca")]
        [Required(ErrorMessage = "Necessário informar o {0}.")]
        public Guid IdMarca { get; set; }

        [Display(Name = "Funcionário")]
        [Required(ErrorMessage = "Necessário informar o {0}.")]
        public Guid IdFuncionario { get; set; }

        [Display(Name = "Setor")]
        [Required(ErrorMessage = "Necessário informar o {0}.")]
        public Guid IdSetor { get; set; }

        [Display(Name = "Tipo")]
        [Required(ErrorMessage = "Necessário informar o {0}.")]
        public Guid IdTipo { get; set; }

        [Display(Name = "Fornecedor")]
        [Required(ErrorMessage = "Necessário informar o {0}.")]
        public Guid IdFornecedor { get; set; }

        public MarcaModel Marca { get; set; }

        public FuncionarioModel Funcionario { get; set; }

        public SetorModel Setor { get; set; }

        public TipoModel Tipo { get; set; }

        public FornecedorModel Fornecedor { get; set; }
    }
}
