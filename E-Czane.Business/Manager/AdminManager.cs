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
        /// <summary>
        /// Parametre olarak verilen kullanıcı adı ve şifre değerlerini veri tabanı ile karşılaştırır
        /// </summary>
        /// <param name="username">Kullanıcı Adı</param>
        /// <param name="password">Şifre</param>
        /// <returns>Eğer girilen parametreler veri tabanı ile eşleşiyorsa bir Admin nesnesi döner</returns>
        public AdminViewModel isAdminExist(string username, string password)
        {
            using (var conn = new DBManager())
            {
                string sql = $@"SELECT * FROM Admin WHERE AdminUsername = '{username}' AND AdminPassword = '{password}'";
                return conn.QuerySingle<AdminViewModel>(sql);
            }
        }
        /// <summary>
        /// Veri tabanında bulunan adminleri AdminDataGridModel sınıfına göre listeler
        /// </summary>
        /// <returns>AdminDataGridModel sınıfı türünde bir liste döner içersinde Admin tablosundan gelen veriler bulunur.</returns>
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
        /// <summary>
        /// DataGrid'de bulunan sütun isimlerinin tanımlandığı bir fonksiyon
        /// </summary>
        /// <returns>İçersinde sütun isimlerinin bulunduğu bir ArrayList döner</returns>
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
        /// <summary>
        /// Veri tabanına yeni bir Admin eklemek için kullanılır.
        /// </summary>
        /// <param name="newAdmin">AdminDbModel türünde eklenmek istenen Admin kaydını parametre alır</param>
        /// <returns>Bool bir değer döner. Eğer işlem başarıla olursa true başarısız olursa false</returns>
        public bool AddNewAdmin(AdminDbModel newAdmin)
        {
            using(var conn = new DBManager())
            {
                var result = (int?)conn.Add(newAdmin);
                return (result != null) ?  true :  false; 
            }
        }
        /// <summary>
        /// İstenilen Admin kaydını AdminId üzerinden sorgular ve AdminDbModel olarak döndürür
        /// </summary>
        /// <param name="id">Sorgulanmak istenen Adminin Id değeri</param>
        /// <returns></returns>
        public AdminDbModel GetAdmin(int id)
        {
            using(var conn = new DBManager())
            {
                return conn.Get<AdminDbModel>(id);
            }
        }
        /// <summary>
        /// Var olan bir Admin kaydını güncellemek için kullanılır.
        /// </summary>
        /// <param name="model">Güncellenmek istenen AdminDbModel bir obje parametre alır.</param>
        public void UpdateAdmin(AdminDbModel model)
        {
            using(var conn = new DBManager())
            {
                conn.Update(model);
            }
        }
    }
}
