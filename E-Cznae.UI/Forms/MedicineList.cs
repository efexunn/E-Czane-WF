using System;
using E_Czane.Business.Manager;
using E_Czane.Data.Models.DataGridModels;
using E_Czane.Data.Models.DbModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using E_Cznae.UI.FormTransactions;

namespace E_Cznae.UI.Forms
{
    public partial class MedicineList : Form
    {
        FormsTransactions<MedicineListDataGridModel> transactions;
        MedicineManager medManager;
        MedicineDbModel secilenMedicine;
        static int secilenRowId;
        public MedicineList(int adminId)
        {
            InitializeComponent();
            transactions = new FormsTransactions<MedicineListDataGridModel>();
            medManager = new MedicineManager();
            secilenMedicine = new MedicineDbModel();
        }
        private void RefreshForm()
        {
            textboxMedName.Text = string.Empty;
            comboboxMedCategory.SelectedItem = null;
            comboboxMedProducer.SelectedItem = null;
            numupdownMedPrice.Value = 0;
            numupdownMedStock.Value = 0;
            transactions.ShowTable(dataGridViewMedicineList, medManager.MedicineList(), medManager.MedicineListColumnNames());
            btnDelete.Visible = false;
            btnUpdate.Visible = false;
            btnAddMedicine.Visible = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshForm();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            var medList = medManager.MedicineList();
            var isBarcodeExist = medList.Any(s => s.MedicineBarcode == secilenMedicine.MedicineBarcode);
            if (textboxMedName.Text != string.Empty
                &&
                textBoxBarcode.Text.Length == 13
                &&
                numupdownMedPrice.Value > 0
                &&
                numupdownMedStock.Value > 0
                &&
                (int)comboboxMedCategory.SelectedValue != 0
                &&
                (int)comboboxMedProducer.SelectedValue != 0
                &&
                !isBarcodeExist)
            {
                var newMedicine = new MedicineDbModel();
                newMedicine.MedicineName = textboxMedName.Text;
                newMedicine.MedicineCategoryId = (int)comboboxMedCategory.SelectedValue;
                newMedicine.MedicineProducerId = (int)comboboxMedProducer.SelectedValue;
                newMedicine.MedicinePrice = numupdownMedPrice.Value;
                newMedicine.MedicineStock = (int)numupdownMedStock.Value;
                newMedicine.MedicineBarcode = textBoxBarcode.Text;
                newMedicine.isActive = true;
                medManager.AddNewMedicine(newMedicine);
                MessageBox.Show("Tebrikler! Yeni ilaç sisteme başarıyla kayıt edilmiştir", "Kayıt Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshForm();
            }
            // İLAÇ EKLEME KISMINDA HATA MESAJLARI
            else
            {
                // BOŞ TEXT BOX HATASI
                if (textboxMedName.Text == string.Empty)
                    MessageBox.Show("Lütfen boş alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // BARKODUN YANLIŞ GİRİLMESİ HATASI 
                else if (textBoxBarcode.Text.Length != 13)
                    MessageBox.Show("Girilen Barkod numarası 13 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // MİKTAR DEĞERLERİNİN 0'DAN KÜCÜK OLDUĞU DURUM HATASI
                else if
                (numupdownMedPrice.Value <= 0
                ||
                numupdownMedStock.Value <= 0)
                    MessageBox.Show("Miktar değerleri sıfırdan büyük olmalıdır..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // KATEGORI SECILMEME HATASI
                else if ((int?)comboboxMedCategory.SelectedValue == null)
                    MessageBox.Show("Lütfen bir ilaç kategorisi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // ÜRETİCİ FİRMA SEÇİLMEME HATASI
                else if ((int?)comboboxMedProducer.SelectedValue == null)
                    MessageBox.Show("Lütfen bir üretici firma seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // AYNI BARKODDAN URUN BULUNMA HATASI
                else if (isBarcodeExist)
                    MessageBox.Show("Girdiğiniz barkod numarasında bir ilaç sistemde bulunmaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MedicineList_Load(object sender, EventArgs e)
        {
            var categoryList = CategoryManager.GetCategoryList();

            var producerList = ProducerManager.GetProducerList();

            comboboxMedCategory.DataSource = categoryList;
            comboboxMedCategory.ValueMember = "CategoryId";
            comboboxMedCategory.DisplayMember = "CategoryName";

            comboboxMedProducer.DataSource = producerList;
            comboboxMedProducer.ValueMember = "ProducerId";
            comboboxMedProducer.DisplayMember = "ProducerName";

            RefreshForm();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var medList = medManager.MedicineList();
            var isBarcodeExist = medList.Any(s => s.MedicineId != secilenMedicine.MedicineId && s.MedicineBarcode == secilenMedicine.MedicineBarcode);
            if (textboxMedName.Text != string.Empty
                &&
                textBoxBarcode.Text.Length == 13
                &&
                numupdownMedPrice.Value > 0
                &&
                numupdownMedStock.Value > 0
                &&
                (int)comboboxMedCategory.SelectedValue != 0
                &&
                (int)comboboxMedProducer.SelectedValue != 0
                &&
                !isBarcodeExist)
            {
                var medToBeUpdated = medManager.GetMedicine(secilenRowId);
                medToBeUpdated.MedicineName = textboxMedName.Text;
                medToBeUpdated.MedicineCategoryId = (int)comboboxMedCategory.SelectedValue;
                medToBeUpdated.MedicineProducerId = (int)comboboxMedProducer.SelectedValue;
                medToBeUpdated.MedicinePrice = numupdownMedPrice.Value;
                medToBeUpdated.MedicineStock = (int)numupdownMedStock.Value;
                medToBeUpdated.MedicineBarcode = textBoxBarcode.Text;
                medManager.UpdateMedicine(medToBeUpdated);
                MessageBox.Show("Tebrikler! İlaç başarıyla kayıt güncellenmiştir.", "Kayıt Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshForm();
            }
            // İLAÇ EKLEME KISMINDA HATA MESAJLARI
            else
            {
                // BOŞ TEXT BOX HATASI
                if (textboxMedName.Text == string.Empty)
                    MessageBox.Show("Lütfen boş alanları doldurunuz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // BARKODUN YANLIŞ GİRİLMESİ HATASI 
                else if (textBoxBarcode.Text.Length != 13)
                    MessageBox.Show("Girilen Barkod numarası 13 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // MİKTAR DEĞERLERİNİN 0'DAN KÜCÜK OLDUĞU DURUM HATASI
                else if
                (numupdownMedPrice.Value <= 0
                ||
                numupdownMedStock.Value <= 0)
                    MessageBox.Show("Miktar değerleri sıfırdan büyük olmalıdır..", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // KATEGORI SECILMEME HATASI
                else if ((int?)comboboxMedCategory.SelectedValue == null)
                    MessageBox.Show("Lütfen bir ilaç kategorisi seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // ÜRETİCİ FİRMA SEÇİLMEME HATASI
                else if ((int?)comboboxMedProducer.SelectedValue == null)
                    MessageBox.Show("Lütfen bir üretici firma seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // AYNI BARKODDAN URUN BULUNMA HATASI
                else if (isBarcodeExist)
                    MessageBox.Show("Girdiğiniz barkod numarasında bir ilaç sistemde bulunmaktadır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bu ürünü silmek istediğinize emin misiniz ?", "Dikkat!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                medManager.DeleteMedicine(secilenRowId);
                MessageBox.Show("Ürün başarıyla silinmiştir.", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            RefreshForm();
        }

        private void dataGridViewMedicineList_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            btnAddMedicine.Visible = false;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;
            if (e.RowIndex >= 0)
            {
                secilenRowId = (int)dataGridViewMedicineList.Rows[e.RowIndex].Cells[0].Value;
                secilenMedicine = medManager.GetMedicine(secilenRowId);
                textboxMedName.Text = secilenMedicine.MedicineName;
                textBoxBarcode.Text = secilenMedicine.MedicineBarcode;
                numupdownMedPrice.Value = secilenMedicine.MedicinePrice;
                numupdownMedStock.Value = secilenMedicine.MedicineStock;
                comboboxMedCategory.SelectedValue = secilenMedicine.MedicineCategoryId;
                comboboxMedProducer.SelectedValue = secilenMedicine.MedicineProducerId;

            }
        }
    }
}
