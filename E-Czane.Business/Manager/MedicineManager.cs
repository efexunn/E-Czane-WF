using E_Czane.Business.Transactions;
using E_Czane.Data.Models.DataGridModels;
using E_Czane.Data.Models.DbModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Business.Manager
{
    public class MedicineManager
    {
        public List<MedicineListDataGridModel> MedicineList()
        {
            using(var conn = new DBManager())
            {
                string sql = $@"SELECT
                                m.MedicineId,
                                m.MedicineBarcode,
                                m.MedicineName,
                                c.CategoryName,
                                p.ProducerName,
                                m.MedicineStock,
                                m.MedicinePrice
                                FROM
                                Medicine AS m
                                INNER JOIN 
                                Producer AS p
                                ON
                                m.MedicineProducerId = p.ProducerId
                                INNER JOIN
                                Category AS c
                                ON
                                m.MedicineCategoryId = c.CategoryId
                                WHERE
                                1=1
                                AND
                                m.isActive = 1
                                ";
                return conn.Query<MedicineListDataGridModel>(sql);
            }
        }

        public List<AddMedicineDatagridModel> AddMedicineList()
        {
            using (var conn = new DBManager())
            {
                string sql = $@"SELECT
                                MedicineId,
                                MedicineBarcode,
                                MedicineName,
                                MedicineStock
                                FROM 
                                Medicine
                                ";
                return conn.Query<AddMedicineDatagridModel>(sql);
            }
        }

        public List<OrderDatagridModel> OrderList()
        {
            using (var conn = new DBManager())
            {
                string sql = $@"SELECT 
                                MedicineId,
                                MedicineBarcode,
                                MedicineName,
                                MedicinePrice,
                                MedicineStock
                                FROM
                                Medicine
                                WHERE
                                1=1
                                AND
                                isActive=1
                                ";
                return conn.Query<OrderDatagridModel>(sql);
            }
        }

        public ArrayList OrderColumnNames()
        {
            ArrayList list = new ArrayList()
            {
                "İlaç Id",
                "Barkod",
                "İlaç Adı",
                "Fiyat",
                "Stok Sayısı",
            };
            return list;
        }

        public ArrayList MedicineListColumnNames()
        {
            ArrayList list = new ArrayList() 
            {
                "İlaç Id",
                "Barkod",
                "İlaç Adı",
                "Kategori",
                "Tedarikçi",
                "Stok Sayısı",
                "Fiyat"
            };
            return list;
        }

        public ArrayList AddMedicineColumnNames()
        {
            ArrayList list = new ArrayList()
            {
                "İlaç Id",
                "Barkod",
                "İlaç Adı",
                "Stok Sayısı"
            };
            return list;
        }

        public void AddNewMedicine(MedicineDbModel medicine)
        {
            using(var conn = new DBManager())
            {
                conn.Add(medicine);
            }
        }

        public MedicineDbModel GetMedicine(int id)
        {
            using( var conn = new DBManager())
            {
                return conn.Get<MedicineDbModel>(id);
            }
        }

        public void UpdateMedicine (MedicineDbModel medicine)
        {
            using(var conn = new DBManager())
            {
                conn.Update(medicine);
            }
        }

        public void DeleteMedicine (int id)
        {
            using(var conn = new DBManager())
            {
                string sql = $@"UPDATE 
                                Medicine 
                                SET 
                                isActive = 0 
                                WHERE 
                                1=1 
                                AND
                                MedicineId = {id}";
                conn.Query<MedicineDbModel>(sql);
            }
        }

        public void ChangeMedicineStock(MedicineDbModel model)
        {
            using(var conn = new DBManager())
            {
                conn.Update(model);
            }
        }

    }
}
