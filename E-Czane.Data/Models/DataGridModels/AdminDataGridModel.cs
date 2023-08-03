using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.DataGridModels
{
    public class AdminDataGridModel
    {
        public int AdminId { get; set; }
        public string AdminUsername { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }
        public string AdminPhone { get; set; }
        public string RoleName { get; set; }
    }
}
