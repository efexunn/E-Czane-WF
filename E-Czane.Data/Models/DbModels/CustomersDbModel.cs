using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.DbModels
{

    [Table("Customer")]
    public class CustomersDbModel
    {
        [Key]
        public int CustomerId { get; set; }
        [MaxLength(50)]
        public string CustomerFirstName { get; set; }
        [MaxLength(50)]
        public string CustomerLastName { get; set; }
        [MaxLength(11)]
        public string CustomerIdentityNumber { get; set; }
        [MaxLength(50)]
        public string CustomerPhone { get; set; }
        public bool isActive { get; set; }
    }

}
