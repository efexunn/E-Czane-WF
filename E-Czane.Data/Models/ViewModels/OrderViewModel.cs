using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.ViewModels
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public int OrderAdminId { get; set; }
        public decimal OrderTotalAmount { get; set; }
        public int OrderCustomerId { get; set; }
        public bool isActive { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerIdentityNumber { get; set; }
        public string AdminUsername { get; set; }
    }
}
