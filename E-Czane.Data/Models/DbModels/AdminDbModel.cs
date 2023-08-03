using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.DbModels
{
    [Table("Admin")]
    public class AdminDbModel
    {
        [Key]
        public int AdminId { get; set; }
        [MaxLength(50)]
        public string AdminUsername { get; set; }
        [MaxLength(50)]
        public string AdminPassword { get; set; }
        [MaxLength(50)]
        public string AdminFirstName { get; set; }
        [MaxLength(50)]
        public string AdminLastName { get; set; }
        public int AdminRoleId { get; set; }
        [MaxLength(50)]
        public string AdminPhone { get; set; }
        public bool isActive { get; set; }
    }
}
