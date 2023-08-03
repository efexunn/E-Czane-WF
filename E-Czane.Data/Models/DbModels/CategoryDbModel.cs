
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.DbModels
{
    [Table("Category")]
    public class CategoryDbModel
    {
        [Key]
        public int CategoryId { get; set; }
        [MaxLength(100)]
        public string CategoryName { get; set; }
    }
}
