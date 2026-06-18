namespace kutuphane
{
    partial class frmtur
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
            groupBox1 = new GroupBox();
            gridkitaptur = new DataGridView();
            groupBox3 = new GroupBox();
            BTNGÜNCELLE = new Button();
            BTNSİL = new Button();
            BTNKAYDET = new Button();
            groupBox2 = new GroupBox();
            TXTTURADI = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridkitaptur).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(gridkitaptur);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(22, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(755, 425);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "KİTAP TÜR İŞLEMLERİ";
            // 
            // gridkitaptur
            // 
            gridkitaptur.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridkitaptur.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridkitaptur.EditMode = DataGridViewEditMode.EditProgrammatically;
            gridkitaptur.Location = new Point(6, 234);
            gridkitaptur.Name = "gridkitaptur";
            gridkitaptur.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridkitaptur.Size = new Size(743, 203);
            gridkitaptur.TabIndex = 1;
            gridkitaptur.CellContentClick += gridkitaptur_CellContentClick;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(BTNGÜNCELLE);
            groupBox3.Controls.Add(BTNSİL);
            groupBox3.Controls.Add(BTNKAYDET);
            groupBox3.Location = new Point(6, 110);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(749, 118);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "İŞLEMLER";
            // 
            // BTNGÜNCELLE
            // 
            BTNGÜNCELLE.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            BTNGÜNCELLE.Location = new Point(503, 15);
            BTNGÜNCELLE.Name = "BTNGÜNCELLE";
            BTNGÜNCELLE.Size = new Size(240, 97);
            BTNGÜNCELLE.TabIndex = 1;
            BTNGÜNCELLE.Text = "GÜNCELLE";
            BTNGÜNCELLE.UseVisualStyleBackColor = true;
            BTNGÜNCELLE.Click += BTNGÜNCELLE_Click;
            // 
            // BTNSİL
            // 
            BTNSİL.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            BTNSİL.Location = new Point(257, 15);
            BTNSİL.Name = "BTNSİL";
            BTNSİL.Size = new Size(240, 97);
            BTNSİL.TabIndex = 1;
            BTNSİL.Text = "SİL";
            BTNSİL.UseVisualStyleBackColor = true;
            BTNSİL.Click += BTNSİL_Click;
            // 
            // BTNKAYDET
            // 
            BTNKAYDET.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            BTNKAYDET.Location = new Point(11, 15);
            BTNKAYDET.Name = "BTNKAYDET";
            BTNKAYDET.Size = new Size(240, 97);
            BTNKAYDET.TabIndex = 1;
            BTNKAYDET.Text = "KAYDET";
            BTNKAYDET.UseVisualStyleBackColor = true;
            BTNKAYDET.Click += BTNKAYDET_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(TXTTURADI);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(6, 22);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(743, 91);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "BİLGİ GİRİŞİ";
            // 
            // TXTTURADI
            // 
            TXTTURADI.Location = new Point(207, 40);
            TXTTURADI.Name = "TXTTURADI";
            TXTTURADI.Size = new Size(371, 23);
            TXTTURADI.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(46, 31);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 1;
            label1.Text = "TÜR ADI";
            // 
            // frmtur
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmtur";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmtur";
            Load += frmtur_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridkitaptur).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label label1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button BTNGÜNCELLE;
        private Button BTNSİL;
        private Button BTNKAYDET;
        private DataGridView gridkitaptur;
        private TextBox TXTTURADI;
    }
}