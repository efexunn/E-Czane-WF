using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Business.Transactions
{
    public abstract partial class aDapperContext
    {
        public T Get<T>(int id)
        {
            return connection.Get<T>(id);
        }
       
        public List<T> GetList<T>(string sql)
        {
            return connection.Query<T>(sql).ToList();
        }
        public List<T> GetList<T>()
        {
            return connection.GetList<T>().ToList();
        }

    }
}
