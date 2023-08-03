using E_Czane.Business.Manager;
using E_Czane.Data.Models.DataGridModels;
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
    public partial class PurchaseHistory : Form
    {
        FormsTransactions<PurchaseHistoryDatagridModel> transactions;
        OrderManager orderManager;
        List<CartDatagridModel> cartList;
        Label labelMedName;
        Label labelQuantity;
        Label labelPrice;



        Label labelHeaderMiktar;
        Label labelHeaderFiyat;
        Label labelHeaderIlacadi;
        Label labelToplamFiyat;


        public PurchaseHistory(int adminId)
        {
            InitializeComponent();
            transactions = new FormsTransactions<PurchaseHistoryDatagridModel>();
            orderManager = new OrderManager();
            cartList = new List<CartDatagridModel>();
           
        }

        private void RefreshForm()
        {
            transactions.ShowTable(datagridPurchaseHist, orderManager.GetPurchaseHistory(), orderManager.PurchaseHistoryColumnNames());
            cartList = null;
            this.panelCart.Controls.Clear();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void PurchaseHistory_Load(object sender, EventArgs e)
        {
            transactions.ShowTable(datagridPurchaseHist, orderManager.GetPurchaseHistory(), orderManager.PurchaseHistoryColumnNames());
            cartList = new List<CartDatagridModel>();
        }

        private void datagridPurchaseHist_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            RefreshForm();
            int secilenRowId = (int)datagridPurchaseHist.Rows[e.RowIndex].Cells[0].Value;
            var cartManager = new CartManager();
            cartList = cartManager.GetCartItems(secilenRowId);
            int top = 70;
            var orderSingle = orderManager.GetOrderSingle(secilenRowId);
            
            labelAdminUsername.Text = orderSingle.AdminUsername;
            labelCustomerIdentity.Text = orderSingle.CustomerIdentityNumber;
            labelCustomerFullName.Text = $"{orderSingle.CustomerFirstName} {orderSingle.CustomerLastName}";


            Label labelHeaderMiktar = new Label();
            Label labelHeaderFiyat = new Label();
            Label labelHeaderIlacadi = new Label();
            Label labelToplamFiyat = new Label();

            labelHeaderIlacadi.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            labelHeaderIlacadi.Location = new System.Drawing.Point(22, 16);
            labelHeaderIlacadi.Name = "labelMedName";
            labelHeaderIlacadi.Size = new System.Drawing.Size(300, 30);
            labelHeaderIlacadi.TabIndex = 4;
            labelHeaderIlacadi.Text = $"İlaç Adı";
            labelHeaderIlacadi.ForeColor = Color.FromArgb(255, 255, 255);

            labelHeaderMiktar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            labelHeaderMiktar.Location = new System.Drawing.Point(344, 16);
            labelHeaderMiktar.Name = "labelMedName";
            labelHeaderMiktar.Size = new System.Drawing.Size(100, 30);
            labelHeaderMiktar.TabIndex = 4;
            labelHeaderMiktar.Text = $"Miktar";
            labelHeaderMiktar.ForeColor = Color.FromArgb(255, 255, 255);

            labelHeaderFiyat.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            labelHeaderFiyat.Location = new System.Drawing.Point(450, 16);
            labelHeaderFiyat.Name = "labelMedName";
            labelHeaderFiyat.Size = new System.Drawing.Size(100, 30);
            labelHeaderFiyat.TabIndex = 4;
            labelHeaderFiyat.Text = $"Fiyat";
            labelHeaderFiyat.ForeColor = Color.FromArgb(255, 255, 255);

            labelToplamFiyat.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            labelToplamFiyat.Location = new System.Drawing.Point(300, 506);
            labelToplamFiyat.Name = "labelMedName";
            labelToplamFiyat.Size = new System.Drawing.Size(250, 50);
            labelToplamFiyat.TabIndex = 4;
            labelToplamFiyat.Text = $"Toplam : {orderSingle.OrderTotalAmount} TRY ";
            labelToplamFiyat.ForeColor = Color.FromArgb(255, 255, 255);

            this.panelCart.Controls.Add(labelHeaderIlacadi);
            this.panelCart.Controls.Add(labelHeaderFiyat);
            this.panelCart.Controls.Add(labelHeaderMiktar);
            this.panelCart.Controls.Add(labelToplamFiyat);






            for (int i = 0; i < cartList.Count; i++)
            {

                labelMedName = new Label();
                labelQuantity = new Label();
                labelPrice = new Label();

                // ILAC ADI
                labelMedName.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                labelMedName.Location = new System.Drawing.Point(28, top);
                labelMedName.Name = "labelMedName";
                labelMedName.Size = new System.Drawing.Size(300, 16);
                labelMedName.TabIndex = 4;
                labelMedName.Text = $"{cartList[i].MedicineName}";
                labelMedName.ForeColor = Color.FromArgb(255, 255, 255);

                // ILAC BARKOD
                labelQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                labelQuantity.Location = new System.Drawing.Point(368, top);
                labelQuantity.Name = "labelMedName";
                labelQuantity.Size = new System.Drawing.Size(75, 16);
                labelQuantity.TabIndex = 4;
                labelQuantity.Text = $"{cartList[i].CartQuantity}";
                labelQuantity.ForeColor = Color.FromArgb(255, 255, 255);

                // ILAC BARKOD
                labelPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
                labelPrice.Location = new System.Drawing.Point(443, top);
                labelPrice.Name = "labelMedName";
                labelPrice.Size = new System.Drawing.Size(125, 16);
                labelPrice.TabIndex = 4;
                labelPrice.Text = $"{cartList[i].CartAmount} TRY";
                labelPrice.ForeColor = Color.FromArgb(255, 255, 255);

                this.panelCart.Controls.Add(labelMedName);
                this.panelCart.Controls.Add(labelQuantity);
                this.panelCart.Controls.Add(labelPrice);

                top += 30;

            }

        }
    }
}
