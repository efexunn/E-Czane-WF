using E_Czane.Data.Models.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.ViewModels
{
    public class RoleViewModel
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; } 

        public static implicit operator RoleViewModel(RoleDbModel model)
        {
            RoleViewModel result = new RoleViewModel();
            if (model == null)
                return result;
            result.RoleId = model.RoleId;
            result.RoleName = model.RoleName;
            return result;
        }
        public static explicit operator RoleDbModel(RoleViewModel model)
        {
            RoleDbModel result = new RoleDbModel();
            if(model == null) 
                return result;
            result.RoleId = model.RoleId;
            result.RoleName = model.RoleName;
            return result;
        }
    }
}
