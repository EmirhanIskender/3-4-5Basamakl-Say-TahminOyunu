namespace _4_Basamaklı_Sayı_Tahmin_Oyunu
{
    partial class Form2
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
            tbxUserName = new TextBox();
            tbxPassword = new TextBox();
            btnGiris = new Button();
            label3 = new Label();
            btnKayıtol = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(207, 134);
            label1.Name = "label1";
            label1.Size = new Size(134, 28);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(276, 176);
            label2.Name = "label2";
            label2.Size = new Size(65, 28);
            label2.TabIndex = 1;
            label2.Text = "Şifre : ";
            // 
            // tbxUserName
            // 
            tbxUserName.Font = new Font("Segoe UI", 12F);
            tbxUserName.Location = new Point(347, 139);
            tbxUserName.Name = "tbxUserName";
            tbxUserName.Size = new Size(176, 29);
            tbxUserName.TabIndex = 2;
            // 
            // tbxPassword
            // 
            tbxPassword.Font = new Font("Segoe UI", 12F);
            tbxPassword.Location = new Point(347, 181);
            tbxPassword.Name = "tbxPassword";
            tbxPassword.Size = new Size(176, 29);
            tbxPassword.TabIndex = 3;
            // 
            // btnGiris
            // 
            btnGiris.Font = new Font("Segoe UI", 15F);
            btnGiris.Location = new Point(347, 226);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(95, 37);
            btnGiris.TabIndex = 4;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 289);
            label3.Name = "label3";
            label3.Size = new Size(190, 15);
            label3.TabIndex = 5;
            label3.Text = "Kayıtlı değilmisiniz ozaman hemen";
            // 
            // btnKayıtol
            // 
            btnKayıtol.Location = new Point(448, 285);
            btnKayıtol.Name = "btnKayıtol";
            btnKayıtol.Size = new Size(75, 23);
            btnKayıtol.TabIndex = 6;
            btnKayıtol.Text = "Kayıt Ol";
            btnKayıtol.UseVisualStyleBackColor = true;
            btnKayıtol.Click += btnKayıtol_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(800, 450);
            Controls.Add(btnKayıtol);
            Controls.Add(label3);
            Controls.Add(btnGiris);
            Controls.Add(tbxPassword);
            Controls.Add(tbxUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbxUserName;
        private TextBox tbxPassword;
        private Button btnGiris;
        private Label label3;
        private Button btnKayıtol;
    }
}