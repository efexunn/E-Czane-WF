using E_Czane.Data.Models.DbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Czane.Data.Models.ViewModels
{
    public class AdminViewModel
    {
        public int AdminId { get; set; }
        public string AdminUsername { get; set; }
        public string AdminPassword { get; set; }
        public string AdminFirstName { get; set; }
        public string AdminLastName { get; set; }
        public int AdminRoleId { get; set; }
        public string AdminPhone { get; set; }
        public bool isActive { get; set; }
        public string RoleName { get; set; }

        public static implicit operator AdminViewModel(AdminDbModel model)
        {
            AdminViewModel result = new AdminViewModel();
            if(model == null)
                return result;
            result.AdminId = model.AdminId;
            result.AdminUsername = model.AdminUsername;
            result.AdminPassword = model.AdminPassword;
            result.AdminFirstName = model.AdminFirstName;
            result.AdminLastName = model.AdminLastName;
            result.AdminRoleId = model.AdminRoleId;
            result.AdminPhone = model.AdminPhone;
            result.isActive = model.isActive;
            return result;
        }
        public static explicit operator AdminDbModel(AdminViewModel model)
        {
            AdminDbModel result = new AdminDbModel();
            if (model == null)
                return result;
            result.AdminId = model.AdminId;
            result.AdminUsername = model.AdminUsername;
            result.AdminPassword = model.AdminPassword;
            result.AdminFirstName = model.AdminFirstName;
            result.AdminLastName = model.AdminLastName;
            result.AdminRoleId =(int)model.AdminRoleId;
            result.AdminPhone = model.AdminPhone;
            result.isActive = model.isActive;
            return result;
        }
    }

}
