using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCEFDDD.Model.Repository
{
    public interface IBaseRepository<TEntity>
    {
        void Save(TEntity entity);
        void Delete(Guid id);
    }
}
