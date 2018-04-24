using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppMVCAutofac.Core.Model;
using System.Data.Entity;

namespace AppMVCAutofac.Data
{
    class DBInitializer: CreateDatabaseIfNotExists<EFContext>
    {
        protected override void Seed(EFContext context)
        {
            var sqlRep = new SqlRepository(context);

            var Users1 =new User
            {
                Id = 1,
                Name = "Flolrian Buhting",
                Position = "Manager",
                Age = "51",
                StartDate = DateTime.Now
            };
            var Users2 = new User
            {
                Id = 2,
                Name = "Ivan Petrov",
                Position = "Head of IT",
                Age = "40",
                StartDate = DateTime.Now
            };
            var Users3 = new User
            {
                Id = 3,
                Name = "Alex Stepanov",
                Position = "Accauntant",
                Age = "31",
                StartDate = DateTime.Now
            };
            var Users4 = new User
            {
                Id = 4,
                Name = "Roman Pavlenko",
                Position = "Manager",
                Age = "45",
                StartDate = DateTime.Now
            };
            var Users5 = new User
            {
                Id = 5,
                Name = "Ivan Ivanov",
                Position = "Administrator",
                Age = "25",
                StartDate = DateTime.Now
            };
            sqlRep.Insert<User>(Users1);
            sqlRep.Insert<User>(Users2);
            sqlRep.Insert<User>(Users3);
            sqlRep.Insert<User>(Users4);
            sqlRep.Insert<User>(Users5);
            context.SaveChanges();
        }
    }
}
