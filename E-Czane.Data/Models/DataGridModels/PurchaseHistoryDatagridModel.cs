using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.DataGridModels
{
    public class PurchaseHistoryDatagridModel
    {
        public int OrderId { get; set; }
        public string AdminUsername { get; set; }
        public decimal TotalAmount { get; set; }
        public string CustomerIdentityNumber { get; set; }

    }
}
