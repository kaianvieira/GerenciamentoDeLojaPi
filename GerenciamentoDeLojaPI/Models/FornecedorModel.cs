using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeLojaPI.Models
{
    public class FornecedorModel : BaseModel
    {
        public string Nome { get; set; }
    }
}
