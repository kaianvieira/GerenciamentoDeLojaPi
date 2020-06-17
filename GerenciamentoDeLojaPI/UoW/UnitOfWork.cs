using GerenciamentoDeLojaPI.Context;
using GerenciamentoDeLojaPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciamentoDeLojaPI.UoW
{
    internal class UnitOfWork : IUnitOfWork
    {
        private readonly SqlContext _context;

        public UnitOfWork(SqlContext context)
        {
            _context = context;
        }

        public bool Commit()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }
    }
}
