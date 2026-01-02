using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace _4_Basamaklı_Sayı_Tahmin_Oyunu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToHexString(bytes);
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=DESKTOP-BTQRKRE;Initial Catalog=SayiTahminOyunuDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(
    "SELECT UserId FROM Users WHERE UserName = @u AND PasswordHash = @p",
    conn);

                cmd.Parameters.AddWithValue("@u", tbxUserName.Text);
                cmd.Parameters.AddWithValue("@p", HashPassword(tbxPassword.Text));

                conn.Open();
                object sonuc = cmd.ExecuteScalar();

                if (sonuc != null)
                {
                    int userId = Convert.ToInt32(sonuc);

                    Form1 oyunFormu = new Form1(userId);
                    oyunFormu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış!",
                        "Giriş Hatası",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }

        }

        private void btnKayıtol_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt Ekranına Yönlendiriliyor...");
            Form3 frm3 = new Form3();
            frm3.Show();
            this.Hide(); // Form2 kapanır
            
        }
    }
}
