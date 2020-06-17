using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeLojaPI.Interfaces
{
    public interface ICrudRepository<TEntity> : IDisposable
    {
        TEntity Incluir(TEntity obj);

        TEntity Consultar(Guid id);

        IQueryable<TEntity> Listar();

        bool Alterar(TEntity obj);

        bool Excluir(Guid id);
    }
}
