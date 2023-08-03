
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.DbModels
{
    [Table("Medicine")]
    public class MedicineDbModel
    {
        [Key]
        public int MedicineId { get; set; }
        [MaxLength(50)]
        public string MedicineName { get; set; }
        [MaxLength(13)]
        public string MedicineBarcode { get; set; }
        [MaxLength(100)]
        public int MedicineCategoryId { get; set; }
        public int MedicineProducerId { get; set; }
        public int MedicineStock { get; set; }
        public decimal MedicinePrice { get; set; }
        public bool isActive { get; set; }
    }
}
