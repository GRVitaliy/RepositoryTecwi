using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMVCAutofac.Core.Model;

namespace AppMVCAutofac.Core.Interfaces
{
   public interface IUserRepository: IRepository
    {
        List<User> GetUser(int Id);
        List<User> SearchUser(string strName);
    }
}
