namespace kutuphane
{
    partial class frmodunc
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
            txtaçıklama = new TextBox();
            txtno = new TextBox();
            combokitapadı = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            textBox3 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            btnkitapver = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(combokitapadı);
            groupBox1.Controls.Add(txtno);
            groupBox1.Controls.Add(txtaçıklama);
            groupBox1.Location = new Point(5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(785, 139);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "BİLGİ GİRİŞİ";
            // 
            // txtaçıklama
            // 
            txtaçıklama.Location = new Point(542, 22);
            txtaçıklama.Multiline = true;
            txtaçıklama.Name = "txtaçıklama";
            txtaçıklama.Size = new Size(222, 111);
            txtaçıklama.TabIndex = 0;
            // 
            // txtno
            // 
            txtno.Location = new Point(165, 33);
            txtno.Name = "txtno";
            txtno.Size = new Size(248, 23);
            txtno.TabIndex = 1;
            txtno.TextChanged += txtno_TextChanged;
            // 
            // combokitapadı
            // 
            combokitapadı.FormattingEnabled = true;
            combokitapadı.Location = new Point(138, 69);
            combokitapadı.Name = "combokitapadı";
            combokitapadı.Size = new Size(248, 23);
            combokitapadı.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label1.Location = new Point(0, 27);
            label1.Name = "label1";
            label1.Size = new Size(164, 32);
            label1.TabIndex = 3;
            label1.Text = "ÖĞRENCİ NO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.Location = new Point(0, 69);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 4;
            label2.Text = "KİTAP ADI";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(427, 28);
            label3.Name = "label3";
            label3.Size = new Size(109, 25);
            label3.TabIndex = 4;
            label3.Text = "AÇIKLAMA";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnkitapver);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(8, 145);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(780, 74);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(23, 36);
            label4.Name = "label4";
            label4.Size = new Size(133, 25);
            label4.TabIndex = 0;
            label4.Text = "ÖĞRENCİ ADI";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(162, 41);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(173, 23);
            textBox3.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(631, 6);
            button1.Name = "button1";
            button1.Size = new Size(130, 62);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(495, 6);
            button2.Name = "button2";
            button2.Size = new Size(130, 62);
            button2.TabIndex = 2;
            button2.Text = "button1";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // btnkitapver
            // 
            btnkitapver.Location = new Point(359, 6);
            btnkitapver.Name = "btnkitapver";
            btnkitapver.Size = new Size(130, 62);
            btnkitapver.TabIndex = 2;
            btnkitapver.Text = "KİTAP VER";
            btnkitapver.TextAlign = ContentAlignment.BottomCenter;
            btnkitapver.UseVisualStyleBackColor = true;
            btnkitapver.Click += btnkitapver_Click;
            // 
            // frmodunc
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmodunc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmodunc";
            Load += frmodunc_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtno;
        private TextBox txtaçıklama;
        private Label label2;
        private Label label1;
        private ComboBox combokitapadı;
        private Label label3;
        private GroupBox groupBox2;
        private Button btnkitapver;
        private Button button2;
        private Button button1;
        private TextBox textBox3;
        private Label label4;
    }
}