using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POCEFDDD.context;
using POCEFDDD.Model.Entities;
using POCEFDDD.Model.Repository;

namespace POCEFDDD.Repository
{
    public class UserRepository : BaseRepository<User, AppContext>, IUserRepository 
    {
        public UserRepository(AppContext context)
        {
            _context = context;
        }

        public IList<User> GetList(int skip=0, int take=10)
        {
            return _context.Users.OrderBy(_ => _.Name).Skip(skip).Take(take).ToList();
        }
    }
}
