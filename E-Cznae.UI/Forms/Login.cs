using E_Czane.Business.Manager;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var admanager = new AdminManager();
            var admin = admanager.isAdminExist(textBoxUsername.Text, textBoxPassword.Text);
            if (admin != null)
            {
                // Main form sayfasını oluşturur ve başlatır.
                var mainPageForm = new Main(admin);
                mainPageForm.Show();
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
			    btnLogin.Enabled = false;
			}
            // Yanlış kullanıcı adı ve şifre için hata mesajı gösterir.
            else
            {
                MessageBox.Show("Admin Kullanici adi veya sifrenizi kontrol ediniz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
