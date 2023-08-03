using E_Czane.Business.Transactions;
using E_Czane.Data.Models.DataGridModels;
using E_Czane.Data.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Business.Manager
{
    public class CartManager
    {
        public int AddItemCart(CartDbModel model)
        {
            using(var conn=new DBManager())
            {
                return conn.Add(model);
            }
        }
        public List<CartDatagridModel> GetCartItems(int orderId)
        {
            using(var conn=new DBManager())
            {
                string sql = $@"SELECT
                                c.CartId,
                                m.MedicineBarcode,
                                m.MedicineName,
                                c.CartQuantity,
                                c.CartAmount
                                FROM 
                                Cart AS c
                                INNER JOIN
                                Medicine AS m
                                ON 
                                c.CartMedicineId = m.MedicineId
                                WHERE
                                1=1
                                AND 
                                c.CartOrderId = {orderId}
                                ";
                return conn.Query<CartDatagridModel>(sql);
            }
        }
        

    }
}
