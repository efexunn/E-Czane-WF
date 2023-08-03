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
        public bool Update<T>(T entity)
        {
            var result = connection.Update<T>(entity);
            return (result == null) ? false : true;
        }
    }
}
