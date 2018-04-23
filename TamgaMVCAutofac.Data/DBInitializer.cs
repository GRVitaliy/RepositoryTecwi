using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamgaMVCAutofac.Core.Model;
using System.Data.Entity;

namespace TamgaMVCAutofac.Data
{
    class DBInitializer: CreateDatabaseIfNotExists<EFContext>
    {
        protected override void Seed(EFContext context)
        {
            var sqlRep = new SqlRepository(context);

            var Users1 =new User
            {
                Id = 1,
                Surname = "Buhting",
                Name = "Flolrian",
                Patronymic = "Ivanovich",
                PhoneNumber = "+380661111111",
                Employed = true,
                OrganizationName = "Nokia",
                StartOnUtc = DateTime.Now
            };
            var Users2 = new User
            {
                Id = 2,
                Surname = "Petrov",
                Name = "Ivan",
                Patronymic = "Ivanovich",
                PhoneNumber = "+380661111111",
                Employed = true,
                OrganizationName = "Nokia",
                StartOnUtc = DateTime.Now
            };
            var Users3 = new User
            {
                Id = 3,
                Surname = "Stepanov",
                Name = "Alex",
                Patronymic = "Ivanovich",
                PhoneNumber = "+380661111111",
                Employed = true,
                OrganizationName = "Ford",
                StartOnUtc = DateTime.Now
            };
            var Users4 = new User
            {
                Id = 4,
                Surname = "Pavlenko",
                Name = "Roman",
                Patronymic = "Ivanovich",
                PhoneNumber = "+380661111111",
                Employed = true,
                OrganizationName = "Nord",
                StartOnUtc = DateTime.Now
            };
            var Users5 = new User
            {
                Id = 5,
                Surname = "Ivanov",
                Name = "Ivan",
                Patronymic = "Ivanovich",
                PhoneNumber = "+380661111111",
                Employed = true,
                OrganizationName = "Nokia",
                StartOnUtc = DateTime.Now
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
