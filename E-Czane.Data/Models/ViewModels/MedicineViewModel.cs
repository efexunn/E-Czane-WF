using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.ViewModels
{
    public class MedicineViewModel
    {
        public int MedicineId { get; set; }
        public string MedicineName { get; set; }
        public string MedicineBarcode { get; set; }
        public int MedicineCategoryId { get; set; }
        public int MedicineProducerId { get; set; }
        public int MedicineStock { get; set; }
        public decimal MedicinePrice { get; set; }
        public bool isActive { get; set; }
        public string CategoryName { get; set; }
        public string ProducerName { get; set; }
    }
}
