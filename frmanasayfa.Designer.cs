namespace kutuphane
{
    partial class frmanasayfa
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
            btntur = new Button();
            btnogrenci = new Button();
            btnodunckıtap = new Button();
            btnkitapişleri = new Button();
            SuspendLayout();
            // 
            // btntur
            // 
            btntur.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            btntur.Location = new Point(432, 39);
            btntur.Name = "btntur";
            btntur.Size = new Size(179, 129);
            btntur.TabIndex = 0;
            btntur.Text = "TÜR İŞLEMLERİ";
            btntur.UseVisualStyleBackColor = true;
            btntur.Click += btntur_Click;
            // 
            // btnogrenci
            // 
            btnogrenci.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            btnogrenci.Location = new Point(227, 39);
            btnogrenci.Name = "btnogrenci";
            btnogrenci.Size = new Size(179, 129);
            btnogrenci.TabIndex = 1;
            btnogrenci.Text = "ÖĞRENCİ İŞLERİ";
            btnogrenci.UseVisualStyleBackColor = true;
            btnogrenci.Click += btnogrenci_Click;
            // 
            // btnodunckıtap
            // 
            btnodunckıtap.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            btnodunckıtap.Location = new Point(227, 195);
            btnodunckıtap.Name = "btnodunckıtap";
            btnodunckıtap.Size = new Size(179, 129);
            btnodunckıtap.TabIndex = 2;
            btnodunckıtap.Text = "ÖDÜNÇ KİTAP";
            btnodunckıtap.UseVisualStyleBackColor = true;
            btnodunckıtap.Click += btnodunckıtap_Click;
            // 
            // btnkitapişleri
            // 
            btnkitapişleri.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold);
            btnkitapişleri.Location = new Point(432, 195);
            btnkitapişleri.Name = "btnkitapişleri";
            btnkitapişleri.Size = new Size(179, 129);
            btnkitapişleri.TabIndex = 3;
            btnkitapişleri.Text = "KİTAP İŞLERİ";
            btnkitapişleri.UseVisualStyleBackColor = true;
            btnkitapişleri.Click += btnkitapişleri_Click;
            // 
            // frmanasayfa
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnkitapişleri);
            Controls.Add(btnodunckıtap);
            Controls.Add(btnogrenci);
            Controls.Add(btntur);
            Name = "frmanasayfa";
            Text = "frmanasayfa";
            ResumeLayout(false);
        }

        #endregion

        private Button btntur;
        private Button btnogrenci;
        private Button btnodunckıtap;
        private Button btnkitapişleri;
    }
}