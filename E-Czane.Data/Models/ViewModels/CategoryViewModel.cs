using E_Czane.Data.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.ViewModels
{
    public class CategoryViewModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }

        public static implicit operator CategoryViewModel(CategoryDbModel model)
        {
            CategoryViewModel result = new CategoryViewModel();
            if (model == null)
                return result;
            result.CategoryId = model.CategoryId;
            result.CategoryName = model.CategoryName;
            return result;
        }
        public static explicit operator CategoryDbModel(CategoryViewModel model)
        {
            CategoryDbModel result = new CategoryDbModel();
            if (model == null) 
                return result;
            result.CategoryId = model.CategoryId;
            result.CategoryName = model.CategoryName;
            return result;
        }

    }
}
