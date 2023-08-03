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
        public List<T> Query<T>(string sql)
        {
            var result = connection.Query<T>(sql).ToList();
            return result;
        }
        public int Execute(string sql)
        {
            var result = connection.Execute(sql);
            return result;
        }
        public T QuerySingle<T>(string sql)
        {
            return connection.QueryFirstOrDefault<T>(sql);
        }
    }
}
