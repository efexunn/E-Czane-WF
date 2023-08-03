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
    public partial class AddMedicine : Form
    {
        private FormsTransactions<AddMedicineDatagridModel> transactions;
        private MedicineManager medManager;
        private MedicineDbModel secilenMedicine;
        public AddMedicine(int adminId)
        {
            InitializeComponent();
            transactions = new FormsTransactions<AddMedicineDatagridModel>();
            medManager = new MedicineManager();
            secilenMedicine = new MedicineDbModel();
        }

        private void RefreshForm()
        {
            numupdownQuantity.Value = 0;
            transactions.ShowTable(datagridStock, medManager.AddMedicineList(), medManager.AddMedicineColumnNames());
            panelInformation.Visible = false;
            labelMedName.Visible = false;
            labelMedPrice.Visible = false;
            labelMedBarcode.Visible = false;
            labelMedStock.Visible = false;
            btnDecrease.Enabled = false;
            btnIncrease.Enabled = false;
        }

        private void AddMedicine_Load(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }
        private void datagridStock_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            panelInformation.Visible = true;
            labelMedName.Visible = true;
            labelMedPrice.Visible = true;
            labelMedBarcode.Visible = true;
            labelMedStock.Visible = true;
            btnDecrease.Enabled = true;
            btnIncrease.Enabled = true;

            if (e.RowIndex >= 0)
            {
                int secileRowId = (int)datagridStock.Rows[e.RowIndex].Cells[0].Value;
                secilenMedicine = medManager.GetMedicine(secileRowId);
                labelMedName.Text = secilenMedicine.MedicineName;
                labelMedBarcode.Text = $"Barkod : {secilenMedicine.MedicineBarcode}";
                labelMedStock.Text = $"Stok Sayısı : {secilenMedicine.MedicineStock}";
                labelMedPrice.Text = $"Fiyat : {secilenMedicine.MedicinePrice}₺";
            }
        }

        private void btnIncrease_Click(object sender, EventArgs e)
        {
            if (secilenMedicine != null && numupdownQuantity.Value > 0)
            {
                secilenMedicine.MedicineStock += (int)numupdownQuantity.Value;
                medManager.UpdateMedicine(secilenMedicine);
                MessageBox.Show($"{numupdownQuantity.Value} adet {secilenMedicine.MedicineName} stoğa eklenmiştir. ", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshForm();
            }
            else
            {
                if (secilenMedicine == null)
                    MessageBox.Show("Lütfen bir ilaç seçiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (numupdownQuantity.Value <= 0)
                    MessageBox.Show("Lütfen geçerli bir miktar (sıfırdan büyük) giriniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (secilenMedicine != null && numupdownQuantity.Value > 0)
            {
                
                if(secilenMedicine.MedicineStock >= (int)numupdownQuantity.Value)
                {
                    secilenMedicine.MedicineStock -= (int)numupdownQuantity.Value;
                    medManager.UpdateMedicine(secilenMedicine);
                    MessageBox.Show($"{numupdownQuantity.Value} adet {secilenMedicine.MedicineName} stoktan eksiltilmiştir. ", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshForm();
                }
                else
                {
                    MessageBox.Show($"Eksiltmek istediğinz miktarda ilaç stoklarda bulunmamaktadır, lütfen geçerli sayıda eksiltme yapınız.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            else
            {
                if (secilenMedicine == null)
                    MessageBox.Show("Lütfen bir ilaç seçiniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (numupdownQuantity.Value <= 0)
                    MessageBox.Show("Lütfen geçerli bir miktar (sıfırdan büyük) giriniz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
