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
    public class AdminManager
    {
        public AdminViewModel isAdminExist(string username, string password)
        {
            using (var conn = new DBManager())
            {
                string sql = $@"SELECT * FROM Admin WHERE AdminUsername = '{username}' AND AdminPassword = '{password}'";
                return conn.QuerySingle<AdminViewModel>(sql);
            }
        }
        public List<AdminDataGridModel> AdminList()
        {
            using (var conn = new DBManager())
            {
                string sql = $@"SELECT
                                a.AdminId,
                                a.AdminUsername,
                                a.AdminFirstName,
                                a.AdminLastName,
                                a.AdminPhone,
                                r.RoleName
                                FROM
                                Admin AS a
                                INNER JOIN 
                                Role AS r
                                ON
                                a.AdminRoleId = r.RoleId
                                WHERE
                                1=1
                                AND
                                a.isActive = 1";

                return conn.Query<AdminDataGridModel>(sql);
            }
        }
        public ArrayList AdminColumnNames()
        {
            var arrList = new ArrayList()
            {
                "Kullanıcı Adı",
                "İsim",
                "Soyisim",
                "Telefon",
                "Yetki"
            };
            return arrList;
        }

        public bool AddNewAdmin(AdminDbModel newAdmin)
        {
            using(var conn = new DBManager())
            {
                var result = (int?)conn.Add(newAdmin);
                return (result != null) ?  true :  false; 
            }
        }
        public AdminDbModel GetAdmin(int id)
        {
            using(var conn = new DBManager())
            {
                return conn.Get<AdminDbModel>(id);
            }
        }

        public void UpdateAdmin(AdminDbModel model)
        {
            using(var conn = new DBManager())
            {
                conn.Update(model);
            }
        }
    }
}
