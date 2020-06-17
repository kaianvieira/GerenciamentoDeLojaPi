using Microsoft.CodeAnalysis.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeLojaPI.Models
{
    public class FuncionarioModel : BaseModel
    {
        [Display(Name = "Nome do Funcionário")]
        [Required(ErrorMessage = "Necessário informar o {0}.")]
        [MaxLength(45, ErrorMessage = "{0} pode conter no máximo {1} caractéres.")]
        public string Nome { get; set; }

        [Display(Name = "Cargo do Funcionário")]
        [Required(ErrorMessage = "Necessário informar o {0}.")]       
        public Guid IdCargo { get; set; }

        public CargoModel Cargo { get; set; }
    }
}
