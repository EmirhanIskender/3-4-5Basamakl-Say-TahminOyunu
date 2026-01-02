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
using System.Configuration;
using System.Security.Cryptography;

namespace _4_Basamaklı_Sayı_Tahmin_Oyunu
{
    public partial class Form3 : Form
    {
        string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                return Convert.ToHexString(bytes);
            }
        }
        public Form3()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string connStr = @"Data Source=DESKTOP-BTQRKRE;Initial Catalog=SayiTahminOyunuDB;Integrated Security=True";

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                SqlCommand cmd = new SqlCommand(@"INSERT INTO Users (UserName, PasswordHash, Ad, Soyad, Telefon, Email)VALUES (@u, @p, @a, @s, @t, @e)", conn);

                cmd.Parameters.AddWithValue("@u", tbxUserName.Text);
                cmd.Parameters.AddWithValue("@p", HashPassword(tbxPasswordHash.Text));
                cmd.Parameters.AddWithValue("@a", tbxAd.Text);
                cmd.Parameters.AddWithValue("@s", tbxSoyad.Text);
                cmd.Parameters.AddWithValue("@t", tbxTelefon.Text);
                cmd.Parameters.AddWithValue("@e", tbxEmail.Text);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı başarıyla eklendi");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata oluştu: " + ex.Message);
                }
            }
            MessageBox.Show("Giriş Ekranına Yönlendiriliyor...");
            Form2 frm2 = new Form2();
            frm2.Show();
            this.Close(); // Form3 kapanır

        }
    }
}
