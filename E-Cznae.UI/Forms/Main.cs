using E_Czane.Data.Models.ViewModels;
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
    public partial class Main : Form
    {
        private Form activateForm;
        private AdminViewModel admin;
        public Main(AdminViewModel admin)
        {
            InitializeComponent();
            this.admin = admin;
        }

        private void OpenNewForm(Form childForm, object btnSender)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }
            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelFormName.Text = childForm.Text;   
        }

        private void Main_Load(object sender, EventArgs e)
        {
            labelAdminUsername.Text = admin.AdminUsername;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            OpenNewForm(new Order(admin.AdminId), sender);
        }

        private void btnPurchaseHistory_Click(object sender, EventArgs e)
        {
            OpenNewForm(new PurchaseHistory(admin.AdminId), sender);
        }

        private void btnMedicineList_Click(object sender, EventArgs e)
        {
            OpenNewForm(new MedicineList(admin.AdminId), sender);
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            OpenNewForm(new AddMedicine(admin.AdminId), sender);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenNewForm(new Customers(admin.AdminId), sender);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (admin.AdminRoleId == 1)
            {
                OpenNewForm(new Admin(admin.AdminId), sender);
            }
            else
            {
                MessageBox.Show("Admin işlemleri için yetkiniz yoktur", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
