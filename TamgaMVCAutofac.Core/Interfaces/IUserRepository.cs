using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamgaMVCAutofac.Core.Model;

namespace TamgaMVCAutofac.Core.Interfaces
{
   public interface IUserRepository: IRepository
    {
        List<User> GetUser(int Id);
    }
}
