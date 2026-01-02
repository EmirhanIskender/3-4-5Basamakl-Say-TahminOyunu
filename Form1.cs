using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data.SqlClient;
using System.Linq;

namespace _4_Basamaklı_Sayı_Tahmin_Oyunu
{
    public partial class Form1 : Form
    {
        Random rnd;
        int aktifUserId;
        public Form1(int userId)
        {
            InitializeComponent();
            rnd = new Random();
            aktifUserId = userId;
        }


        string rastgeleSayi;        // Üretilen sayı
        int kalanHak;
        int basamaksayısı;
        int bas1, bas2;

        string connStr = @"Data Source=DESKTOP-BTQRKRE;Initial Catalog=SayiTahminOyunuDB;Integrated Security=True";

        private void btnbaslat_Click(object sender, EventArgs e)
        {
            tbxtahmin.Enabled = true;
            btntahmin.Enabled = true;
            panelSkor.Visible = true;

            
            timer1.Start();
            saniye = 0;
            lblSure.Text = "0";

            int number;


            while (true)
            {
                number = rnd.Next(bas1, bas2); // 3,4,5 basamaklı sayı üret
                string numStr = number.ToString();

                basamaksayısı = number.ToString().Length; //Basamak sayısı

                // Rakamların birbirinden farklı olup olmadığını kontrol et
                if (numStr.Distinct().Count() == basamaksayısı)
                    break;
            }

            // Label'a yazdır
            lbltutulan.Text = "Rastgele sayı: " + number.ToString();

            //atamalar

            
            lblKalanHak.Text = "Kalan Hak : " + kalanHak.ToString();
            rastgeleSayi = number.ToString();

            tbxtahmin.Clear();
            lblsonuc.Text = "Tahminizi Girin !";
            listBox1.Items.Clear();
            lbl1.Text = "";

            panel1.Visible = true;

        }

        private void btngöster_Click(object sender, EventArgs e)
        {
            lbltutulan.Visible = true;
            btngöster.Visible = false;
            btngizle.Visible = true;
        }

        private void btngizle_Click(object sender, EventArgs e)
        {
            lbltutulan.Visible = false;
            btngöster.Visible = true;
            btngizle.Visible = false;
        }

        private void btntahmin_Click(object sender, EventArgs e)
        {

            string input = tbxtahmin.Text.Trim();

            tbxtahmin.Focus();

            // Boş mu kontrolü
            if (string.IsNullOrEmpty(input))
            {
                lblsonuc.Text = "Lütfen bir sayı girin.";
                return;
            }

            // Tüm karakterler rakam mı kontrolü
            if (!input.All(char.IsDigit))
            {
                lblsonuc.Text = "Sadece rakam (0-9) giriniz.";
                return;
            }

            // Başta 0 olmaması kontrolü
            if (input.Length > 1 && input[0] == '0')
            {
                lblsonuc.Text = "Başta 0 olamaz (örnek: 0123 geçersiz).";
                return;
            }

            // Basamak sayısı kontrolü (tam 3,4,5 olmalı)
            if (input.Length != basamaksayısı)
            {
                lblsonuc.Text = $"Girdiğiniz sayı {input.Length} basamaklı,{basamaksayısı} basamaklı olması gerekiyor!";
                return;
            }

            // Rakamların birbirinden farklı olup olmadığını kontrol et
            if (input.Distinct().Count() != basamaksayısı)
            {
                lblsonuc.Text = "Rakamlar birbirinden farklı değil!";
                return;
            }

            // Tüm şartlar sağlandıysa (güvenli şekilde int'e çeviriyoruz)

            lblsonuc.Text = $"{input} → {basamaksayısı} basamaklı ve rakamları birbirinden farklı.";

            string tahmin = input.ToString();


            // Doğru/Yanlış Rakam Analizi
            int dogruYerDogruRakam = 0;
            int dogruRakamYanlisYer = 0;

            for (int i = 0; i < basamaksayısı; i++)
            {
                if (tahmin.ToString()[i] == rastgeleSayi[i])
                    dogruYerDogruRakam++;
                else if (rastgeleSayi.Contains(tahmin.ToString()[i]))
                    dogruRakamYanlisYer++;
            }

            //Kalan hak azalt
            kalanHak--;
            lblKalanHak.Text = "Kalan Hak: " + kalanHak;

            //lbl1’e sonucu yaz
            lbl1.Text = $"{dogruYerDogruRakam} rakamın yeri doğru, {dogruRakamYanlisYer} rakam doğru yeri yanlış.";

            //ListBox’a tahmini ve sonucu ekle
            listBox1.Items.Add($"Tahmin: {tahmin} ➜ {dogruYerDogruRakam} rakamın yeri doğru, {dogruRakamYanlisYer} rakam doğru yeri yanlış.");

            //Doğru tahmin kontrolü
            if (dogruYerDogruRakam == basamaksayısı)
            {
                lbl1.Text = $"{rastgeleSayi} sayısını doğru tahmin ettiniz!";
                lblsonuc.Text = "Tebrikler";
                btntahmin.Enabled = false;
                timer1.Stop();

                

                int score = (kalanHak * 100) / (saniye == 0 ? 1 : saniye);
                if (score < 0) score = 0;   // PUAN HESABI
                SkorKaydet(aktifUserId, score); // İŞTE BURASI

                Top5Yukle_LabelIle();
                return;

            }

            //Hak bitti mi?
            if (kalanHak == 0)
            {
                lblsonuc.Text = $"Hakkınız kalmadı! Doğru sayı: {rastgeleSayi}";
                btntahmin.Enabled = false;
            }
            tbxtahmin.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tbxtahmin.Enabled = false;
            btntahmin.Enabled = false;
            Top5Yukle_LabelIle();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxtahmin.Text = tbxtahmin.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxtahmin.Text = tbxtahmin.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxtahmin.Text = tbxtahmin.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxtahmin.Text = tbxtahmin.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxtahmin.Text = tbxtahmin.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxtahmin.Text = tbxtahmin.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxtahmin.Text = tbxtahmin.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxtahmin.Text = tbxtahmin.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxtahmin.Text = tbxtahmin.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            tbxtahmin.Text = tbxtahmin.Text + "0";
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            tbxtahmin.Clear();
        }

        private void btn3Haneli_Click(object sender, EventArgs e)
        {
            bas1 = 100;
            bas2 = 1000;
            label2.Text = "3 Haneli sayı giriniz";
            btnbaslat.Visible = true;
            btnHaneDeğiştir.Visible = true;
            panelHaneliSayı.Visible = false;
            kalanHak = 6;
        }

        private void btn4Haneli_Click(object sender, EventArgs e)
        {
            bas1 = 1000;
            bas2 = 10000;
            label2.Text = "4 Haneli sayı giriniz";
            btnbaslat.Visible = true;
            btnHaneDeğiştir.Visible = true;
            panelHaneliSayı.Visible = false;
            kalanHak = 8;
        }

        private void btn5Haneli_Click(object sender, EventArgs e)
        {
            bas1 = 10000;
            bas2 = 100000;
            label2.Text = "5 Haneli sayı giriniz";
            btnbaslat.Visible = true;
            btnHaneDeğiştir.Visible = true;
            panelHaneliSayı.Visible = false;
            kalanHak = 10;
        }

        private void btnHaneDeğiştir_Click(object sender, EventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Hane sayısını değiştirmek istiyor musunuz?", "Uyarı: Eski oyun kapanacak", MessageBoxButtons.YesNo);

            if (sonuc == DialogResult.Yes)
            {
                panelHaneliSayı.Visible = true;
                panel1.Visible = false;
                btnbaslat.Visible = false;
                btnHaneDeğiştir.Visible = false;
            }
        }

        void Top5Yukle_LabelIle()
        {
            lblbirinci.Text = "1.";
            lblikinci.Text = "2.";
            lblÜçüncü.Text = "3.";
            lbldördüncü.Text = "4.";
            lblbeşinci.Text = "5.";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(@"SELECT TOP 5 U.UserName, S.Puan FROM GameScores S JOIN Users U ON U.UserId = S.UserId ORDER BY S.Puan DESC", conn);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                int sira = 1;
                while (dr.Read())
                {
                    string yazi = $"{sira}. {dr["UserName"]} - {dr["Puan"]}";

                    if (sira == 1) lblbirinci.Text = yazi;
                    else if (sira == 2) lblikinci.Text = yazi;
                    else if (sira == 3) lblÜçüncü.Text = yazi;
                    else if (sira == 4) lbldördüncü.Text = yazi;
                    else if (sira == 5) lblbeşinci.Text = yazi;

                    sira++;
                }
            }
        }
        void SkorKaydet(int userId, int score)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(
    "INSERT INTO GameScores (UserId, Puan) VALUES (@uid, @puan)", conn);

                cmd.Parameters.AddWithValue("@uid", userId);
                cmd.Parameters.AddWithValue("@puan", score);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        private void lblbeşinci_Click(object sender, EventArgs e)
        {

        }

        int saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            lblSure.Text=saniye.ToString();
        }
    }
}
