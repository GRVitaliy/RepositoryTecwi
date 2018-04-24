using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using AppMVCAutofac.Core.Interfaces;
using AppMVCAutofac.Core.Model;

namespace AppMVCAutofac.Data
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

        public List<User> SearchUser(string strName)
        {
            return (from u in this.GetAll<User>()
                    where u.Name.Contains(strName) || u.Position.Contains(strName) || u.Age.Contains(strName)
                    select u).ToList();
         }
    }
}
