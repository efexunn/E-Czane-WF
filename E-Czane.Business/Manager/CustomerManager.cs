using E_Czane.Business.Transactions;
using E_Czane.Data.Models.DataGridModels;
using E_Czane.Data.Models.DbModels;
using E_Czane.Data.Models.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Business.Manager
{
    public class CustomerManager
    {
        public CustomersDbModel isCustomerExist(string identityNumber)
        {
            using (var conn = new DBManager())
            {
                string sql = $@"SELECT
                                *
                                FROM 
                                Customer
                                WHERE
                                1=1
                                AND
                                CustomerIdentityNumber = '{identityNumber}'";
                return conn.QuerySingle<CustomersDbModel>(sql);
            }
        }
        public List<CustomerDatagridModel> CustomerList()
        {
            using (var conn = new DBManager())
            {
                string sql = $@"SELECT
                                *
                                FROM
                                Customer";
                return conn.Query<CustomerDatagridModel>(sql);
            }
        }
        public ArrayList CustomerColumnNames()
        {
            var arrList = new ArrayList()
            {
                "TC Kimlik No",
                "İsim",
                "Soyisim",
                "Telefon",
            };
            return arrList;
        }

        public bool AddNewCustomer(CustomersDbModel newCustomer)
        {
            using (var conn = new DBManager())
            {
                var result = (int?)conn.Add(newCustomer);
                return (result != null) ? true : false;
            }
        }
        public CustomersDbModel GetCustomer(int id)
        {
            using (var conn = new DBManager())
            {
                return conn.Get<CustomersDbModel>(id);
            }
        }

        public void UpdateCustomer(CustomersDbModel model)
        {
            using (var conn = new DBManager())
            {
                conn.Update(model);
            }
        }

    }
}
