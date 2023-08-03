using E_Czane.Business.Manager;
using E_Czane.Data.Models.DataGridModels;
using E_Czane.Data.Models.DbModels;
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
    public partial class Customers : Form
    {
        FormsTransactions<CustomerDatagridModel> transactions;
        CustomerManager custManager;
        CustomersDbModel secilenCustomer;
        public Customers(int adminId)
        {
            InitializeComponent();
            transactions = new FormsTransactions<CustomerDatagridModel>();
            custManager = new CustomerManager();
            secilenCustomer = new CustomersDbModel();
        }

        private void RefreshForm()
        {
            btnUpdate.Visible = false;
            btnAdd.Visible = true;
            textBoxIdentityNumber.Text = string.Empty;
            textBoxFirstName.Text = string.Empty;
            textBoxLastName.Text = string.Empty;
            textBoxPhone.Text = string.Empty;
            transactions.ShowTable(dataGridCustomer, custManager.CustomerList(), custManager.CustomerColumnNames());
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var customerList = custManager.CustomerList();
            var newCustomer = new CustomersDbModel();
            bool isCustomerExist = customerList.Any(s => s.CustomerIdentityNumber == textBoxIdentityNumber.Text);

            if (!isCustomerExist
                &&
                textBoxFirstName.Text != ""
                &&
                textBoxLastName.Text != ""
                &&
                textBoxPhone.Text.Length == 11
                &&
                textBoxIdentityNumber.Text.Length == 11)
            {
                newCustomer.CustomerIdentityNumber = textBoxIdentityNumber.Text;
                newCustomer.CustomerFirstName = textBoxFirstName.Text;
                newCustomer.CustomerLastName = textBoxLastName.Text;
                newCustomer.CustomerPhone = textBoxPhone.Text;
                newCustomer.isActive = true;
                custManager.AddNewCustomer(newCustomer);
                MessageBox.Show("Kullanıcı sisteme başarıyla kaydedilmiştir.", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshForm();

            }
            else
            {
                if (isCustomerExist)
                {
                    MessageBox.Show("Bu TC Kimlik Numarasına sahip bir kişi sistemde kayıtlıdır.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(textBoxFirstName.Text == "" || textBoxLastName.Text == "")
                {
                    MessageBox.Show("İsim ve soyisim alanları boş bırakılamaz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(textBoxPhone.Text.Length != 11)
                {
                    MessageBox.Show("Telefon numarasını eksik girilmiştir.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(textBoxIdentityNumber.Text.Length != 11)
                {
                    MessageBox.Show("TC Kimlik Numarası eksik girilmiştir.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Visible = false;
            btnUpdate.Visible = true;
            if(e.RowIndex >= 0)
            {
                var id = (int)dataGridCustomer.Rows[e.RowIndex].Cells[0].Value; 
                secilenCustomer = custManager.GetCustomer(id);
                textBoxFirstName.Text = secilenCustomer.CustomerFirstName;
                textBoxLastName.Text = secilenCustomer.CustomerLastName;
                textBoxPhone.Text = secilenCustomer.CustomerPhone;
                textBoxIdentityNumber.Text = secilenCustomer.CustomerIdentityNumber;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var customerList = custManager.CustomerList();
            bool isCustomerExist = customerList.Any(s => s.CustomerId != secilenCustomer.CustomerId && s.CustomerIdentityNumber == textBoxIdentityNumber.Text);

            if (!isCustomerExist
                &&
                textBoxFirstName.Text != ""
                &&
                textBoxLastName.Text != ""
                &&
                textBoxPhone.Text.Length == 11
                &&
                textBoxIdentityNumber.Text.Length == 11)
            {
                secilenCustomer.CustomerIdentityNumber = textBoxIdentityNumber.Text;
                secilenCustomer.CustomerFirstName = textBoxFirstName.Text;
                secilenCustomer.CustomerLastName = textBoxLastName.Text;
                secilenCustomer.CustomerPhone = textBoxPhone.Text;
                custManager.UpdateCustomer(secilenCustomer);
                MessageBox.Show("Kullanıcı başarıyla güncellenmiştir.", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshForm();

            }
            else
            {
                if (isCustomerExist)
                {
                    MessageBox.Show("Bu TC Kimlik Numarasına sahip bir kişi sistemde kayıtlıdır.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxFirstName.Text == "" || textBoxLastName.Text == "")
                {
                    MessageBox.Show("İsim ve soyisim alanları boş bırakılamaz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxPhone.Text.Length != 11)
                {
                    MessageBox.Show("Telefon numarasını eksik girilmiştir.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (textBoxIdentityNumber.Text.Length != 11)
                {
                    MessageBox.Show("TC Kimlik Numarası eksik girilmiştir.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
