using GMap.NET;
using GMap.NET.MapProviders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Collections.Generic;
using System.Drawing;
using MySql.Data.MySqlClient;
namespace GMapDeneme
{
    public partial class Form1 : Form
    {
       public double kurye_enlem;
        public double kurye_boylam;
        public double kurye_enlem2;
        public double kurye_boylam2;

        
        List<PointLatLng> _points;
        

        MySqlConnection baglanti = new MySqlConnection("server=35.222.36.45;user id=root;database=deneme;Password=1234");
        MySqlDataReader dr;
        MySqlCommand cmd;
        String kargoTeslimBilgisi = null;
        public Form1()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            GMapProviders.GoogleMap.ApiKey = @"AIzaSyARKk5Ksa_Plecxd6YGVjaV2FcmoCbthKY";
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            map.CacheLocation = @"cache";
            map.DragButton = MouseButtons.Left;
            map.MapProvider = GMapProviders.GoogleMap;
            map.ShowCenter = false;
            
            map.MaxZoom = 100;
            map.Zoom = 10;


            //harita yüklenmesi kargoların markerları
            if (baglanti.State == ConnectionState.Closed)
                baglanti.Open();
            
            cmd = new MySqlCommand("Select deneme.kargoBILGI.lokasyon_enlem,deneme.kargoBILGI.lokasyon_boylam from deneme.kargoBILGI", baglanti);
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {

                 double lat = (double)dr["lokasyon_enlem"];
                double lng = (double)dr["lokasyon_boylam"];              
                map.Position = new PointLatLng(lat, lng);

                var markers = new GMapOverlay("markers");
                var marker = new GMarkerGoogle(new PointLatLng(lat, lng), GMarkerGoogleType.blue);
                markers.Markers.Add(marker);
                map.Overlays.Add(markers);
              
                _points.Add(new PointLatLng(lat, lng));

            }

            dr.Close();


            if (kurye_enlem != 0 && kurye_boylam != 0) { 

                map.Position = new PointLatLng(kurye_enlem, kurye_boylam);

            Bitmap kuryeMarker = (Bitmap)Image.FromFile("image/motorkuryeyeni.jpg");
               var  markersk = new GMapOverlay("markersk");
                var markerk = new GMarkerGoogle(new PointLatLng(kurye_enlem, kurye_boylam), kuryeMarker);
            markersk.Markers.Add(markerk);
            map.Overlays.Add(markersk);
                _points.Add(new PointLatLng(kurye_enlem, kurye_boylam));
            }


        }
       
        private void haritayenile()
        {
            map.Zoom++;
            map.Zoom--;
        }
        private void btnGetRouteInfo_Click(object sender, EventArgs e)
        {
         

            //OLAN LİSTEYİ DOLAŞMA enkisayı dolaşçaksın burda

            int i=0 ;
            for (i=0; i <_points.Count-1; i++)
            {
            var route = GoogleMapProvider.Instance
                .GetRoute(_points[i], _points[i+1], false, false, 14);
                var r = new GMapRoute(route.Points, "My Route") {

                    Stroke = new Pen(Color.Red, 5)
                };           
                var routes = new GMapOverlay("routes");
                routes.Routes.Add(r);
                map.Overlays.Add(routes);
            }
           haritayenile();
            
        }

       
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            MySqlConnection baglanti = new MySqlConnection("server=35.222.36.45;user id=root;database=deneme;Password=1234");
            string sorgu = "Select COUNT(*) from deneme.kargoBILGI WHERE kargoID='" + txt_KargoID.Text + "'";
            MySqlCommand komut1 = new MySqlCommand(sorgu, baglanti);
            baglanti.Open();
            int kayitSayisi = Convert.ToInt32(komut1.ExecuteScalar());

            baglanti.Close();

            if (kayitSayisi == 0)
            {


                baglanti.Open();
                String sorgu2 = "Insert into deneme.kargoBILGI(kargoID,teslim,lokasyon_enlem,lokasyon_boylam,musteri_id) Values ('" + txt_KargoID.Text + "','" + txt_teslim.Text + "','" + label_enlem.Text + "','" + label_boylam.Text + "','" + txt_musteri_id.Text + "')";
                komut1 = new MySqlCommand(sorgu2, baglanti);
                komut1.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Basariyla oluşturuldu");

                double lat = Convert.ToDouble(label_enlem.Text);
                double lng = Convert.ToDouble(label_boylam.Text);
                map.Position = new PointLatLng(lat, lng);

                var markers = new GMapOverlay("markers");
                var marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(label_enlem.Text), Convert.ToDouble(label_boylam.Text)), GMarkerGoogleType.blue);
                markers.Markers.Add(marker);
                map.Overlays.Add(markers);

                _points.Add(new PointLatLng(Convert.ToDouble(label_enlem.Text),
                    Convert.ToDouble(label_boylam.Text)));

            }
            else
            {
                MessageBox.Show("Kargo ID Mevcut");
            }
                
        }

        private void btn_remote_Click(object sender, EventArgs e)
        {
            if(map.Overlays.Count > 0)
            {
                map.Overlays.RemoveAt((map.Overlays.Count)-1);
                map.Refresh();
            }
        }

        private void map_Load(object sender, EventArgs e)
        {

        }

        private void map_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var point = map.FromLocalToLatLng(e.X, e.Y);
                double lat = point.Lat;
                double lng = point.Lng;

                label_enlem.Text = lat + "";
                label_boylam.Text = lng + "";


            }
        }

        private void btn_kuryekaydet_Click(object sender, EventArgs e)
        {
             kurye_enlem2 = Convert.ToDouble(label_enlem.Text);
             kurye_boylam2 = Convert.ToDouble(label_boylam.Text);
            map.Position = new PointLatLng(kurye_enlem2, kurye_boylam2);

            Bitmap kuryeMarker = (Bitmap)Image.FromFile("image/motorkuryeyeni.jpg");
            var markers = new GMapOverlay("markers");
            var marker = new GMarkerGoogle(new PointLatLng(Convert.ToDouble(label_enlem.Text), Convert.ToDouble(label_boylam.Text)), kuryeMarker);
            markers.Markers.Add(marker);
            map.Overlays.Add(markers);
          
            _points.Add(new PointLatLng((kurye_enlem2),
               Convert.ToDouble(kurye_boylam2)));
           
        }
    }

}
