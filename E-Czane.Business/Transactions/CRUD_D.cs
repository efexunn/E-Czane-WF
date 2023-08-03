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
        public bool Delete<T>(int id)
        {
            int? result = connection.Delete<T>(id);
            if(result != null)
                return true;
            return false;
        }
    }
}
