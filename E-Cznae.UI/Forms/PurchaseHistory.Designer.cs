namespace E_Cznae.UI.Forms
{
    partial class PurchaseHistory
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PurchaseHistory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.datagridPurchaseHist = new System.Windows.Forms.DataGridView();
            this.panelCart = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCustomerIdentity = new System.Windows.Forms.Label();
            this.labelCustomerFullName = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelAdminUsername = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridPurchaseHist)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.datagridPurchaseHist);
            this.panel1.Location = new System.Drawing.Point(59, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 646);
            this.panel1.TabIndex = 0;
            // 
            // datagridPurchaseHist
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.datagridPurchaseHist.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.datagridPurchaseHist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridPurchaseHist.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.datagridPurchaseHist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridPurchaseHist.DefaultCellStyle = dataGridViewCellStyle3;
            this.datagridPurchaseHist.Location = new System.Drawing.Point(20, 17);
            this.datagridPurchaseHist.Name = "datagridPurchaseHist";
            this.datagridPurchaseHist.Size = new System.Drawing.Size(440, 608);
            this.datagridPurchaseHist.TabIndex = 0;
            this.datagridPurchaseHist.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridPurchaseHist_CellDoubleClick);
            // 
            // panelCart
            // 
            this.panelCart.BackColor = System.Drawing.Color.Maroon;
            this.panelCart.Location = new System.Drawing.Point(583, 150);
            this.panelCart.Name = "panelCart";
            this.panelCart.Size = new System.Drawing.Size(556, 556);
            this.panelCart.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.labelCustomerIdentity);
            this.panel2.Controls.Add(this.labelCustomerFullName);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.labelAdminUsername);
            this.panel2.Location = new System.Drawing.Point(583, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(556, 86);
            this.panel2.TabIndex = 5;
            // 
            // labelCustomerIdentity
            // 
            this.labelCustomerIdentity.AutoSize = true;
            this.labelCustomerIdentity.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCustomerIdentity.ForeColor = System.Drawing.Color.Maroon;
            this.labelCustomerIdentity.Location = new System.Drawing.Point(21, 16);
            this.labelCustomerIdentity.Name = "labelCustomerIdentity";
            this.labelCustomerIdentity.Size = new System.Drawing.Size(88, 22);
            this.labelCustomerIdentity.TabIndex = 5;
            this.labelCustomerIdentity.Text = "TC Kimlik";
            // 
            // labelCustomerFullName
            // 
            this.labelCustomerFullName.AutoSize = true;
            this.labelCustomerFullName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCustomerFullName.ForeColor = System.Drawing.Color.Maroon;
            this.labelCustomerFullName.Location = new System.Drawing.Point(21, 46);
            this.labelCustomerFullName.Name = "labelCustomerFullName";
            this.labelCustomerFullName.Size = new System.Drawing.Size(88, 22);
            this.labelCustomerFullName.TabIndex = 4;
            this.labelCustomerFullName.Text = "Full name";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(415, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // labelAdminUsername
            // 
            this.labelAdminUsername.AutoSize = true;
            this.labelAdminUsername.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdminUsername.ForeColor = System.Drawing.Color.Maroon;
            this.labelAdminUsername.Location = new System.Drawing.Point(450, 30);
            this.labelAdminUsername.Name = "labelAdminUsername";
            this.labelAdminUsername.Size = new System.Drawing.Size(88, 22);
            this.labelAdminUsername.TabIndex = 2;
            this.labelAdminUsername.Text = "username";
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
            this.btnRefresh.TabIndex = 26;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // PurchaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1163, 740);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.panelCart);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PurchaseHistory";
            this.Text = "Satış Geçmişi";
            this.Load += new System.EventHandler(this.PurchaseHistory_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridPurchaseHist)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCart;
        private System.Windows.Forms.DataGridView datagridPurchaseHist;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelAdminUsername;
        private System.Windows.Forms.Label labelCustomerIdentity;
        private System.Windows.Forms.Label labelCustomerFullName;
    }
}