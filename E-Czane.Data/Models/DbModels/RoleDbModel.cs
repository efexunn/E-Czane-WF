
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.DbModels
{
    [Table("Role")]
    public class RoleDbModel
    {
        [Key]
        public int RoleId { get; set; }
        [MaxLength(50)]
        public string RoleName { get; set; }
    }
}
