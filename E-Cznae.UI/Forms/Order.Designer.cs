namespace E_Cznae.UI.Forms
{
    partial class Order
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.panelCart = new System.Windows.Forms.Panel();
			this.btnReadIdentityNumber = new System.Windows.Forms.Button();
			this.textBoxIdentityNumber = new System.Windows.Forms.TextBox();
			this.labelTCkimlik = new System.Windows.Forms.Label();
			this.btnCreateOrder = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.labelFullName = new System.Windows.Forms.Label();
			this.labelIdentityNumber = new System.Windows.Forms.Label();
			this.datagridOrderList = new System.Windows.Forms.DataGridView();
			this.textBoxSearchBar = new System.Windows.Forms.TextBox();
			this.labelSearchBar = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.comboboxMedCategory = new System.Windows.Forms.ComboBox();
			this.btnFilter = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panelCart.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagridOrderList)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Maroon;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(56, 40);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(590, 624);
			this.dataGridView1.TabIndex = 0;
			// 
			// panelCart
			// 
			this.panelCart.BackColor = System.Drawing.Color.Maroon;
			this.panelCart.Controls.Add(this.btnReadIdentityNumber);
			this.panelCart.Controls.Add(this.textBoxIdentityNumber);
			this.panelCart.Controls.Add(this.labelTCkimlik);
			this.panelCart.Location = new System.Drawing.Point(682, 155);
			this.panelCart.Name = "panelCart";
			this.panelCart.Size = new System.Drawing.Size(432, 509);
			this.panelCart.TabIndex = 1;
			// 
			// btnReadIdentityNumber
			// 
			this.btnReadIdentityNumber.BackColor = System.Drawing.Color.White;
			this.btnReadIdentityNumber.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnReadIdentityNumber.FlatAppearance.BorderSize = 0;
			this.btnReadIdentityNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnReadIdentityNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnReadIdentityNumber.ForeColor = System.Drawing.Color.Maroon;
			this.btnReadIdentityNumber.Location = new System.Drawing.Point(351, 112);
			this.btnReadIdentityNumber.Name = "btnReadIdentityNumber";
			this.btnReadIdentityNumber.Size = new System.Drawing.Size(61, 33);
			this.btnReadIdentityNumber.TabIndex = 22;
			this.btnReadIdentityNumber.Text = "Sorgula";
			this.btnReadIdentityNumber.UseVisualStyleBackColor = false;
			this.btnReadIdentityNumber.Click += new System.EventHandler(this.btnReadIdentityNumber_Click);
			// 
			// textBoxIdentityNumber
			// 
			this.textBoxIdentityNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBoxIdentityNumber.Location = new System.Drawing.Point(141, 116);
			this.textBoxIdentityNumber.Name = "textBoxIdentityNumber";
			this.textBoxIdentityNumber.Size = new System.Drawing.Size(189, 24);
			this.textBoxIdentityNumber.TabIndex = 2;
			// 
			// labelTCkimlik
			// 
			this.labelTCkimlik.AutoSize = true;
			this.labelTCkimlik.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelTCkimlik.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.labelTCkimlik.Location = new System.Drawing.Point(28, 119);
			this.labelTCkimlik.Name = "labelTCkimlik";
			this.labelTCkimlik.Size = new System.Drawing.Size(96, 19);
			this.labelTCkimlik.TabIndex = 4;
			this.labelTCkimlik.Text = "TC Kimlik No";
			// 
			// btnCreateOrder
			// 
			this.btnCreateOrder.BackColor = System.Drawing.Color.Maroon;
			this.btnCreateOrder.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnCreateOrder.FlatAppearance.BorderSize = 0;
			this.btnCreateOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCreateOrder.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnCreateOrder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.btnCreateOrder.Location = new System.Drawing.Point(978, 670);
			this.btnCreateOrder.Name = "btnCreateOrder";
			this.btnCreateOrder.Size = new System.Drawing.Size(136, 48);
			this.btnCreateOrder.TabIndex = 5;
			this.btnCreateOrder.Text = "Sipariş Oluştur";
			this.btnCreateOrder.UseVisualStyleBackColor = false;
			this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
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
			this.btnRefresh.TabIndex = 21;
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Maroon;
			this.panel2.Controls.Add(this.labelFullName);
			this.panel2.Controls.Add(this.labelIdentityNumber);
			this.panel2.Location = new System.Drawing.Point(682, 40);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(432, 99);
			this.panel2.TabIndex = 2;
			// 
			// labelFullName
			// 
			this.labelFullName.AutoSize = true;
			this.labelFullName.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelFullName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.labelFullName.Location = new System.Drawing.Point(17, 49);
			this.labelFullName.Name = "labelFullName";
			this.labelFullName.Size = new System.Drawing.Size(132, 31);
			this.labelFullName.TabIndex = 1;
			this.labelFullName.Text = "Full name";
			// 
			// labelIdentityNumber
			// 
			this.labelIdentityNumber.AutoSize = true;
			this.labelIdentityNumber.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelIdentityNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.labelIdentityNumber.Location = new System.Drawing.Point(18, 13);
			this.labelIdentityNumber.Name = "labelIdentityNumber";
			this.labelIdentityNumber.Size = new System.Drawing.Size(84, 22);
			this.labelIdentityNumber.TabIndex = 0;
			this.labelIdentityNumber.Text = "Tc kimlik";
			// 
			// datagridOrderList
			// 
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.datagridOrderList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.datagridOrderList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.datagridOrderList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.datagridOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.datagridOrderList.DefaultCellStyle = dataGridViewCellStyle3;
			this.datagridOrderList.Location = new System.Drawing.Point(72, 89);
			this.datagridOrderList.Name = "datagridOrderList";
			this.datagridOrderList.Size = new System.Drawing.Size(558, 561);
			this.datagridOrderList.TabIndex = 22;
			this.datagridOrderList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridOrderList_CellDoubleClick);
			// 
			// textBoxSearchBar
			// 
			this.textBoxSearchBar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBoxSearchBar.Location = new System.Drawing.Point(139, 53);
			this.textBoxSearchBar.Name = "textBoxSearchBar";
			this.textBoxSearchBar.Size = new System.Drawing.Size(155, 24);
			this.textBoxSearchBar.TabIndex = 23;
			this.textBoxSearchBar.TextChanged += new System.EventHandler(this.textBoxSearchBar_TextChanged);
			// 
			// labelSearchBar
			// 
			this.labelSearchBar.AutoSize = true;
			this.labelSearchBar.BackColor = System.Drawing.Color.Maroon;
			this.labelSearchBar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.labelSearchBar.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.labelSearchBar.Location = new System.Drawing.Point(74, 55);
			this.labelSearchBar.Name = "labelSearchBar";
			this.labelSearchBar.Size = new System.Drawing.Size(59, 19);
			this.labelSearchBar.TabIndex = 24;
			this.labelSearchBar.Text = "İlaç Adı";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Maroon;
			this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
			this.label1.Location = new System.Drawing.Point(307, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 19);
			this.label1.TabIndex = 25;
			this.label1.Text = "Kategori";
			// 
			// comboboxMedCategory
			// 
			this.comboboxMedCategory.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.comboboxMedCategory.FormattingEnabled = true;
			this.comboboxMedCategory.Location = new System.Drawing.Point(380, 53);
			this.comboboxMedCategory.Name = "comboboxMedCategory";
			this.comboboxMedCategory.Size = new System.Drawing.Size(162, 24);
			this.comboboxMedCategory.TabIndex = 27;
			// 
			// btnFilter
			// 
			this.btnFilter.BackColor = System.Drawing.Color.White;
			this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFilter.FlatAppearance.BorderSize = 0;
			this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFilter.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnFilter.ForeColor = System.Drawing.Color.Maroon;
			this.btnFilter.Location = new System.Drawing.Point(548, 53);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(82, 24);
			this.btnFilter.TabIndex = 23;
			this.btnFilter.Text = "Filtrele";
			this.btnFilter.UseVisualStyleBackColor = false;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// Order
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(1163, 740);
			this.Controls.Add(this.btnFilter);
			this.Controls.Add(this.comboboxMedCategory);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.labelSearchBar);
			this.Controls.Add(this.textBoxSearchBar);
			this.Controls.Add(this.datagridOrderList);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnCreateOrder);
			this.Controls.Add(this.panelCart);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Order";
			this.Text = "Satış Ekranı";
			this.Load += new System.EventHandler(this.Order_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panelCart.ResumeLayout(false);
			this.panelCart.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.datagridOrderList)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.TextBox textBoxIdentityNumber;
        private System.Windows.Forms.Label labelTCkimlik;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnReadIdentityNumber;
        private System.Windows.Forms.DataGridView datagridOrderList;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.Label labelIdentityNumber;
		private System.Windows.Forms.TextBox textBoxSearchBar;
		private System.Windows.Forms.Label labelSearchBar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboboxMedCategory;
		private System.Windows.Forms.Button btnFilter;
	}
}