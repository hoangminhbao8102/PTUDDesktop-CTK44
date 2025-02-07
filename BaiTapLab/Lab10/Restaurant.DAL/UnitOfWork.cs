﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private RestaurantDbContext _context;

        public UnitOfWork(RestaurantDbContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : class, new()
        {
            return new Repository<T>(_context);
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        private string BuildCommand(string spName, params object[] parameters)
        {
            if (parameters == null || parameters.Length == 0) 
            {
                return $"EXEC {spName}";
            }

            var paramList = string.Join(", ", parameters.Select((item, idx) => $"@p{idx}"));
            return $"EXEC {spName} {paramList}";
        }

        public int SprocNonQuery(string spName, params object[] parameters)
        {
            // EXEC TenThuTuc @p0, @p1, @p2
            var command = BuildCommand(spName, parameters);
            return _context.Database.ExecuteSqlCommand(command, parameters);
        }

        public IList<T> SprocQuery<T>(string spName, params object[] parameters)
        {
            var command = BuildCommand(spName, parameters);
            return _context.Database.SqlQuery<T>(command, parameters).ToList();
        }

        public T SprocScalar<T>(string spName, params object[] parameters)
        {
            var command = BuildCommand(spName, parameters);
            return _context.Database.SqlQuery<T>(command, parameters).SingleOrDefault()!;
        }
    }
}
