using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCEFDDD.Model.Entities;
using POCEFDDD.Model.Repository;

namespace POCEFDDD.Model.Services.Abstract
{
    public interface IUserService : IBaseService<User, IUserRepository>
    {
        IList<User> GetList(int skip=0, int take=10);
    }
}
