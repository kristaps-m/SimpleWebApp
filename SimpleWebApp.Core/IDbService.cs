﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleWebApp.Core
{
    public interface IDbService
    {
        void Create<T>(T entity) where T : Entity;

        void Delete<T>(T entity) where T : Entity;

        void Update<T>(T entity) where T : Entity;

        List<T> GetAll<T>() where T : Entity;

        T GetById<T>(int id) where T : Entity;

        IQueryable<T> Query<T>() where T : Entity;
    }
}
