using E_Czane.Business.Manager;
using E_Czane.Data.Models.DataGridModels;
using E_Czane.Data.Models.DbModels;
using E_Czane.Data.Models.ViewModels;
using E_Cznae.UI.FormTransactions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Cznae.UI.Forms
{
    public partial class Admin : Form
    {
        FormsTransactions<AdminDataGridModel> transactions;
        AdminManager adminManager;
        AdminDbModel secilenAdmin;
        int secilenRowId;
        public Admin(int adminId)
        {
            InitializeComponent();
            transactions = new FormsTransactions<AdminDataGridModel>();
            adminManager = new AdminManager();
            secilenAdmin = new AdminDbModel();
        }
        private void RefreshForm()
        {
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxPassword.Text = "";
            textBoxUsername.Text = "";
            textBoxPhone.Text = "";
            btnAddNewAdmin.Visible = true;
            btnUpdate.Visible = false;
            transactions.ShowTable(dataGridAdmin, adminManager.AdminList(), adminManager.AdminColumnNames());
        }
        private void Admin_Load(object sender, EventArgs e)
        {
            // DATAGRID'E ADMIN LISTESINI CEKME
            transactions.ShowTable(dataGridAdmin, adminManager.AdminList(), adminManager.AdminColumnNames());

        }
        private void dataGridAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddNewAdmin.Visible = false;
            btnUpdate.Visible = true;
            if(e.RowIndex >= 0){
                secilenRowId = (int)dataGridAdmin.Rows[e.RowIndex].Cells[0].Value;
                secilenAdmin = adminManager.GetAdmin(secilenRowId);
                textBoxFirstName.Text = secilenAdmin.AdminFirstName;
                textBoxLastName.Text = secilenAdmin.AdminLastName;
                textBoxPassword.Text = secilenAdmin.AdminPassword;
                textBoxUsername.Text = secilenAdmin.AdminUsername;
                textBoxPhone.Text = secilenAdmin.AdminPhone;
            }
        }
        private void btnAddNewAdmin_Click(object sender, EventArgs e)
        {
            var adminList = adminManager.AdminList();
            var isUsernameExist = adminList.Any(s => s.AdminUsername.ToLower() == textBoxUsername.Text.ToLower());
            var isPhoneExist = adminList.Any(s => s.AdminPhone == textBoxPhone.Text);

            if (textBoxFirstName.Text != ""
                &&
                textBoxLastName.Text != ""
                &&
                textBoxPassword.Text != ""
                &&
                textBoxUsername.Text != ""
                &&
                textBoxPhone.Text != ""
                &&
                !isUsernameExist
                &&
                !isPhoneExist)
            {
                var newAdmin = new AdminDbModel();
                newAdmin.AdminFirstName = textBoxFirstName.Text;
                newAdmin.AdminLastName = textBoxLastName.Text;
                newAdmin.AdminUsername = textBoxUsername.Text;
                newAdmin.AdminPassword = textBoxPassword.Text;
                newAdmin.AdminPhone = textBoxPhone.Text;
                newAdmin.AdminRoleId = 2;
                newAdmin.isActive = true;
             
                adminManager.AddNewAdmin(newAdmin);
                MessageBox.Show("Tebrikler! Yeni admin sisteme başarıyla kayıt edilmiştir", "Kayıt Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshForm();
            }
            else
            {
                if (textBoxFirstName.Text == ""
                    ||
                    textBoxLastName.Text == ""
                    ||
                    textBoxPassword.Text == ""
                    ||
                    textBoxUsername.Text == ""
                    ||
                    textBoxPhone.Text == "")
                    MessageBox.Show("Lütfen boş alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (isPhoneExist)
                    MessageBox.Show("Bu telefon numarasinda bir kullanıcı sistemde bulunmaktadır", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (isUsernameExist)
                    MessageBox.Show("Bu kullanici adi zaten kullanilmaktadir", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var adminList = adminManager.AdminList();
            var isUsernameExist = adminList.Any(s => s.AdminId != secilenAdmin.AdminId && s.AdminUsername.ToLower() == textBoxUsername.Text.ToLower());
            var isPhoneExist = adminList.Any(s => s.AdminId != secilenAdmin.AdminId && s.AdminPhone == textBoxPhone.Text);
            if (textBoxFirstName.Text != ""
               &&
               textBoxLastName.Text != ""
               &&
               textBoxPassword.Text != ""
               &&
               textBoxUsername.Text != ""
               &&
               textBoxPhone.Text != ""
               &&
               !isUsernameExist
               &&
               !isPhoneExist
               )
            {
                secilenAdmin.AdminUsername = textBoxUsername.Text;
                secilenAdmin.AdminPhone = textBoxPhone.Text;
                secilenAdmin.AdminFirstName = textBoxFirstName.Text;
                secilenAdmin.AdminLastName = textBoxLastName.Text;
                secilenAdmin.AdminPassword = textBoxPassword.Text;
                adminManager.UpdateAdmin(secilenAdmin);
                RefreshForm();
                MessageBox.Show("Kullanıcı başarıyla güncellenmiştir.", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (textBoxFirstName.Text == ""
                     ||
                     textBoxLastName.Text == ""
                     ||
                     textBoxPassword.Text == ""
                     ||
                     textBoxUsername.Text == ""
                     ||
                     textBoxPhone.Text == "")
                    MessageBox.Show("Lütfen güncellenecek alanları boş bırakmayınız.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (isPhoneExist)
                    MessageBox.Show("Bu telefon numarasinda bir kullanıcı sistemde bulunmaktadır", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                else if (isUsernameExist)
                    MessageBox.Show("Bu kullanici adi başka bir kullanıcıya aittir", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }
        
    }
}
