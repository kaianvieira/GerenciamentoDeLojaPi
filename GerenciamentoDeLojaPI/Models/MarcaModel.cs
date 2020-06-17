using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Threading.Tasks;

namespace GerenciamentoDeLojaPI.Models
{
    public class MarcaModel : BaseModel
    {
        [Display(Name = "Nome da Marca")]
        [Required(ErrorMessage = "Necessário informar o {0}.")]
        [MaxLength(20, ErrorMessage = "{0} pode conter no máximo {1} caractéres.")]
        public string Nome { get; set; }
    }
}
