using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SelecaoFamilias.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable
    {
        void Adicionar(TEntity obj);
        IEnumerable<TEntity> ObterTodos();
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
    }
}
