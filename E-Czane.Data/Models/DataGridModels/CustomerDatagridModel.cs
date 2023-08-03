using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.DataGridModels
{
    public class CustomerDatagridModel
    {
        public int CustomerId { get; set; }
        public string CustomerIdentityNumber { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerPhone { get; set; }
    }
}
