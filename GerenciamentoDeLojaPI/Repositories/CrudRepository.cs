using GerenciamentoDeLojaPI.Context;
using GerenciamentoDeLojaPI.Interfaces;
using GerenciamentoDeLojaPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace GerenciamentoDeLojaPI.Repositories
{
    internal class CrudRepository<TEntity> : ICrudRepository<TEntity> where TEntity : BaseModel
    {
        protected readonly SqlContext _context;
        protected readonly DbSet<TEntity> _dbSet;
        protected readonly IUnitOfWork _unitOfWork;

        public CrudRepository(SqlContext context, IUnitOfWork unitOfWork)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
            _unitOfWork = unitOfWork;
        }

        public TEntity Incluir(TEntity obj)
        {
            if (obj.Id == Guid.Empty)
            {
                obj.Id = Guid.NewGuid();
            }

            _dbSet.Add(obj);

            if (!_unitOfWork.Commit())
            {
                return null;
            }

            return Consultar(obj.Id);
        }

        public TEntity Consultar(Guid id)
        {
            IQueryable<TEntity> obj = _dbSet.AsNoTracking();

            obj = obj.Include(_context.GetIncludePaths(typeof(TEntity)));

            return obj
                .FirstOrDefault(x => x.Id == id);
        }

        public IQueryable<TEntity> Listar()
        {
            IQueryable<TEntity> obj = _dbSet.AsNoTracking();

            obj = obj.Include(_context.GetIncludePaths(typeof(TEntity)));

            return obj;
        }

        public bool Alterar(TEntity obj)
        {
            _dbSet.Update(obj);

            return _unitOfWork.Commit();
        }

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public bool Excluir(Guid id)
        {
            TEntity obj = Consultar(id);

            _dbSet.Remove(obj);

            return _unitOfWork.Commit();
        }
    }
}
