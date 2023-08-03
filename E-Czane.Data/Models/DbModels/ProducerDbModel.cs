
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.DbModels
{
    [Table("Producer")]
    public class ProducerDbModel
    {
        [Key]
        public int ProducerId { get; set; }
        [MaxLength(100)]
        public string ProducerName { get; set; }
    }
}
