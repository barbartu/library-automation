using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class frmgiriş : Form
    {
        public frmgiriş()
        {
            InitializeComponent();
        }





        private void frmgiriş_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtisim.Text.Trim();
            string sifre = txtşifre.Text.Trim();

            if (kullaniciAdi == "batu" && sifre == "7474")
            {
                MessageBox.Show("Giriş Başarılı! Hoş geldiniz.", "Sistem Girişi", MessageBoxButtons.OK, MessageBoxIcon.Information);


                frmanasayfa anaForm = new frmanasayfa();
                anaForm.Show();


                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);


                txtşifre.Clear();
                txtisim.Focus();
            }


        }
    }
}

