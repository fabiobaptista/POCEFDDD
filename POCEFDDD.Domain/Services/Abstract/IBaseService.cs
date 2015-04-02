using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POCEFDDD.Model.Services.Abstract
{
    public interface IBaseService<TEntity, TRepository>
    {
        void Save(TEntity entity);
        void Delte(Guid id);
    }
}
