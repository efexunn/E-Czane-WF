using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.DataGridModels
{
    public class OrderDatagridModel
    {
        public int MedicineId { get; set; }
        public string MedicineBarcode { get; set; }
        public string MedicineName { get; set; }
        public decimal MedicinePrice { get; set; }
        public int MedicineStock { get; set; }
    }
}
