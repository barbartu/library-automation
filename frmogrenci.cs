using System.Data;
using Microsoft.Data.SqlClient;

namespace kutuphane
{
    public partial class frmogrenci : Form
    {
        private readonly SqlConnection baglanti = new(Veritabani.BaglantiCumlesi);
        SqlCommand? komut;
        string komutSatiri = string.Empty;

        public frmogrenci()
        {
            InitializeComponent();
        }

        public void Temizle()
        {
            txtad.Clear();
            txtsoyad.Clear();
            txtokulno.Clear();
            txttelefon.Clear();
            combosınıf.SelectedIndex = -1;
            combocinsiyet.SelectedIndex = -1;
        }

        private void txtogrenciara_TextChanged(object sender, EventArgs e)
        {
            OgrenciArama(txtogrenciara.Text);
        }

        public void OgrenciArama(string aranacakKelime)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }

                komut = new SqlCommand
                {
                    Connection = baglanti,
                    CommandText = "SELECT * FROM ogrenciler WHERE ad LIKE @kelime + '%'"
                };
                komut.Parameters.AddWithValue("@kelime", aranacakKelime);

                SqlDataAdapter dataAdapter = new(komut);
                DataTable dataTable = new();
                dataAdapter.Fill(dataTable);

                baglanti.Close();

                gridogrenci.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void combocinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void frmogrenci_Load(object sender, EventArgs e)
        {
            if (combosınıf.Items.Count == 0)
            {
                for (int i = 1; i <= 12; i++)
                    combosınıf.Items.Add(i.ToString());
            }

            if (combocinsiyet.Items.Count == 0)
            {
                combocinsiyet.Items.Add("Erkek");
                combocinsiyet.Items.Add("Kadın");
            }

            Listele();
        }

        public void Listele()
        {
            try
            {
                komutSatiri = "SELECT * FROM ogrenciler";

                SqlDataAdapter dataAdapter = new(komutSatiri, baglanti);

                DataTable dataTable = new();
                dataAdapter.Fill(dataTable);
                gridogrenci.DataSource = dataTable;

                if (gridogrenci.Columns["ogrenci_no"] != null)
                    gridogrenci.Columns["ogrenci_no"].HeaderText = "Öğrenci Numarası";
                if (gridogrenci.Columns["ad"] != null)
                    gridogrenci.Columns["ad"].HeaderText = "Ad";
                if (gridogrenci.Columns["soyad"] != null)
                    gridogrenci.Columns["soyad"].HeaderText = "Soyad";
                if (gridogrenci.Columns["sinif"] != null)
                    gridogrenci.Columns["sinif"].HeaderText = "Sınıf";
                if (gridogrenci.Columns["cinsiyet"] != null)
                    gridogrenci.Columns["cinsiyet"].HeaderText = "Cinsiyet";
                if (gridogrenci.Columns["telefon"] != null)
                    gridogrenci.Columns["telefon"].HeaderText = "Telefon";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }

                komutSatiri = "INSERT INTO ogrenciler (ogrenci_no, ad, soyad, sinif, cinsiyet, telefon) VALUES (@no, @ad, @soyad, @sinif, @cinsiyet, @telefon)";

                komut = new SqlCommand(komutSatiri, baglanti);

                komut.Parameters.AddWithValue("@no", int.Parse(txtokulno.Text));
                komut.Parameters.AddWithValue("@ad", txtad.Text);
                komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                komut.Parameters.AddWithValue("@sinif", int.Parse(combosınıf.SelectedItem?.ToString() ?? "0"));
                komut.Parameters.AddWithValue("@cinsiyet", combocinsiyet.SelectedItem?.ToString() ?? string.Empty);
                komut.Parameters.AddWithValue("@telefon", txttelefon.Text);

                komut.ExecuteNonQuery();

                baglanti.Close();

                Temizle();

                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridogrenci_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gridogrenci.CurrentRow == null) return;

                txtokulno.Text = gridogrenci.CurrentRow.Cells["ogrenci_no"].Value?.ToString() ?? string.Empty;
                txtad.Text = gridogrenci.CurrentRow.Cells["ad"].Value?.ToString() ?? string.Empty;
                txtsoyad.Text = gridogrenci.CurrentRow.Cells["soyad"].Value?.ToString() ?? string.Empty;
                txttelefon.Text = gridogrenci.CurrentRow.Cells["telefon"].Value?.ToString() ?? string.Empty;
                combosınıf.SelectedItem = gridogrenci.CurrentRow.Cells["sinif"].Value?.ToString();
                combocinsiyet.SelectedItem = gridogrenci.CurrentRow.Cells["cinsiyet"].Value?.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata oluştu", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridogrenci.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz öğrenciyi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }

                komutSatiri = "DELETE FROM ogrenciler WHERE ogrenci_no = @no";

                komut = new SqlCommand(komutSatiri, baglanti);

                komut.Parameters.AddWithValue("@no", gridogrenci.CurrentRow.Cells["ogrenci_no"].Value?.ToString() ?? string.Empty);

                komut.ExecuteNonQuery();

                baglanti.Close();

                Temizle();

                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridogrenci.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz öğrenciyi seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                }

                komutSatiri = "UPDATE ogrenciler SET ad=@ad, soyad=@soyad, sinif=@sinif, cinsiyet=@cinsiyet, telefon=@telefon WHERE ogrenci_no=@no";

                komut = new SqlCommand(komutSatiri, baglanti);

                komut.Parameters.AddWithValue("@no", int.Parse(gridogrenci.CurrentRow.Cells["ogrenci_no"].Value?.ToString() ?? "0"));
                komut.Parameters.AddWithValue("@ad", txtad.Text);
                komut.Parameters.AddWithValue("@soyad", txtsoyad.Text);
                komut.Parameters.AddWithValue("@sinif", int.Parse(combosınıf.SelectedItem?.ToString() ?? "0"));
                komut.Parameters.AddWithValue("@cinsiyet", combocinsiyet.SelectedItem?.ToString() ?? string.Empty);
                komut.Parameters.AddWithValue("@telefon", txttelefon.Text);

                komut.ExecuteNonQuery();

                baglanti.Close();

                Temizle();

                MessageBox.Show("İşlem başarılı", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata oluştu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
