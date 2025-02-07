﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL
{
    public interface IRepository<T> where T : class, new()
    {
        IQueryable<T> GetAll();

        T GetById(int id);

        void Insert(T entity);

        void Update(T entity);

        void Delete(T entity);

        T Delete(int id);

        T GetFirst(Expression<Func<T, bool>> condition, string includedProperties = null!);

        IQueryable<T> Search(Expression<Func<T, bool>> condition);
    }
}
