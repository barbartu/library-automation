namespace kutuphane
{
    partial class frmogrenci
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
            groupBox2 = new GroupBox();
            btnkaydet = new Button();
            btnsil = new Button();
            btngüncelle = new Button();
            txtogrenciara = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            combosınıf = new ComboBox();
            combocinsiyet = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txttelefon = new TextBox();
            txtsoyad = new TextBox();
            txtad = new TextBox();
            txtokulno = new TextBox();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            gridogrenci = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridogrenci).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnkaydet);
            groupBox2.Controls.Add(btnsil);
            groupBox2.Controls.Add(btngüncelle);
            groupBox2.Controls.Add(txtogrenciara);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(0, 152);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(800, 79);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "İŞLEMLER";
            // 
            // btnkaydet
            // 
            btnkaydet.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnkaydet.Location = new Point(378, 11);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(132, 61);
            btnkaydet.TabIndex = 11;
            btnkaydet.Text = "KAYDET";
            btnkaydet.TextAlign = ContentAlignment.BottomCenter;
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // btnsil
            // 
            btnsil.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnsil.Location = new Point(516, 11);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(132, 61);
            btnsil.TabIndex = 11;
            btnsil.Text = "SİL";
            btnsil.TextAlign = ContentAlignment.BottomCenter;
            btnsil.UseVisualStyleBackColor = true;
            btnsil.Click += btnsil_Click;
            // 
            // btngüncelle
            // 
            btngüncelle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btngüncelle.Location = new Point(654, 11);
            btngüncelle.Name = "btngüncelle";
            btngüncelle.Size = new Size(132, 61);
            btngüncelle.TabIndex = 11;
            btngüncelle.Text = "GÜNCELLE";
            btngüncelle.TextAlign = ContentAlignment.BottomCenter;
            btngüncelle.UseVisualStyleBackColor = true;
            btngüncelle.Click += btngüncelle_Click;
            // 
            // txtogrenciara
            // 
            txtogrenciara.Location = new Point(167, 42);
            txtogrenciara.Name = "txtogrenciara";
            txtogrenciara.Size = new Size(140, 23);
            txtogrenciara.TabIndex = 10;
            txtogrenciara.TextChanged += txtogrenciara_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(149, 30);
            label1.TabIndex = 0;
            label1.Text = "ÖĞERNCİ ADI";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(combosınıf);
            groupBox1.Controls.Add(combocinsiyet);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txttelefon);
            groupBox1.Controls.Add(txtsoyad);
            groupBox1.Controls.Add(txtad);
            groupBox1.Controls.Add(txtokulno);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Location = new Point(0, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(794, 144);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // combosınıf
            // 
            combosınıf.FormattingEnabled = true;
            combosınıf.Location = new Point(130, 73);
            combosınıf.Name = "combosınıf";
            combosınıf.Size = new Size(124, 23);
            combosınıf.TabIndex = 11;
            // 
            // combocinsiyet
            // 
            combocinsiyet.FormattingEnabled = true;
            combocinsiyet.Location = new Point(378, 65);
            combocinsiyet.Name = "combocinsiyet";
            combocinsiyet.Size = new Size(146, 23);
            combocinsiyet.TabIndex = 11;
            combocinsiyet.SelectedIndexChanged += combocinsiyet_SelectedIndexChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label8.Location = new Point(556, 73);
            label8.Name = "label8";
            label8.Size = new Size(92, 25);
            label8.TabIndex = 6;
            label8.Text = "TELEFON";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label9.Location = new Point(553, 36);
            label9.Name = "label9";
            label9.Size = new Size(95, 25);
            label9.TabIndex = 5;
            label9.Text = "SOY İSİM";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label10.Location = new Point(260, 76);
            label10.Name = "label10";
            label10.Size = new Size(95, 25);
            label10.TabIndex = 4;
            label10.Text = "CİNSİYET";
            // 
            // txttelefon
            // 
            txttelefon.Location = new Point(654, 76);
            txttelefon.Name = "txttelefon";
            txttelefon.Size = new Size(121, 23);
            txttelefon.TabIndex = 10;
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(654, 41);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(121, 23);
            txtsoyad.TabIndex = 10;
            // 
            // txtad
            // 
            txtad.Location = new Point(378, 36);
            txtad.Name = "txtad";
            txtad.Size = new Size(146, 23);
            txtad.TabIndex = 10;
            // 
            // txtokulno
            // 
            txtokulno.Location = new Point(130, 36);
            txtokulno.Name = "txtokulno";
            txtokulno.Size = new Size(140, 23);
            txtokulno.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label11.Location = new Point(302, 39);
            label11.Name = "label11";
            label11.Size = new Size(53, 25);
            label11.TabIndex = 3;
            label11.Text = "İSİM";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label12.Location = new Point(35, 71);
            label12.Name = "label12";
            label12.Size = new Size(60, 25);
            label12.TabIndex = 2;
            label12.Text = "SINIF";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label13.Location = new Point(12, 37);
            label13.Name = "label13";
            label13.Size = new Size(96, 25);
            label13.TabIndex = 1;
            label13.Text = "OKUL NO";
            // 
            // gridogrenci
            // 
            gridogrenci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridogrenci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridogrenci.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridogrenci.Location = new Point(0, 232);
            gridogrenci.Name = "gridogrenci";
            gridogrenci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridogrenci.Size = new Size(798, 220);
            gridogrenci.TabIndex = 2;
            gridogrenci.CellContentClick += gridogrenci_CellContentClick;
            // 
            // frmogrenci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gridogrenci);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmogrenci";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmogrenci";
            Load += frmogrenci_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridogrenci).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox BİLGİGİRİŞ;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnkaydet;
        private Button btnsil;
        private Button btngüncelle;
        private TextBox txtogrenciara;
        private TextBox txttelefon;
        private TextBox txtsoyad;
        private TextBox txtad;
        private TextBox txtokulno;
        private ComboBox combosınıf;
        private ComboBox combocinsiyet;
        private DataGridView gridogrenci;
        private TextBox textBox9;
    }
}