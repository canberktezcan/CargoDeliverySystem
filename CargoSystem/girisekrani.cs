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
    
    public partial class girisekrani : Form
    {
        public double enlemkurye;
        public double boylamkurye;
        public girisekrani()
        {
            InitializeComponent();
        }

        private void btn_kargoekle_Click_1(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("server=35.222.36.45;user id=root;database=deneme;Password=1234");
            string sorgu = "Select COUNT(*) from deneme.kargoBILGI WHERE kargoID='" + txt_kargoid.Text + "'";
            MySqlCommand komut1 = new MySqlCommand(sorgu, baglanti);
            baglanti.Open();
            int kayitSayisi = Convert.ToInt32(komut1.ExecuteScalar());

            baglanti.Close();

            if (kayitSayisi == 0)
            {


                baglanti.Open();
                String sorgu2 = "Insert into deneme.kargoBILGI(kargoID,teslim,lokasyon_enlem,lokasyon_boylam,musteri_id) Values ('" + txt_kargoid.Text + "','" + txt_teslim.Text + "','" + txt_enlem.Text + "','" + txt_boylam.Text + "','" + txt_musteriid.Text + "')";
                komut1 = new MySqlCommand(sorgu2, baglanti);
                komut1.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Basariyla oluşturuldu");


            }
            else
            {
                MessageBox.Show("Kargo ID Mevcut");
            }
        }

        private void btn_kargosil_Click_1(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("server=35.222.36.45;user id=root;database=deneme;Password=1234");
            String sorgu = "DELETE FROM deneme.kargoBILGI WHERE kargoID = '" + txt_kargoid.Text + "'";
            MySqlCommand komut = new MySqlCommand(sorgu, baglanti);
            baglanti.Open();

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kargo basariyla silindi");
        }

        private void btn_kargolistele_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("server=35.222.36.45;user id=root;database=deneme;Password=1234");
            string sorgu = "SELECT deneme.kargoBILGI.kargoID , deneme.kargoBILGI.teslim FROM deneme.kargoBILGI";

            baglanti.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(sorgu, baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            kargoTablo.DataSource = dt;
        }

        private void btn_haritagoster_Click_1(object sender, EventArgs e)
        {
            Form1 harita = new Form1();
            harita.kurye_enlem = enlemkurye;
            harita.kurye_boylam = boylamkurye;
            harita.Show();
        }
        public double Kurye_enlem()
        {
            return enlemkurye;
        }
        public double Kurye_boylam()
        {
            return boylamkurye;
        }

        private void btn_kuryeekle_Click(object sender, EventArgs e)
        {
            enlemkurye = Convert.ToDouble(txt_kuryeenlem.Text);
            boylamkurye = Convert.ToDouble(txt_kuryeboylam.Text);
        }

        private void btn_müsteriekle_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("server=35.222.36.45;user id=root;database=deneme;Password=1234");
            string sorgu = "Select COUNT(*) from deneme.musteri_bilgi WHERE musteriID='" + txt_musteriidekle.Text + "'";
            MySqlCommand komut1 = new MySqlCommand(sorgu, baglanti);
            baglanti.Open();
            int kayitSayisi = Convert.ToInt32(komut1.ExecuteScalar());

            baglanti.Close();

            if (kayitSayisi == 0)
            {


                baglanti.Open();
                String sorgu2 = "Insert into deneme.musteri_bilgi(musteriID,musteriADI) Values ('" + txt_musteriidekle.Text + "','" + txt_musteriadi.Text + "')";
                komut1 = new MySqlCommand(sorgu2, baglanti);
                komut1.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Kullanıcı oluşturuldu");


            }
            else
            {
                MessageBox.Show("Kullanıcı ID Mevcut");
            }
        }
    }
}
