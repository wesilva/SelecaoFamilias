using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SelecaoFamilias.Domain.Interfaces
{
    public interface IRepository<TEntity> : IDisposable
    {
        void Adicionar(TEntity obj);
        TEntity ObterPorId(Guid id);
        IEnumerable<TEntity> ObterTodos();
        IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
        int SaveChanges();
    }
}
