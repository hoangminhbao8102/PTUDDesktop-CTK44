using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant.DAL
{
    public interface IUnitOfWork
    {
        int SaveChanges();

        int SprocNonQuery(string spName, params object[] parameters);

        IList<T> SprocQuery<T>(string spName, params object[] parameters);

        T SprocScalar<T>(string spName, params object[] parameters);

        IRepository<T> GetRepository<T>() where T : class, new();
    }
}
