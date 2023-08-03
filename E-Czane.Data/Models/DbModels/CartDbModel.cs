
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.DbModels
{
    [Table("Cart")]
    public class CartDbModel
    {
        [Key]
        public int CartId { get; set; }
        public int CartMedicineId { get; set; }
        public int CartQuantity { get; set; }
        public decimal CartAmount { get; set; }
        public int CartOrderId { get; set; }
        public bool isActive { get; set; }
    }
}
