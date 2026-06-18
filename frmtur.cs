using System.Data;
using Microsoft.Data.SqlClient;

namespace kutuphane
{
    public partial class frmtur : Form
    {
        private readonly SqlConnection baglanti = new(Veritabani.BaglantiCumlesi);
        SqlCommand? komut;
        string komutSatiri = string.Empty;

        public frmtur()
        {
            InitializeComponent();
        }

        public void Temizle()
        {
            TXTTURADI.Clear();
            TXTTURADI.Focus();
        }

        private void frmtur_Load(object sender, EventArgs e)
        {
            Listele();
        }

        public void Listele()
        {
            try
            {
                komutSatiri = "SELECT * FROM turler";
                SqlDataAdapter dataAdapter = new(komutSatiri, baglanti);

                DataTable dataTable = new();
                dataAdapter.Fill(dataTable);
                gridkitaptur.DataSource = dataTable;

                if (gridkitaptur.Columns["tur_id"] != null)
                    gridkitaptur.Columns["tur_id"].HeaderText = "Tür ID";

                if (gridkitaptur.Columns["tur_adi"] != null)
                    gridkitaptur.Columns["tur_adi"].HeaderText = "Kitap Türü";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            if (gridkitaptur.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz türü tablodan seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();

                komutSatiri = "DELETE FROM turler WHERE tur_id = @id";
                komut = new SqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@id", gridkitaptur.CurrentRow.Cells["tur_id"].Value.ToString());

                komut.ExecuteNonQuery();
                baglanti.Close();

                Temizle();
                MessageBox.Show("Kitap türü başarıyla silindi.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNKAYDET_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXTTURADI.Text.Trim()))
            {
                MessageBox.Show("Lütfen bir tür adı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();

                komutSatiri = "INSERT INTO turler (tur_adi) VALUES (@turAdi)";
                komut = new SqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@turAdi", TXTTURADI.Text.Trim());

                komut.ExecuteNonQuery();
                baglanti.Close();

                Temizle();
                MessageBox.Show("Kitap türü başarıyla kaydedildi.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BTNGÜNCELLE_Click(object sender, EventArgs e)
        {
            if (gridkitaptur.CurrentRow == null)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz türü tablodan seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(TXTTURADI.Text.Trim()))
            {
                MessageBox.Show("Tür adı boş bırakılamaz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (baglanti.State != ConnectionState.Open) baglanti.Open();

                komutSatiri = "UPDATE turler SET tur_adi = @turAdi WHERE tur_id = @id";
                komut = new SqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@turAdi", TXTTURADI.Text.Trim());
                komut.Parameters.AddWithValue("@id", gridkitaptur.CurrentRow.Cells["tur_id"].Value.ToString());

                komut.ExecuteNonQuery();
                baglanti.Close();

                Temizle();
                MessageBox.Show("Kitap türü başarıyla güncellendi.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void gridkitaptur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gridkitaptur.CurrentRow != null)
                {
                    TXTTURADI.Text = gridkitaptur.CurrentRow.Cells["tur_adi"].Value?.ToString() ?? string.Empty;
                }
            }
            catch (Exception)
            {
                // seçim hatası yoksayılır
            }
        }
    }
}
