﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamgaMVCAutofac.Core.Model;

namespace TamgaMVCAutofac.Core.Interfaces
{
   public interface IRepository: IDisposable
    {
        void Delete<TEntity>(TEntity entity) where TEntity : class;
        System.Linq.IQueryable<TEntity> GetAll<TEntity>() where TEntity : class;
        TEntity GetById<TEntity>(int id) where TEntity: User;
        void Insert<TEntity>(TEntity entity) where TEntity : class;
        void SaveChanges();
    }
}
