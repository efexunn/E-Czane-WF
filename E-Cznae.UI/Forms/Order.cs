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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace E_Cznae.UI.Forms
{
    public partial class Order : Form
    {
        FormsTransactions<OrderDatagridModel> transactions;
        MedicineManager medManager;
        CustomerManager custManager;
        MedicineDbModel secilenMedicine;
        CustomersDbModel customer;
        List<CartDbModel> cart;
        static int top = 25;
        static int index = 0;
        static decimal totalPrice = 0;
        static int adminId;
        OrderManager orderManager;
        Label labelMedName;
        Label labelToplamFiyat;
        Label labelMedPrice;
        public Order(int id)
        {
            InitializeComponent();
            transactions = new FormsTransactions<OrderDatagridModel>();
            medManager = new MedicineManager();
            secilenMedicine = new MedicineDbModel();
            customer = new CustomersDbModel();
            custManager = new CustomerManager();
            orderManager = new OrderManager();
            cart = new List<CartDbModel>();
            adminId = id;
            
        }

        private void RefreshForm(bool isActive = false, CustomersDbModel person = null)
        {
            transactions.ShowTable(datagridOrderList, medManager.OrderList(), medManager.OrderColumnNames());
            if (isActive)
            {
                labelIdentityNumber.Visible = true;
                labelFullName.Visible = true;
                btnCreateOrder.Visible = true;
                textBoxIdentityNumber.Visible = false;
                labelTCkimlik.Visible = false;
                btnReadIdentityNumber.Visible = false;
                customer = person;
                labelIdentityNumber.Text = $"{person.CustomerIdentityNumber}";
                labelFullName.Text = $"{person.CustomerFirstName} {person.CustomerLastName}";
                cart = new List<CartDbModel>();
                btnCreateOrder.Enabled = false;
            }
            else
            {
                labelIdentityNumber.Visible = false;
                labelFullName.Visible = false;
                btnCreateOrder.Visible = false;
                textBoxIdentityNumber.Visible = true;
                labelTCkimlik.Visible = true;
                btnReadIdentityNumber.Visible = true;
                customer = person;
                cart = null;
                top = 25;
                index = 0;
                totalPrice = 0;
                this.panelCart.Controls.Remove(labelMedName);
                this.panelCart.Controls.Remove(labelToplamFiyat);
                this.panelCart.Controls.Remove(labelMedPrice);

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btnReadIdentityNumber_Click(object sender, EventArgs e)
        {
            if (textBoxIdentityNumber.Text.Length == 11)
            {
                var newCustomer = custManager.isCustomerExist(textBoxIdentityNumber.Text);
                if (newCustomer != null)
                    RefreshForm(true, newCustomer);
                else
                    MessageBox.Show("Girdiğiniz TC Kimlik numarasını kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Girdiğiniz TC Kimlik numarasını kontrol ediniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void datagridOrderList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customer == null)
            {
                MessageBox.Show("Lütfen bir müşteri seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (e.RowIndex >= 0)
                {
                    var secilenRowId = (int)datagridOrderList.Rows[e.RowIndex].Cells[0].Value;
                    var newCartItem = new CartDbModel();
                    newCartItem.CartQuantity = 1;
                    newCartItem.CartMedicineId = secilenRowId;
                    newCartItem.isActive = true;
                    
                    cart.Add(newCartItem);

                    var medicine = medManager.GetMedicine(cart[index].CartMedicineId);

                    cart[index].CartAmount = medicine.MedicinePrice;

                    labelMedName = new Label();
                    labelToplamFiyat = new Label();
                    labelMedPrice = new Label();

                    this.panelCart.Controls.Add(labelMedName);
                    this.panelCart.Controls.Add(labelToplamFiyat);
                    this.panelCart.Controls.Add(labelMedPrice);


                    // ILAC ADI
                    labelMedName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    labelMedName.Location = new System.Drawing.Point(15, top);
                    labelMedName.Name = "labelMedName";
                    labelMedName.Size = new System.Drawing.Size(300, 16);
                    labelMedName.TabIndex = 4;
                    labelMedName.Text = medicine.MedicineName;

                    // FIYAT
                    labelMedPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                    labelMedPrice.Location = new System.Drawing.Point(350, top);
                    labelMedPrice.Name = "labelMedName";
                    labelMedPrice.Size = new System.Drawing.Size(100, 16);
                    labelMedPrice.TabIndex = 4;
                    labelMedPrice.Text = $"{medicine.MedicinePrice.ToString()} ₺";

                    totalPrice += medicine.MedicinePrice;
                    top += 35;
                    index++;
                    btnCreateOrder.Enabled = true;
                }
            }
        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            var newOrder = new OrderDbModel();
            newOrder.OrderCustomerId = customer.CustomerId;
            newOrder.OrderAdminId = adminId;
            newOrder.isActive = true;
            newOrder.OrderTotalAmount = totalPrice;

            var latestOrderId = orderManager.CreateOrder(newOrder);

            for(int i = 0;i < cart.Count;i++)
            {
                cart[i].CartOrderId = latestOrderId;
                var cartManager = new CartManager();
                cartManager.AddItemCart(cart[i]);
            }

            MessageBox.Show("Sipariş Başarıyla Oluşturuldu.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            RefreshForm();
        }
    }
}
