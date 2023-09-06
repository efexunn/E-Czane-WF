using System;
using System.Collections.Generic;
using System.Configuration;
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
		private string connectionString = ConfigurationManager.ConnectionStrings["E_Cznae.UI.Properties.Settings.PharmacyConnectionString"].ConnectionString;


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
