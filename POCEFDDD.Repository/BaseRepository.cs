using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCEFDDD.Model.Repository;

namespace POCEFDDD.Repository
{
    public abstract class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity>
        where TContext : DbContext
        where TEntity : class
    {
        protected TContext _context { get; set; }

        public void Save(TEntity entity)
        {
            var dbSet = _context.Set<TEntity>();
            dbSet.Add(entity);
        }

        public void Delete(Guid id)
        {
            var dbSet = _context.Set<TEntity>();
            dbSet.Remove(_context.Set<TEntity>().Find(id));
        }
    }
}
