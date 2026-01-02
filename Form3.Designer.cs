namespace _4_Basamaklı_Sayı_Tahmin_Oyunu
{
    partial class Form3
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
            label3 = new Label();
            label4 = new Label();
            tbxAd = new TextBox();
            tbxTelefon = new MaskedTextBox();
            tbxEmail = new TextBox();
            btnKaydet = new Button();
            label6 = new Label();
            tbxPasswordHash = new TextBox();
            tbxSoyad = new TextBox();
            label2 = new Label();
            label5 = new Label();
            tbxUserName = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(245, 135);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 0;
            label1.Text = "Soyad : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(233, 180);
            label3.Name = "label3";
            label3.Size = new Size(93, 28);
            label3.TabIndex = 2;
            label3.Text = "Telefon  : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F);
            label4.Location = new Point(233, 222);
            label4.Name = "label4";
            label4.Size = new Size(96, 28);
            label4.TabIndex = 3;
            label4.Text = "E-Posta  : ";
            // 
            // tbxAd
            // 
            tbxAd.Font = new Font("Segoe UI", 12F);
            tbxAd.Location = new Point(332, 88);
            tbxAd.Name = "tbxAd";
            tbxAd.Size = new Size(229, 29);
            tbxAd.TabIndex = 4;
            // 
            // tbxTelefon
            // 
            tbxTelefon.Font = new Font("Segoe UI", 12F);
            tbxTelefon.Location = new Point(332, 180);
            tbxTelefon.Mask = "(999) 000-0000";
            tbxTelefon.Name = "tbxTelefon";
            tbxTelefon.Size = new Size(100, 29);
            tbxTelefon.TabIndex = 6;
            // 
            // tbxEmail
            // 
            tbxEmail.Font = new Font("Segoe UI", 12F);
            tbxEmail.Location = new Point(332, 222);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(229, 29);
            tbxEmail.TabIndex = 7;
            // 
            // btnKaydet
            // 
            btnKaydet.Font = new Font("Segoe UI", 15F);
            btnKaydet.Location = new Point(331, 382);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(95, 41);
            btnKaydet.TabIndex = 8;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F);
            label6.Location = new Point(245, 318);
            label6.Name = "label6";
            label6.Size = new Size(80, 28);
            label6.TabIndex = 10;
            label6.Text = "Parola : ";
            // 
            // tbxPasswordHash
            // 
            tbxPasswordHash.Font = new Font("Segoe UI", 12F);
            tbxPasswordHash.Location = new Point(331, 321);
            tbxPasswordHash.Name = "tbxPasswordHash";
            tbxPasswordHash.Size = new Size(230, 29);
            tbxPasswordHash.TabIndex = 12;
            // 
            // tbxSoyad
            // 
            tbxSoyad.Font = new Font("Segoe UI", 12F);
            tbxSoyad.Location = new Point(332, 134);
            tbxSoyad.Name = "tbxSoyad";
            tbxSoyad.Size = new Size(229, 29);
            tbxSoyad.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(270, 88);
            label2.Name = "label2";
            label2.Size = new Size(56, 28);
            label2.TabIndex = 13;
            label2.Text = "Ad  : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(198, 275);
            label5.Name = "label5";
            label5.Size = new Size(128, 28);
            label5.TabIndex = 15;
            label5.Text = "Oyuncu Adı : ";
            // 
            // tbxUserName
            // 
            tbxUserName.Font = new Font("Segoe UI", 12F);
            tbxUserName.Location = new Point(332, 275);
            tbxUserName.Name = "tbxUserName";
            tbxUserName.Size = new Size(229, 29);
            tbxUserName.TabIndex = 16;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(800, 450);
            Controls.Add(tbxUserName);
            Controls.Add(label5);
            Controls.Add(tbxSoyad);
            Controls.Add(label2);
            Controls.Add(tbxPasswordHash);
            Controls.Add(label6);
            Controls.Add(btnKaydet);
            Controls.Add(tbxEmail);
            Controls.Add(tbxTelefon);
            Controls.Add(tbxAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Kayıt Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private TextBox tbxAd;
        private MaskedTextBox tbxTelefon;
        private TextBox tbxEmail;
        private Button btnKaydet;
        private Label label6;
        private TextBox tbxPasswordHash;
        private TextBox tbxSoyad;
        private Label label2;
        private Label label5;
        private TextBox tbxUserName;
    }
}