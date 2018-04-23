using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamgaMVCAutofac.Core.Interfaces;

namespace TamgaMVCAutofac.Core.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        void CommitTransaction();
        void StartTransaction();
    }
}
