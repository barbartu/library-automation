using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane
{
    public partial class frmogrenciislemi : Form
    {
        public frmogrenciislemi()
        {
            InitializeComponent();
        }
        veriTabaniTslemleri vtIslemleri = new veriTabaniTslemleri();
        MySqlConnection baglanti;
        MySqlCommand komut;
        string komutSatiri;

        public void temizle()
        {
            txtad.Clear();
            txtsoyad.Clear();
            txttelefon.Clear();
            txtokulno.Clear();
        }
        private void frmogrenciislemi_Load(object sender, EventArgs e)
        {
            listele();
        }
        public void listele()
        {
            try
            {
                baglanti = vtIslemleri.baglan();
                komutSatiri = "select * from ogrenciler";
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komutSatiri, baglanti);
                DataTable data = new DataTable();
                dataAdapter.fill(DataTable);
                griOgrenci.DataSource = DataTable;
                griOgrenci.Columns["ogrenci_no"].HeaderText = "öğrenci Numarası";
                griOgrenci.Columns["isim"].HeaderText = "isim";
                griOgrenci.Columns["soy isim"].HeaderText = "sınıf";
                griOgrenci.Columns["sınıf"].HeaderText = "sınıf";
                griOgrenci.Columns["cinsiyet"].HeaderText = "cinsiyet";
                griOgrenci.Columns["telefon"].HeaderText = "telefon numarısı";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void brnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.state != ConnectionState.Open)
                {
                    baglanti.open();
                }
                komutSatiri = "INSERT INTO ogrenciler (ogrenci_no,isi,soyisim,sınıf,cinsiyet,telefon) VALUES(@no,@isim,@soyisim,@sınıf,@cinsiyet@telefon)";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.parameters.addwithValue("@no", int.Parse(txtokulno.Text));
                komut.parameters.addwithValue("@isim", (txtad.Text));
                komut.parameters.addwithValue("@soyisim", (txtsoyad.Text));
                komut.parameters.addwithValue("@sınıf", int.Parse(combosınıf.SelectedItem.ToString()));
                komut.parameters.addwithValue("@cinsiyet", combocinsiyet.SelectedItem.ToString());
                komut.parameters.addwithValue("@telefon", (txttelefon.Text));


                komut.executeNonQuers();
                baglanti.close();
                temizle();
                MessageBox.Show("işlem başarılı", "mesaJ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnsil_Click(object sender, EventArgs e)
        {

            try
            {
                if (baglanti.stare != ConnectionState.Open)
                {
                    baglanti.open();

                }
                komutSatiri = "DELETE FROM ogrenciler WHERE ogrenci_no = @no";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.parameters.addwithValue("@no", griOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString());
                komut.executeNonQuery();
                baglanti.close();
                temizle();
                MessageBox.Show("işlem başarılı", "mesaJ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        }

        private void griOgrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtokulno.Text = griOgrenci.CurrentRow.Cells["ogrenci_no"].Value.ToString();
                txtad.Text = griOgrenci.CurrentRow.Cells["ad"].Value.ToString();
                txtokulno.Text = griOgrenci.CurrentRow.Cells["okul no"].Value.ToString();
                txttelefon.Text = griOgrenci.CurrentRow.Cells["telefon"].Value.ToString();
                combocinsiyet.SelectedItem = griOgrenci.CurrentRow.Cells["cinsiyet"].Value.ToString();
                combosınıf.SelectedItem = griOgrenci.CurrentRow.Cells["sınıf"].Value.ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("hata oluştu ", "mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.state != ConnectionState.Open)
                {
                    baglanti.open();
                }
                komutSatiri = "INSERT INTO ogrenciler (ogrenci_no,isi,soyisim,sınıf,cinsiyet,telefon) VALUES(@no,@isim,@soyisim,@sınıf,@cinsiyet@telefon)";
                komut = new MySqlCommand(komutSatiri, baglanti);
                komut.parameters.addwithValue("@no", int.Parse(txtokulno.Text));
                komut.parameters.addwithValue("@isim", (txtad.Text));
                komut.parameters.addwithValue("@soyisim", (txtsoyad.Text));
                komut.parameters.addwithValue("@sınıf", int.Parse(combosınıf.SelectedItem.ToString()));
                komut.parameters.addwithValue("@cinsiyet", combocinsiyet.SelectedItem.ToString());
                komut.parameters.addwithValue("@telefon", (txttelefon.Text));


                komut.executeNonQuers();
                baglanti.close();
                temizle();
                MessageBox.Show("işlem başarılı", "mesaJ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           private void txtAramaOgrenci_TextChanged(object sender, EventArgs e)
        {
      
            OgrenciArama(txtarama.Text);
        }

        public void OgrenciArama(string aranacakKelime)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }

               
                komut = new MySqlCommand();

               
                komut.Connection = baglanti;

                
                komut.CommandText = "Select * From ogrenciler Where ad LIKE '" + aranacakKelime + "%'";

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(komut);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                baglanti.Close();
                griOgrenci.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
}


}
