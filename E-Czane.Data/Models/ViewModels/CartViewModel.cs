using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.ViewModels
{
    public class CartViewModel
    {
        public int CartId { get; set; }
        public int CartMedicineId { get; set; }
        public int CartQuantity { get; set; }
        public int CartOrderId { get; set; }
        public bool isActive { get; set; }
        public string MedicineName { get; set; }
        public string MedicineDescription { get; set; }
        public string MedicineIngredientName { get; set; }
        public decimal MedicineIngredientQuantity { get; set; }
        public decimal MedicinePrice { get; set; }
    }
}
