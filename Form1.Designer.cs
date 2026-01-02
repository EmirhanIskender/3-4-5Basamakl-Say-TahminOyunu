namespace _4_Basamaklı_Sayı_Tahmin_Oyunu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnbaslat = new Button();
            tbxtahmin = new TextBox();
            btntahmin = new Button();
            lblKalanHak = new Label();
            lblsonuc = new Label();
            panel1 = new Panel();
            label2 = new Label();
            btntemizle = new Button();
            btn0 = new Button();
            lbl1 = new Label();
            btn9 = new Button();
            btngizle = new Button();
            btn8 = new Button();
            lbltutulan = new Label();
            btn7 = new Button();
            btngöster = new Button();
            btn6 = new Button();
            listBox1 = new ListBox();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            label1 = new Label();
            btn3Haneli = new Button();
            btn4Haneli = new Button();
            btn5Haneli = new Button();
            panelHaneliSayı = new Panel();
            btnHaneDeğiştir = new Button();
            lblbirinci = new Label();
            lblikinci = new Label();
            lbldördüncü = new Label();
            lblÜçüncü = new Label();
            lblbeşinci = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelSkor = new Panel();
            label3 = new Label();
            lblSure = new Label();
            panel1.SuspendLayout();
            panelHaneliSayı.SuspendLayout();
            panelSkor.SuspendLayout();
            SuspendLayout();
            // 
            // btnbaslat
            // 
            btnbaslat.BackColor = Color.FromArgb(128, 255, 128);
            btnbaslat.Font = new Font("Segoe UI", 15F);
            btnbaslat.Location = new Point(251, 99);
            btnbaslat.Name = "btnbaslat";
            btnbaslat.Size = new Size(267, 48);
            btnbaslat.TabIndex = 0;
            btnbaslat.Text = "Başlat / Yeniden Başlat";
            btnbaslat.UseVisualStyleBackColor = false;
            btnbaslat.Visible = false;
            btnbaslat.Click += btnbaslat_Click;
            // 
            // tbxtahmin
            // 
            tbxtahmin.Font = new Font("Segoe UI", 12F);
            tbxtahmin.Location = new Point(80, 136);
            tbxtahmin.Name = "tbxtahmin";
            tbxtahmin.Size = new Size(100, 29);
            tbxtahmin.TabIndex = 1;
            // 
            // btntahmin
            // 
            btntahmin.BackColor = SystemColors.MenuHighlight;
            btntahmin.Font = new Font("Segoe UI", 12F);
            btntahmin.Location = new Point(22, 179);
            btntahmin.Name = "btntahmin";
            btntahmin.Size = new Size(107, 35);
            btntahmin.TabIndex = 2;
            btntahmin.Text = "Tahmin Et";
            btntahmin.UseVisualStyleBackColor = false;
            btntahmin.Click += btntahmin_Click;
            // 
            // lblKalanHak
            // 
            lblKalanHak.AutoSize = true;
            lblKalanHak.Font = new Font("Segoe UI", 12F);
            lblKalanHak.Location = new Point(72, 103);
            lblKalanHak.Name = "lblKalanHak";
            lblKalanHak.Size = new Size(108, 21);
            lblKalanHak.TabIndex = 4;
            lblKalanHak.Text = "Kalan Hak : 10";
            // 
            // lblsonuc
            // 
            lblsonuc.AutoSize = true;
            lblsonuc.BackColor = SystemColors.GradientActiveCaption;
            lblsonuc.Font = new Font("Segoe UI", 13F);
            lblsonuc.Location = new Point(44, 39);
            lblsonuc.Name = "lblsonuc";
            lblsonuc.Size = new Size(149, 25);
            lblsonuc.TabIndex = 5;
            lblsonuc.Text = "Tahmininizi Girin !";
            // 
            // panel1
            // 
            panel1.Controls.Add(lblSure);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(btntemizle);
            panel1.Controls.Add(btn0);
            panel1.Controls.Add(lbl1);
            panel1.Controls.Add(btn9);
            panel1.Controls.Add(btngizle);
            panel1.Controls.Add(lblKalanHak);
            panel1.Controls.Add(btn8);
            panel1.Controls.Add(lbltutulan);
            panel1.Controls.Add(btn7);
            panel1.Controls.Add(btngöster);
            panel1.Controls.Add(btn6);
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(btn5);
            panel1.Controls.Add(lblsonuc);
            panel1.Controls.Add(btn4);
            panel1.Controls.Add(tbxtahmin);
            panel1.Controls.Add(btn3);
            panel1.Controls.Add(btntahmin);
            panel1.Controls.Add(btn2);
            panel1.Controls.Add(btn1);
            panel1.Location = new Point(49, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(733, 462);
            panel1.TabIndex = 8;
            panel1.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(44, 9);
            label2.Name = "label2";
            label2.Size = new Size(136, 21);
            label2.TabIndex = 21;
            label2.Text = "Haneli Sayı Giriniz";
            // 
            // btntemizle
            // 
            btntemizle.Font = new Font("Segoe UI", 12F);
            btntemizle.Location = new Point(147, 179);
            btntemizle.Name = "btntemizle";
            btntemizle.Size = new Size(100, 35);
            btntemizle.TabIndex = 20;
            btntemizle.Text = "Temizle";
            btntemizle.UseVisualStyleBackColor = true;
            btntemizle.Click += btntemizle_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 25F);
            btn0.Location = new Point(107, 405);
            btn0.Name = "btn0";
            btn0.Size = new Size(50, 50);
            btn0.TabIndex = 19;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Segoe UI", 12F);
            lbl1.Location = new Point(360, 134);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(82, 21);
            lbl1.TabIndex = 13;
            lbl1.Text = "------------";
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 25F);
            btn9.Location = new Point(163, 349);
            btn9.Name = "btn9";
            btn9.Size = new Size(50, 50);
            btn9.TabIndex = 18;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btngizle
            // 
            btngizle.Location = new Point(392, 405);
            btngizle.Name = "btngizle";
            btngizle.Size = new Size(139, 23);
            btngizle.TabIndex = 12;
            btngizle.Text = "Tutulan Sayıyı Gizle";
            btngizle.UseVisualStyleBackColor = true;
            btngizle.Visible = false;
            btngizle.Click += btngizle_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 25F);
            btn8.Location = new Point(107, 349);
            btn8.Name = "btn8";
            btn8.Size = new Size(50, 50);
            btn8.TabIndex = 17;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // lbltutulan
            // 
            lbltutulan.AutoSize = true;
            lbltutulan.Location = new Point(443, 438);
            lbltutulan.Name = "lbltutulan";
            lbltutulan.Size = new Size(37, 15);
            lbltutulan.TabIndex = 11;
            lbltutulan.Text = "------";
            lbltutulan.Visible = false;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 25F);
            btn7.Location = new Point(51, 347);
            btn7.Name = "btn7";
            btn7.Size = new Size(50, 50);
            btn7.TabIndex = 16;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btngöster
            // 
            btngöster.Location = new Point(392, 405);
            btngöster.Name = "btngöster";
            btngöster.Size = new Size(139, 23);
            btngöster.TabIndex = 10;
            btngöster.Text = "Tutulan Sayıyı Göster";
            btngöster.UseVisualStyleBackColor = true;
            btngöster.Click += btngöster_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 25F);
            btn6.Location = new Point(163, 293);
            btn6.Name = "btn6";
            btn6.Size = new Size(50, 50);
            btn6.TabIndex = 15;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(292, 179);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(427, 169);
            listBox1.TabIndex = 9;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 25F);
            btn5.Location = new Point(107, 293);
            btn5.Name = "btn5";
            btn5.Size = new Size(50, 50);
            btn5.TabIndex = 14;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 25F);
            btn4.Location = new Point(51, 291);
            btn4.Name = "btn4";
            btn4.Size = new Size(50, 50);
            btn4.TabIndex = 13;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 25F);
            btn3.Location = new Point(163, 235);
            btn3.Name = "btn3";
            btn3.Size = new Size(50, 50);
            btn3.TabIndex = 12;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 25F);
            btn2.Location = new Point(107, 235);
            btn2.Name = "btn2";
            btn2.Size = new Size(50, 50);
            btn2.TabIndex = 11;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Segoe UI", 25F);
            btn1.Location = new Point(51, 235);
            btn1.Name = "btn1";
            btn1.Size = new Size(50, 50);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.IndianRed;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(248, 9);
            label1.Name = "label1";
            label1.Size = new Size(468, 37);
            label1.TabIndex = 9;
            label1.Text = "3,4,5 HANELİ SAYI TAHMİN OYUNU";
            // 
            // btn3Haneli
            // 
            btn3Haneli.Font = new Font("Segoe UI", 12F);
            btn3Haneli.Location = new Point(3, 3);
            btn3Haneli.Name = "btn3Haneli";
            btn3Haneli.Size = new Size(115, 41);
            btn3Haneli.TabIndex = 10;
            btn3Haneli.Text = "3 Haneli Sayı";
            btn3Haneli.UseVisualStyleBackColor = true;
            btn3Haneli.Click += btn3Haneli_Click;
            // 
            // btn4Haneli
            // 
            btn4Haneli.Font = new Font("Segoe UI", 12F);
            btn4Haneli.Location = new Point(186, 3);
            btn4Haneli.Name = "btn4Haneli";
            btn4Haneli.Size = new Size(115, 41);
            btn4Haneli.TabIndex = 11;
            btn4Haneli.Text = "4 Haneli Sayı";
            btn4Haneli.UseVisualStyleBackColor = true;
            btn4Haneli.Click += btn4Haneli_Click;
            // 
            // btn5Haneli
            // 
            btn5Haneli.Font = new Font("Segoe UI", 12F);
            btn5Haneli.Location = new Point(350, 3);
            btn5Haneli.Name = "btn5Haneli";
            btn5Haneli.Size = new Size(115, 41);
            btn5Haneli.TabIndex = 12;
            btn5Haneli.Text = "5 Haneli Sayı";
            btn5Haneli.UseVisualStyleBackColor = true;
            btn5Haneli.Click += btn5Haneli_Click;
            // 
            // panelHaneliSayı
            // 
            panelHaneliSayı.Controls.Add(btn3Haneli);
            panelHaneliSayı.Controls.Add(btn5Haneli);
            panelHaneliSayı.Controls.Add(btn4Haneli);
            panelHaneliSayı.Location = new Point(248, 49);
            panelHaneliSayı.Name = "panelHaneliSayı";
            panelHaneliSayı.Size = new Size(468, 44);
            panelHaneliSayı.TabIndex = 13;
            // 
            // btnHaneDeğiştir
            // 
            btnHaneDeğiştir.Font = new Font("Segoe UI", 12F);
            btnHaneDeğiştir.Location = new Point(530, 99);
            btnHaneDeğiştir.Name = "btnHaneDeğiştir";
            btnHaneDeğiştir.Size = new Size(186, 48);
            btnHaneDeğiştir.TabIndex = 14;
            btnHaneDeğiştir.Text = "Hane Sayısını Değiştir";
            btnHaneDeğiştir.UseVisualStyleBackColor = true;
            btnHaneDeğiştir.Visible = false;
            btnHaneDeğiştir.Click += btnHaneDeğiştir_Click;
            // 
            // lblbirinci
            // 
            lblbirinci.AutoSize = true;
            lblbirinci.Font = new Font("Segoe UI", 15F);
            lblbirinci.Location = new Point(15, 19);
            lblbirinci.Name = "lblbirinci";
            lblbirinci.Size = new Size(27, 28);
            lblbirinci.TabIndex = 15;
            lblbirinci.Text = "1.";
            // 
            // lblikinci
            // 
            lblikinci.AutoSize = true;
            lblikinci.Font = new Font("Segoe UI", 15F);
            lblikinci.Location = new Point(15, 63);
            lblikinci.Name = "lblikinci";
            lblikinci.Size = new Size(27, 28);
            lblikinci.TabIndex = 16;
            lblikinci.Text = "2.";
            // 
            // lbldördüncü
            // 
            lbldördüncü.AutoSize = true;
            lbldördüncü.Font = new Font("Segoe UI", 15F);
            lbldördüncü.Location = new Point(15, 156);
            lbldördüncü.Name = "lbldördüncü";
            lbldördüncü.Size = new Size(27, 28);
            lbldördüncü.TabIndex = 17;
            lbldördüncü.Text = "4.";
            // 
            // lblÜçüncü
            // 
            lblÜçüncü.AutoSize = true;
            lblÜçüncü.Font = new Font("Segoe UI", 15F);
            lblÜçüncü.Location = new Point(15, 107);
            lblÜçüncü.Name = "lblÜçüncü";
            lblÜçüncü.Size = new Size(27, 28);
            lblÜçüncü.TabIndex = 18;
            lblÜçüncü.Text = "3.";
            // 
            // lblbeşinci
            // 
            lblbeşinci.AutoSize = true;
            lblbeşinci.Font = new Font("Segoe UI", 15F);
            lblbeşinci.Location = new Point(15, 202);
            lblbeşinci.Name = "lblbeşinci";
            lblbeşinci.Size = new Size(27, 28);
            lblbeşinci.TabIndex = 19;
            lblbeşinci.Text = "5.";
            lblbeşinci.Click += lblbeşinci_Click;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // panelSkor
            // 
            panelSkor.Controls.Add(lblbirinci);
            panelSkor.Controls.Add(lblbeşinci);
            panelSkor.Controls.Add(lblikinci);
            panelSkor.Controls.Add(lbldördüncü);
            panelSkor.Controls.Add(lblÜçüncü);
            panelSkor.Location = new Point(788, 169);
            panelSkor.Name = "panelSkor";
            panelSkor.Size = new Size(390, 433);
            panelSkor.TabIndex = 20;
            panelSkor.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(72, 79);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 22;
            label3.Text = "Süre : ";
            // 
            // lblSure
            // 
            lblSure.AutoSize = true;
            lblSure.Font = new Font("Segoe UI", 12F);
            lblSure.Location = new Point(131, 79);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(19, 21);
            lblSure.TabIndex = 23;
            lblSure.Text = "0";
            // 
            // Form1
            // 
            AcceptButton = btntahmin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1228, 664);
            Controls.Add(panelSkor);
            Controls.Add(btnHaneDeğiştir);
            Controls.Add(panelHaneliSayı);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btnbaslat);
            Name = "Form1";
            Text = "4 Haneli Sayı Tahmin Oyunu";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelHaneliSayı.ResumeLayout(false);
            panelSkor.ResumeLayout(false);
            panelSkor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnbaslat;
        private TextBox tbxtahmin;
        private Button btntahmin;
        private Label lblKalanHak;
        private Label lblsonuc;
        private Panel panel1;
        private ListBox listBox1;
        private Button btngöster;
        private Label lbltutulan;
        private Button btngizle;
        private Label lbl1;
        private Label label1;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btntemizle;
        private Button btn3Haneli;
        private Button btn4Haneli;
        private Button btn5Haneli;
        private Panel panelHaneliSayı;
        private Label label2;
        private Button btnHaneDeğiştir;
        private Label lblbirinci;
        private Label lblikinci;
        private Label lbldördüncü;
        private Label lblÜçüncü;
        private Label lblbeşinci;
        private System.Windows.Forms.Timer timer1;
        private Panel panelSkor;
        private Label label3;
        private Label lblSure;
    }
}
