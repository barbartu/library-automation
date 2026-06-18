namespace kutuphane
{
    partial class frmogrenciislemi
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
            griOgrenci = new DataGridView();
            groupBox3 = new GroupBox();
            txtarama = new TextBox();
            label7 = new Label();
            groupBox2 = new GroupBox();
            btngüncelle = new Button();
            btnsil = new Button();
            brnkaydet = new Button();
            groupBox1 = new GroupBox();
            combosınıf = new ComboBox();
            combocinsiyet = new ComboBox();
            txttelefon = new TextBox();
            txtsoyad = new TextBox();
            txtokulno = new TextBox();
            txtad = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)griOgrenci).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // griOgrenci
            // 
            griOgrenci.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            griOgrenci.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            griOgrenci.EditMode = DataGridViewEditMode.EditProgrammatically;
            griOgrenci.Location = new Point(0, 285);
            griOgrenci.Name = "griOgrenci";
            griOgrenci.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            griOgrenci.Size = new Size(801, 165);
            griOgrenci.TabIndex = 7;
            griOgrenci.CellContentClick += griOgrenci_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtarama);
            groupBox3.Controls.Add(label7);
            groupBox3.Location = new Point(0, 180);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(361, 100);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "ARAMA";
            // 
            // txtarama
            // 
            txtarama.Location = new Point(139, 47);
            txtarama.Name = "txtarama";
            txtarama.Size = new Size(194, 23);
            txtarama.TabIndex = 1;
            txtarama.TextChanged += textBox5_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label7.Location = new Point(0, 47);
            label7.Name = "label7";
            label7.Size = new Size(133, 25);
            label7.TabIndex = 0;
            label7.Text = "ÖĞRENCİ ADI";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btngüncelle);
            groupBox2.Controls.Add(btnsil);
            groupBox2.Controls.Add(brnkaydet);
            groupBox2.Location = new Point(362, 177);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(419, 103);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "İŞLEMLER";
            // 
            // btngüncelle
            // 
            btngüncelle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btngüncelle.Location = new Point(284, 12);
            btngüncelle.Name = "btngüncelle";
            btngüncelle.Size = new Size(129, 91);
            btngüncelle.TabIndex = 2;
            btngüncelle.Text = "GÜNCELLE";
            btngüncelle.UseVisualStyleBackColor = true;
            btngüncelle.Click += btngüncelle_Click;
            // 
            // btnsil
            // 
            btnsil.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            btnsil.Location = new Point(149, 12);
            btnsil.Name = "btnsil";
            btnsil.Size = new Size(129, 91);
            btnsil.TabIndex = 1;
            btnsil.Text = "SİL";
            btnsil.UseVisualStyleBackColor = true;
            btnsil.Click += btnsil_Click;
            // 
            // brnkaydet
            // 
            brnkaydet.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            brnkaydet.Location = new Point(14, 12);
            brnkaydet.Name = "brnkaydet";
            brnkaydet.Size = new Size(129, 91);
            brnkaydet.TabIndex = 0;
            brnkaydet.Text = "KAYDET";
            brnkaydet.UseVisualStyleBackColor = true;
            brnkaydet.Click += brnkaydet_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(combosınıf);
            groupBox1.Controls.Add(combocinsiyet);
            groupBox1.Controls.Add(txttelefon);
            groupBox1.Controls.Add(txtsoyad);
            groupBox1.Controls.Add(txtokulno);
            groupBox1.Controls.Add(txtad);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(781, 176);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "BİLGİ GİRİŞİ";
            // 
            // combosınıf
            // 
            combosınıf.FormattingEnabled = true;
            combosınıf.Location = new Point(83, 131);
            combosınıf.Name = "combosınıf";
            combosınıf.Size = new Size(121, 23);
            combosınıf.TabIndex = 6;
            // 
            // combocinsiyet
            // 
            combocinsiyet.FormattingEnabled = true;
            combocinsiyet.Location = new Point(338, 135);
            combocinsiyet.Name = "combocinsiyet";
            combocinsiyet.Size = new Size(160, 23);
            combocinsiyet.TabIndex = 5;
            // 
            // txttelefon
            // 
            txttelefon.Location = new Point(602, 45);
            txttelefon.Name = "txttelefon";
            txttelefon.Size = new Size(179, 23);
            txttelefon.TabIndex = 4;
            // 
            // txtsoyad
            // 
            txtsoyad.Location = new Point(602, 138);
            txtsoyad.Name = "txtsoyad";
            txtsoyad.Size = new Size(179, 23);
            txtsoyad.TabIndex = 4;
            // 
            // txtokulno
            // 
            txtokulno.Location = new Point(102, 45);
            txtokulno.Name = "txtokulno";
            txtokulno.Size = new Size(179, 23);
            txtokulno.TabIndex = 4;
            // 
            // txtad
            // 
            txtad.Location = new Point(325, 45);
            txtad.Name = "txtad";
            txtad.Size = new Size(179, 23);
            txtad.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.Location = new Point(10, 129);
            label5.Name = "label5";
            label5.Size = new Size(67, 30);
            label5.TabIndex = 3;
            label5.Text = "SINIF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.Location = new Point(214, 129);
            label4.Name = "label4";
            label4.Size = new Size(105, 30);
            label4.TabIndex = 3;
            label4.Text = "CİNSİYET";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.Location = new Point(0, 41);
            label3.Name = "label3";
            label3.Size = new Size(114, 30);
            label3.TabIndex = 2;
            label3.Text = "OKUL NO ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label6.Location = new Point(499, 38);
            label6.Name = "label6";
            label6.Size = new Size(102, 30);
            label6.TabIndex = 1;
            label6.Text = "TELEFON";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.Location = new Point(511, 131);
            label2.Name = "label2";
            label2.Size = new Size(90, 30);
            label2.TabIndex = 1;
            label2.Text = "SOY AD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.Location = new Point(287, 41);
            label1.Name = "label1";
            label1.Size = new Size(43, 30);
            label1.TabIndex = 0;
            label1.Text = "AD";
            // 
            // frmogrenciislemi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(griOgrenci);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmogrenciislemi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmogrenciislemi";
            Load += frmogrenciislemi_Load;
            ((System.ComponentModel.ISupportInitialize)griOgrenci).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView griOgrenci;
        private GroupBox groupBox3;
        private TextBox txtarama;
        private Label label7;
        private GroupBox groupBox2;
        private Button btngüncelle;
        private Button btnsil;
        private Button brnkaydet;
        private GroupBox groupBox1;
        private ComboBox combosınıf;
        private ComboBox combocinsiyet;
        private TextBox txttelefon;
        private TextBox txtsoyad;
        private TextBox txtokulno;
        private TextBox txtad;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label2;
        private Label label1;
    }
}