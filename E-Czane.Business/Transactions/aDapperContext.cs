using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Business.Transactions
{
    public abstract partial class aDapperContext:IDisposable
    {
        protected IDbConnection connection;
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=Pharmacy;Trusted_Connection=True;";

        public aDapperContext(IDbConnection dbConnection)
        {
            if(dbConnection != null)
            {
                connection = dbConnection;  
            }
            else
            {
                connection = new SqlConnection(connectionString);
            }
            connection.Open();
        }


        public void Dispose()
        {
            connection.Close();
            connection = null; 
        }
    }
}
