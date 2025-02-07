﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL
{
    public class Repository<T> : IRepository<T> where T : class, new()
    {
        public readonly DbContext _context;

        public Repository(DbContext context)
        {
            _context = context;
        }

        public T Delete(int id)
        {
            var entity = GetById(id);
            Delete(entity);

            return entity;
        }

        public void Delete(T entity)
        {
            if (entity != null) 
            {
                _context.Set<T>().Remove(entity);
            }
        }

        public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public T GetFirst(Expression<Func<T, bool>> condition, string includedProperties = null!)
        {
            IQueryable<T> query = _context.Set<T>();

            if (!string.IsNullOrWhiteSpace(includedProperties))
            {
                // Tách và lấy các thuộc tính cần load kèm
                var properties = includedProperties.Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var p in properties) 
                {
                    // Dùng Eager Loading để load dữ liệu mong muốn
                    query = query.Include(p.Trim());
                }
            }

            return query.FirstOrDefault(condition)!;
        }

        public void Insert(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public IQueryable<T> Search(Expression<Func<T, bool>> condition)
        {
            return _context.Set<T>().Where(condition);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
