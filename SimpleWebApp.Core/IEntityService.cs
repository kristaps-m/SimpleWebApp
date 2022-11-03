﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApp.Core
{
    public interface IEntityService<T> where T : Entity
    {
        void Create(T entity);

        void Delete(T entity);

        void Update(T entity);

        List<T> GetAll();

        T GetById(int id);

        IQueryable<T> Query();
    }
}
