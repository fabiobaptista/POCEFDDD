using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCEFDDD.Model.Entities;

namespace POCEFDDD.Model.Repository
{
    public interface IUserRepository
    {
        IList<User> GetList(int skip, int take);
    }
}
