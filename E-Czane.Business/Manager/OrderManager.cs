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
    public class OrderManager
    {
        public int CreateOrder(OrderDbModel model)
        {
            using (var conn = new DBManager())
            {
                return conn.Add(model);
            }
        }

        public void UpdateOrder(OrderDbModel model)
        {
            using (var conn = new DBManager())
            {
                conn.Update(model);
            }
        }

        public List<PurchaseHistoryDatagridModel> GetPurchaseHistory()
        {
            using(var conn = new DBManager())
            {
                string sql = $@"SELECT 
                                o.OrderId,
                                a.AdminUsername,
                                o.OrderTotalAmount,
                                c.CustomerIdentityNumber
                                FROM 
                                OrderHistory AS o
                                INNER JOIN 
                                Admin AS a
                                ON
                                o.OrderAdminId = a.AdminId
                                INNER JOIN Customer as c
                                ON 
                                o.OrderCustomerId = c.CustomerId
                                ";
                return conn.Query<PurchaseHistoryDatagridModel>(sql);
            }
        }

        public ArrayList PurchaseHistoryColumnNames()
        {
            var arrList = new ArrayList()
            {
                "Id",
                "Admin",
                "Tutar TRY",
                "Müşteri TC Kimlik"
            };
            return arrList;
        }

        public OrderViewModel GetOrderSingle(int id)
        {
            using(var conn = new DBManager())
            {
                string sql = $@"SELECT 
                                o.OrderId,
                                o.OrderTotalAmount,
                                c.CustomerFirstName,
                                c.CustomerLastName,
                                c.CustomerIdentityNumber,
                                a.AdminUsername
                                FROM 
                                OrderHistory AS o
                                INNER JOIN
                                Customer AS c
                                ON 
                                o.OrderCustomerId = c.CustomerId
                                INNER JOIN
                                Admin AS a
                                ON 
                                o.OrderAdminId = a.AdminId
                                WHERE
                                1=1
                                AND
                                o.OrderId = {id}";
                return conn.QuerySingle<OrderViewModel>(sql);
            }
        }
    }
}
