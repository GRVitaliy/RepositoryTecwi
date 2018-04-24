﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMVCAutofac.Core.Interfaces;

namespace AppMVCAutofac.Core.Interfaces
{
    public interface IUnitOfWork:IDisposable
    {
        void CommitTransaction();
        void StartTransaction();
    }
}
