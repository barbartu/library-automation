namespace kutuphane
{
    partial class frmgiriş
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
            label1 = new Label();
            label2 = new Label();
            txtisim = new TextBox();
            txtşifre = new TextBox();
            groupBox1 = new GroupBox();
            btngiris = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(184, 20);
            label1.Name = "label1";
            label1.Size = new Size(61, 32);
            label1.TabIndex = 0;
            label1.Text = "isim";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(181, 108);
            label2.Name = "label2";
            label2.Size = new Size(64, 32);
            label2.TabIndex = 1;
            label2.Text = "şifre";
            label2.Click += label2_Click;
            // 
            // txtisim
            // 
            txtisim.Location = new Point(251, 29);
            txtisim.Name = "txtisim";
            txtisim.Size = new Size(325, 23);
            txtisim.TabIndex = 2;
            // 
            // txtşifre
            // 
            txtşifre.Location = new Point(251, 117);
            txtşifre.Name = "txtşifre";
            txtşifre.Size = new Size(325, 23);
            txtşifre.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btngiris);
            groupBox1.Controls.Add(txtşifre);
            groupBox1.Controls.Add(txtisim);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 308);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "BİLGİ GİRİŞİ";
            // 
            // btngiris
            // 
            btngiris.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btngiris.Location = new Point(184, 164);
            btngiris.Name = "btngiris";
            btngiris.Size = new Size(392, 138);
            btngiris.TabIndex = 4;
            btngiris.Text = "GİRİŞ";
            btngiris.UseVisualStyleBackColor = true;
            btngiris.Click += button1_Click;
            // 
            // frmgiriş
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Name = "frmgiriş";
            Text = "frmgiriş";
            Load += frmgiriş_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtisim;
        private TextBox txtşifre;
        private GroupBox groupBox1;
        private Button btngiris;
    }
}