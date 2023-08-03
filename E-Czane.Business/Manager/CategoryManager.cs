using E_Czane.Business.Transactions;
using E_Czane.Data.Models.DbModels;
using E_Czane.Data.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Business.Manager
{
    public static class CategoryManager
    {
        public static List<CategoryDbModel> GetCategoryList()
        {
            using(var conn = new DBManager())
            {
                return conn.GetList<CategoryDbModel>();
            }
        }
    }
}
