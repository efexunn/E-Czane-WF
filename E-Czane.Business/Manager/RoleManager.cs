using E_Czane.Business.Transactions;
using E_Czane.Data.Models.DbModels;
using E_Czane.Data.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Business.Manager
{
    public static class RoleManager
    {
        public static List<RoleDbModel> roleList()
        {
            using(var conn = new DBManager())
            {
                return conn.GetList<RoleDbModel>();
            }
        }
    }
}
