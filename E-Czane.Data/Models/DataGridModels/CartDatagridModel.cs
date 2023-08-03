using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.DataGridModels
{
    public class CartDatagridModel
    {
        public string MedicineBarcode { get; set; }
        public string MedicineName { get; set; }
        public int CartQuantity { get; set; }
        public decimal CartAmount { get; set; }
    }
}
