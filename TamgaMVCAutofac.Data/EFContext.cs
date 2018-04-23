using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamgaMVCAutofac.Core.Interfaces;
using TamgaMVCAutofac.Core.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace TamgaMVCAutofac.Data
{
    public class EFContext : DbContext, IDbContext
    {
        public EFContext (string connectionString) : base(connectionString)
        {
            Database.SetInitializer<EFContext>(new DBInitializer());
        }
       public new IDbSet<TEntity> Set<TEntity>() where TEntity:class
        {
            return base.Set<TEntity>();
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<User>();
            base.OnModelCreating(modelBuilder);
        }

    }
}
