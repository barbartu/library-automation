using System.Data;
using Microsoft.Data.SqlClient;

namespace kutuphane
{
    public partial class frmodunc : Form
    {
        private readonly SqlConnection baglanti = new(Veritabani.BaglantiCumlesi);
        SqlCommand? komut;

        public frmodunc()
        {
            InitializeComponent();
        }

        private void frmodunc_Load(object sender, EventArgs e)
        {
            KitaplariYukle();
        }

        private void KitaplariYukle()
        {
            try
            {
                komut = new SqlCommand("SELECT kitap_id, kitap_adi FROM kitaplar", baglanti);
                SqlDataAdapter adapter = new(komut);
                DataTable dt = new();
                adapter.Fill(dt);

                combokitapadı.DisplayMember = "kitap_adi";
                combokitapadı.ValueMember = "kitap_id";
                combokitapadı.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kitaplar yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnkitapver_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtno.Text))
            {
                MessageBox.Show("Öğrenci numarası giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (combokitapadı.SelectedValue == null)
            {
                MessageBox.Show("Kitap seçiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                komut = new SqlCommand(
                    "INSERT INTO odunc (ogrenci_no, kitap_id, aciklama, verilis_tarihi) VALUES (@ogrenci, @kitap, @aciklama, @tarih)",
                    baglanti);
                komut.Parameters.AddWithValue("@ogrenci", int.Parse(txtno.Text.Trim()));
                komut.Parameters.AddWithValue("@kitap", combokitapadı.SelectedValue);
                komut.Parameters.AddWithValue("@aciklama", txtaçıklama.Text.Trim());
                komut.Parameters.AddWithValue("@tarih", DateTime.Now);

                komut.ExecuteNonQuery();
                baglanti.Close();

                txtno.Clear();
                txtaçıklama.Clear();
                textBox3.Clear();
                MessageBox.Show("Kitap ödünç verildi.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("İşlem hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtno_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtno.Text))
            {
                textBox3.Clear();
                return;
            }

            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                komut = new SqlCommand("SELECT ad, soyad FROM ogrenciler WHERE ogrenci_no = @no", baglanti);
                komut.Parameters.AddWithValue("@no", txtno.Text.Trim());

                using SqlDataReader reader = komut.ExecuteReader();
                if (reader.Read())
                    textBox3.Text = $"{reader["ad"]} {reader["soyad"]}";
                else
                    textBox3.Text = string.Empty;

                baglanti.Close();
            }
            catch (Exception)
            {
                textBox3.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
