using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TamgaMVCAutofac.Core.Interfaces;
using TamgaMVCAutofac.Core.Model;

namespace TamgaMVCAutofac.Data
{
    class UserRepository : SqlRepository, IUserRepository
    {
        public UserRepository(IDbContext context):base(context)
        {

        }
        public List<User> GetUser(int Id)
        {
            return (from u in this.GetAll<User>()
                    where u.Id == Id
                    select u).ToList();
        }
    }
}
