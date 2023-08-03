
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.DbModels
{
    [Table("OrderHistory")]
    public class OrderDbModel
    {
        [Key]
        public int OrderId { get; set; }
        public int OrderAdminId { get; set; }
        public decimal OrderTotalAmount { get; set; }
        public int OrderCustomerId { get; set; }
        public bool isActive { get; set; }
    }
}
