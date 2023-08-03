using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.ViewModels
{
    public class CustomerViewModel
    {
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerIdentityNumber { get; set; }
        public string CustomerPhone { get; set; }
        public bool isActive { get; set; }
    }
}
