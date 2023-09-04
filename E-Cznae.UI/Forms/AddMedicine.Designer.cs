namespace E_Cznae.UI.Forms
{
    partial class AddMedicine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMedicine));
			this.panel1 = new System.Windows.Forms.Panel();
			this.datagridStock = new System.Windows.Forms.DataGridView();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnIncrease = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnDecrease = new System.Windows.Forms.Button();
			this.numupdownQuantity = new System.Windows.Forms.NumericUpDown();
			this.panelInformation = new System.Windows.Forms.Panel();
			this.labelMedStock = new System.Windows.Forms.Label();
			this.labelMedPrice = new System.Windows.Forms.Label();
			this.labelMedBarcode = new System.Windows.Forms.Label();
			this.labelMedName = new System.Windows.Forms.Label();
			this.labelSearchBarcode = new System.Windows.Forms.Label();
			this.textBoxBarcode = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagridStock)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numupdownQuantity)).BeginInit();
			this.panelInformation.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Maroon;
			this.panel1.Controls.Add(this.labelSearchBarcode);
			this.panel1.Controls.Add(this.textBoxBarcode);
			this.panel1.Controls.Add(this.datagridStock);
			this.panel1.Location = new System.Drawing.Point(36, 112);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(530, 580);
			this.panel1.TabIndex = 23;
			// 
			// datagridStock
			// 
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.datagridStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			this.datagridStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagridStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.datagridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.datagridStock.DefaultCellStyle = dataGridViewCellStyle6;
			this.datagridStock.Location = new System.Drawing.Point(20, 42);
			this.datagridStock.Name = "datagridStock";
			this.datagridStock.Size = new System.Drawing.Size(490, 518);
			this.datagridStock.TabIndex = 0;
			this.datagridStock.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridStock_CellDoubleClick);
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackColor = System.Drawing.Color.Maroon;
			this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnRefresh.FlatAppearance.BorderSize = 0;
			this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnRefresh.ForeColor = System.Drawing.Color.White;
			this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
			this.btnRefresh.Location = new System.Drawing.Point(12, 12);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(31, 33);
			this.btnRefresh.TabIndex = 25;
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Maroon;
			this.panel2.Controls.Add(this.btnIncrease);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.btnDecrease);
			this.panel2.Controls.Add(this.numupdownQuantity);
			this.panel2.Location = new System.Drawing.Point(658, 283);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(433, 283);
			this.panel2.TabIndex = 26;
			// 
			// btnIncrease
			// 
			this.btnIncrease.BackColor = System.Drawing.Color.DarkGreen;
			this.btnIncrease.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnIncrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIncrease.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnIncrease.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnIncrease.Location = new System.Drawing.Point(247, 179);
			this.btnIncrease.Name = "btnIncrease";
			this.btnIncrease.Size = new System.Drawing.Size(118, 51);
			this.btnIncrease.TabIndex = 4;
			this.btnIncrease.Text = "Arttır";
			this.btnIncrease.UseVisualStyleBackColor = false;
			this.btnIncrease.Click += new System.EventHandler(this.btnIncrease_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label1.Location = new System.Drawing.Point(66, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(83, 28);
			this.label1.TabIndex = 3;
			this.label1.Text = "Miktar";
			// 
			// btnDecrease
			// 
			this.btnDecrease.BackColor = System.Drawing.Color.Red;
			this.btnDecrease.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDecrease.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDecrease.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDecrease.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnDecrease.Location = new System.Drawing.Point(71, 179);
			this.btnDecrease.Name = "btnDecrease";
			this.btnDecrease.Size = new System.Drawing.Size(118, 51);
			this.btnDecrease.TabIndex = 1;
			this.btnDecrease.Text = "Azalt";
			this.btnDecrease.UseVisualStyleBackColor = false;
			this.btnDecrease.Click += new System.EventHandler(this.btnDecrease_Click);
			// 
			// numupdownQuantity
			// 
			this.numupdownQuantity.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.numupdownQuantity.Location = new System.Drawing.Point(71, 71);
			this.numupdownQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numupdownQuantity.Name = "numupdownQuantity";
			this.numupdownQuantity.Size = new System.Drawing.Size(294, 48);
			this.numupdownQuantity.TabIndex = 0;
			// 
			// panelInformation
			// 
			this.panelInformation.BackColor = System.Drawing.Color.Maroon;
			this.panelInformation.Controls.Add(this.labelMedStock);
			this.panelInformation.Controls.Add(this.labelMedPrice);
			this.panelInformation.Controls.Add(this.labelMedBarcode);
			this.panelInformation.Controls.Add(this.labelMedName);
			this.panelInformation.Location = new System.Drawing.Point(658, 110);
			this.panelInformation.Name = "panelInformation";
			this.panelInformation.Size = new System.Drawing.Size(433, 146);
			this.panelInformation.TabIndex = 27;
			// 
			// labelMedStock
			// 
			this.labelMedStock.AutoSize = true;
			this.labelMedStock.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelMedStock.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.labelMedStock.Location = new System.Drawing.Point(26, 105);
			this.labelMedStock.Name = "labelMedStock";
			this.labelMedStock.Size = new System.Drawing.Size(80, 19);
			this.labelMedStock.TabIndex = 3;
			this.labelMedStock.Text = "Stok Sayısı";
			// 
			// labelMedPrice
			// 
			this.labelMedPrice.AutoSize = true;
			this.labelMedPrice.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelMedPrice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.labelMedPrice.Location = new System.Drawing.Point(26, 80);
			this.labelMedPrice.Name = "labelMedPrice";
			this.labelMedPrice.Size = new System.Drawing.Size(40, 19);
			this.labelMedPrice.TabIndex = 2;
			this.labelMedPrice.Text = "Fiyat";
			// 
			// labelMedBarcode
			// 
			this.labelMedBarcode.AutoSize = true;
			this.labelMedBarcode.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelMedBarcode.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.labelMedBarcode.Location = new System.Drawing.Point(26, 55);
			this.labelMedBarcode.Name = "labelMedBarcode";
			this.labelMedBarcode.Size = new System.Drawing.Size(58, 19);
			this.labelMedBarcode.TabIndex = 1;
			this.labelMedBarcode.Text = "Barkod";
			// 
			// labelMedName
			// 
			this.labelMedName.AutoSize = true;
			this.labelMedName.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelMedName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.labelMedName.Location = new System.Drawing.Point(26, 15);
			this.labelMedName.Name = "labelMedName";
			this.labelMedName.Size = new System.Drawing.Size(81, 26);
			this.labelMedName.TabIndex = 0;
			this.labelMedName.Text = "İlaç adı";
			// 
			// labelSearchBarcode
			// 
			this.labelSearchBarcode.AutoSize = true;
			this.labelSearchBarcode.BackColor = System.Drawing.Color.Maroon;
			this.labelSearchBarcode.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelSearchBarcode.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.labelSearchBarcode.Location = new System.Drawing.Point(21, 14);
			this.labelSearchBarcode.Name = "labelSearchBarcode";
			this.labelSearchBarcode.Size = new System.Drawing.Size(58, 19);
			this.labelSearchBarcode.TabIndex = 26;
			this.labelSearchBarcode.Text = "Barkod";
			// 
			// textBoxBarcode
			// 
			this.textBoxBarcode.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBoxBarcode.Location = new System.Drawing.Point(86, 12);
			this.textBoxBarcode.Name = "textBoxBarcode";
			this.textBoxBarcode.Size = new System.Drawing.Size(189, 24);
			this.textBoxBarcode.TabIndex = 25;
			this.textBoxBarcode.TextChanged += new System.EventHandler(this.textBoxBarcode_TextChanged);
			// 
			// AddMedicine
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1163, 740);
			this.Controls.Add(this.panelInformation);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddMedicine";
			this.Text = "Yeni Ürün Ekleme";
			this.Load += new System.EventHandler(this.AddMedicine_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagridStock)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numupdownQuantity)).EndInit();
			this.panelInformation.ResumeLayout(false);
			this.panelInformation.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView datagridStock;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIncrease;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDecrease;
        private System.Windows.Forms.NumericUpDown numupdownQuantity;
        private System.Windows.Forms.Panel panelInformation;
        private System.Windows.Forms.Label labelMedBarcode;
        private System.Windows.Forms.Label labelMedName;
        private System.Windows.Forms.Label labelMedStock;
        private System.Windows.Forms.Label labelMedPrice;
		private System.Windows.Forms.Label labelSearchBarcode;
		private System.Windows.Forms.TextBox textBoxBarcode;
	}
}