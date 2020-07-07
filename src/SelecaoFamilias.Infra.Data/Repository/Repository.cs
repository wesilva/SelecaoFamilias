using Microsoft.EntityFrameworkCore;
using SelecaoFamilias.Domain.Core.Entities;
using SelecaoFamilias.Domain.Interfaces.Repository;
using SelecaoFamilias.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SelecaoFamilias.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        protected SelecaoFamiliaContext Db;
        protected DbSet<TEntity> DbSet;

        protected Repository(SelecaoFamiliaContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }
        public void Adicionar(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return DbSet.AsNoTracking().Where(predicate);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return DbSet.ToList();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }
        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
