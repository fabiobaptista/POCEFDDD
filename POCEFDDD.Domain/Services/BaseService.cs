using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCEFDDD.Model.Services.Abstract;
using POCEFDDD.Model.Repository;

namespace POCEFDDD.Model.Services
{
    public abstract class BaseService<TEntity, TRepository> : IBaseService<TEntity, TRepository>
        where TEntity : class
        where TRepository : IBaseRepository<TEntity>
    {
        protected TRepository _repository { get; set; }

        public void Save(TEntity entity)
        {
            _repository.Save(entity);
        }

        public void Delte(Guid id)
        {
            _repository.Delete(id);
        }
    }
}
