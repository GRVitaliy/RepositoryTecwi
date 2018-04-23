using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using TamgaMVCAutofac.Core.Interfaces;

namespace TamgaMVCAutofac.Data
{
    public class DataModule: Module
    {
        private string connStr;
        public DataModule(string connectionString)
        {
            this.connStr = connectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c=>new EFContext(this.connStr)).As<IDbContext>().InstancePerRequest();
            builder.RegisterType<SqlRepository>().As<IRepository>().InstancePerRequest();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerRequest();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            base.Load(builder);
        }

    }
}
