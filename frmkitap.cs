using System.Data;
using Microsoft.Data.SqlClient;

namespace kutuphane
{
    public partial class frmkitap : Form
    {
        private readonly SqlConnection baglanti = new(Veritabani.BaglantiCumlesi);
        SqlCommand? komut;
        string komutSatiri = string.Empty;

        public frmkitap()
        {
            InitializeComponent();
        }

        public void Temizle()
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            comboBox1.SelectedIndex = -1;
        }

        private void frmkitap_Load(object sender, EventArgs e)
        {
            TurleriYukle();
            Listele();
        }

        private void TurleriYukle()
        {
            try
            {
                komut = new SqlCommand("SELECT tur_id, tur_adi FROM turler", baglanti);
                SqlDataAdapter adapter = new(komut);
                DataTable dt = new();
                adapter.Fill(dt);

                comboBox1.DisplayMember = "tur_adi";
                comboBox1.ValueMember = "tur_id";
                comboBox1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Türler yüklenemedi: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Listele()
        {
            try
            {
                komutSatiri = @"SELECT k.kitap_id, k.kitap_adi, k.yazar, k.yayin_evi, k.sayfa_sayisi, t.tur_adi
                                FROM kitaplar k
                                LEFT JOIN turler t ON k.tur_id = t.tur_id";
                SqlDataAdapter dataAdapter = new(komutSatiri, baglanti);
                DataTable dataTable = new();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;

                if (dataGridView1.Columns["kitap_id"] != null)
                    dataGridView1.Columns["kitap_id"].HeaderText = "Kitap ID";
                if (dataGridView1.Columns["kitap_adi"] != null)
                    dataGridView1.Columns["kitap_adi"].HeaderText = "Kitap Adı";
                if (dataGridView1.Columns["yazar"] != null)
                    dataGridView1.Columns["yazar"].HeaderText = "Yazar";
                if (dataGridView1.Columns["yayin_evi"] != null)
                    dataGridView1.Columns["yayin_evi"].HeaderText = "Yayın Evi";
                if (dataGridView1.Columns["sayfa_sayisi"] != null)
                    dataGridView1.Columns["sayfa_sayisi"].HeaderText = "Sayfa Sayısı";
                if (dataGridView1.Columns["tur_adi"] != null)
                    dataGridView1.Columns["tur_adi"].HeaderText = "Tür";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KitapAra(string aranacakKelime)
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                komut = new SqlCommand
                {
                    Connection = baglanti,
                    CommandText = @"SELECT k.kitap_id, k.kitap_adi, k.yazar, k.yayin_evi, k.sayfa_sayisi, t.tur_adi
                                    FROM kitaplar k
                                    LEFT JOIN turler t ON k.tur_id = t.tur_id
                                    WHERE k.kitap_adi LIKE @kelime + '%'"
                };
                komut.Parameters.AddWithValue("@kelime", aranacakKelime);

                SqlDataAdapter adapter = new(komut);
                DataTable dt = new();
                adapter.Fill(dt);
                baglanti.Close();

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Arama hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Kitap adı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                komutSatiri = "INSERT INTO kitaplar (kitap_adi, yazar, yayin_evi, sayfa_sayisi, tur_id) VALUES (@adi, @yazar, @yayin, @sayfa, @tur)";
                komut = new SqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@adi", textBox2.Text.Trim());
                komut.Parameters.AddWithValue("@yazar", textBox3.Text.Trim());
                komut.Parameters.AddWithValue("@yayin", textBox5.Text.Trim());
                komut.Parameters.AddWithValue("@sayfa", int.TryParse(textBox4.Text, out int sayfa) ? sayfa : 0);
                komut.Parameters.AddWithValue("@tur", comboBox1.SelectedValue ?? DBNull.Value);

                komut.ExecuteNonQuery();
                baglanti.Close();

                Temizle();
                MessageBox.Show("Kitap kaydedildi.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Silinecek kitabı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                komutSatiri = "DELETE FROM kitaplar WHERE kitap_id = @id";
                komut = new SqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["kitap_id"].Value?.ToString() ?? string.Empty);

                komut.ExecuteNonQuery();
                baglanti.Close();

                Temizle();
                MessageBox.Show("Kitap silindi.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Güncellenecek kitabı seçin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (baglanti.State != ConnectionState.Open)
                    baglanti.Open();

                komutSatiri = @"UPDATE kitaplar SET kitap_adi=@adi, yazar=@yazar, yayin_evi=@yayin,
                                sayfa_sayisi=@sayfa, tur_id=@tur WHERE kitap_id=@id";
                komut = new SqlCommand(komutSatiri, baglanti);
                komut.Parameters.AddWithValue("@id", dataGridView1.CurrentRow.Cells["kitap_id"].Value?.ToString() ?? string.Empty);
                komut.Parameters.AddWithValue("@adi", textBox2.Text.Trim());
                komut.Parameters.AddWithValue("@yazar", textBox3.Text.Trim());
                komut.Parameters.AddWithValue("@yayin", textBox5.Text.Trim());
                komut.Parameters.AddWithValue("@sayfa", int.TryParse(textBox4.Text, out int sayfa) ? sayfa : 0);
                komut.Parameters.AddWithValue("@tur", comboBox1.SelectedValue ?? DBNull.Value);

                komut.ExecuteNonQuery();
                baglanti.Close();

                Temizle();
                MessageBox.Show("Kitap güncellendi.", "Mesaj", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
                Listele();
            else
                KitapAra(textBox1.Text.Trim());
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow == null) return;

                textBox2.Text = dataGridView1.CurrentRow.Cells["kitap_adi"].Value?.ToString() ?? string.Empty;
                textBox3.Text = dataGridView1.CurrentRow.Cells["yazar"].Value?.ToString() ?? string.Empty;
                textBox5.Text = dataGridView1.CurrentRow.Cells["yayin_evi"].Value?.ToString() ?? string.Empty;
                textBox4.Text = dataGridView1.CurrentRow.Cells["sayfa_sayisi"].Value?.ToString() ?? string.Empty;

                string turAdi = dataGridView1.CurrentRow.Cells["tur_adi"].Value?.ToString() ?? string.Empty;
                int turIndex = comboBox1.FindStringExact(turAdi);
                if (turIndex >= 0)
                    comboBox1.SelectedIndex = turIndex;
            }
            catch (Exception)
            {
                // seçim hatası yoksayılır
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {
        }
    }
}
