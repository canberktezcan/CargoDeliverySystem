using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GMapDeneme
{
    public partial class uyggiris : Form
    {
        public uyggiris()
        {
            InitializeComponent();
        }
      


        private void baglanti_Load(object sender, EventArgs e)
        {

        }


        private void btn_girisyap_Click_1(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("server=35.222.36.45;user id=root;database=deneme;Password=1234");
            MySqlCommand komut = new MySqlCommand("SELECT * FROM deneme.Kullanici where Kullanici_adi='" + txtkullaniciadi.Text + "' AND sifre='" + txtsifre.Text + "'", baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            MySqlDataReader login = komut.ExecuteReader(); //MySqlDataReader'ı, yolladığım komuttan dönen değerleri satır satır okuması için kullandım
            if (login.Read()) //Read metodu geriye bool türünde değer döndürür
            {
                MessageBox.Show("Giriş Doğrulandı.");
                girisekrani girisekrani = new girisekrani();
                this.Hide();
                girisekrani.Show();
                baglanti.Close();

            }
            else
            {
                MessageBox.Show("Giriş Başarısız.");
            }






        }

        private void btn_sifreguncelle_Click_1(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("server=35.222.36.45;user id=root;database=deneme;Password=1234");
            String sorgu = "UPDATE deneme.Kullanici SET sifre = '" + txtsifre.Text + "' WHERE Kullanici_adi = '" + txtkullaniciadi.Text + "'";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Şifre Değiştirildi");
        }

        private void btn_hesapolustur_Click_1(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("server=35.222.36.45;user id=root;database=deneme;Password=1234");
            string sorgu = "Select COUNT(*) from deneme.Kullanici WHERE Kullanici_adi='" + txtkullaniciadi.Text + "'";
            MySqlCommand komut1 = new MySqlCommand(sorgu, baglanti);
            baglanti.Open();
            int kayitSayisi = Convert.ToInt32(komut1.ExecuteScalar());

            baglanti.Close();

            if (kayitSayisi == 0)
            {

                MySqlCommand komut = new MySqlCommand("INSERT INTO deneme.Kullanici(Kullanici_adi,sifre) VALUES ('" + txtkullaniciadi.Text + "','" + txtsifre.Text + "')", baglanti);
                baglanti.Open();
                komut.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Basariyla oluşturuldu");


            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Mevcut");
            }


        }
    }
}
