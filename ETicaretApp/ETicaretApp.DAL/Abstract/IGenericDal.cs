﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApp.DAL.Abstract
{
    public interface IGenericDal<TEntity> where TEntity : class
    {
        List<TEntity> ListAll();
        void Create (TEntity entity);
        void Update (TEntity entity);
        void Delete (TEntity entity);
        TEntity GetById (int id);
 
        IQueryable<TEntity> Query();
    }
}
