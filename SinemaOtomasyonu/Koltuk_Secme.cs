using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;
namespace SinemaOtomasyonu
{
    public partial class Koltuk_Secme : Form
    {
        public Koltuk_Secme()
        {
            InitializeComponent();
        }   
        int boskoltuk = 0;
        int dolukoltuk = 0;
        int Secilenkoltuksayisi = 0;
        int Ucret = 0;
        ArrayList koltuklar = new ArrayList();
        ArrayList bilet = new ArrayList();
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=sinema.accdb");
        OleDbCommand komut;
        int film_id = 0;
        int salon_id = 0;
        void biletgetir()
        {
            try
            {
                bag.Open();
                komut = new OleDbCommand("SELECT Koltuk_No FROM BILET WHERE Film_ID = "+film_id+" AND Seans = '"+Main.Seans+"'",bag);
                OleDbDataReader oku = komut.ExecuteReader();
                while(oku.Read())
                {
                    bilet.Add(oku[0].ToString());
                }
                dolukoltuk = bilet.Count;
                label20.Text = dolukoltuk + "";
                boskoltuk = 60 - dolukoltuk;
                label19.Text = boskoltuk + "";
                bag.Close();              
                foreach (Button item in groupBox1.Controls)
                {
                    for (int i = 0; i < bilet.Count; i++)
                    {
                        if (item.Name == bilet[i].ToString())
                        {
                            item.Enabled = false;
                            item.Cursor = Cursors.Hand;
                            item.BackColor = Color.DarkRed;
                        }
                    }
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata : "+hata.Message);
            }
        }
        void filmbilgiler()
        {
            bag.Open();
            komut = new OleDbCommand("SELECT * FROM FILMLER Where Film_Ad ='"+Main.Film_Adı+"'",bag);
            OleDbDataReader oku = komut.ExecuteReader();
            if(oku.Read())
            {
                lblpuan.Text = oku["Film_Puan"].ToString();
                lblyonetmen.Text = oku["Yonetmen"].ToString();
                film_id = Convert.ToInt32(oku["Film_ID"]);
                salon_id = Convert.ToInt32(oku["Salon_No"]);
            }
            bag.Close();
        }
        void kaydet()
        {
            try
            {
                bag.Open();              
                for (int i = 0; i < koltuklar.Count; i++)
                {
                    string koltukgecici = koltuklar[i].ToString();
                    komut = new OleDbCommand( "INSERT INTO BILET(Film_ID,Salon_ID,Tarih,Seans,Ad_Soyad,Koltuk_No,Ucret) VALUES (@Film_ID,@Salon_ID,@Tarih,@Seans,@Ad_Soyad,@Koltuk_No,@Ucret)",bag);
                    komut.Parameters.AddWithValue("@Film_ID", film_id);
                    komut.Parameters.AddWithValue("@Salon_ID", salon_id);
                    komut.Parameters.AddWithValue("@Tarih", DateTime.Now.ToShortDateString());
                    komut.Parameters.AddWithValue("@Seans", Main.Seans);
                    komut.Parameters.AddWithValue("@Ad_Soyad", txtad.Text);
                    komut.Parameters.AddWithValue("@Koltuk", koltukgecici);                
                    komut.Parameters.AddWithValue("@Ucret", Ucret);              
                    komut.ExecuteNonQuery();
                }            
                MessageBox.Show("Kayıt Başarılı !");
                bag.Close();
                biletgetir();              
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir Hata Meydana Geldi !\n Hata : " + hata.Message);
            }
        }
        private void Koltuk_Secme_Load(object sender, EventArgs e)
        {
            label31.Text = DateTime.Now.ToShortDateString();
            lblfilm.Text = Main.Film_Adı;
            lblsalon.Text = Main.Salon;
            lblseans.Text = Main.Seans;
            filmbilgiler();
            biletgetir();                   
        }
        private void F10_Click(object sender, EventArgs e)
        {                   
            if(((Button)sender).BackColor == Color.Yellow)
            {
                Secilenkoltuksayisi--;
                koltuklar.Remove(((Button)sender).Name);
                ((Button)sender).BackColor = SystemColors.HotTrack;
                txtkoltuk.Text = txtkoltuk.Text.Replace(((Button)sender).Name + ",", "");         
                if (radioButton1.Checked)              
                    Ucret -= 10;               
                else
                    Ucret -= 6;                          
            }
            else
            {
                Secilenkoltuksayisi++;
                koltuklar.Add(((Button)sender).Name);
                ((Button)sender).BackColor = Color.Yellow;
                txtkoltuk.Text +=   ((Button)sender).Name+",";
                if(radioButton1.Checked)
                    Ucret += 10;
                else
                    Ucret += 6;       
            }
            lblucret.Text = Ucret + "";
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Text == "Öğrenci")
            {
                Ucret = Secilenkoltuksayisi * 6;
                lblucret.Text = Ucret + "";
            }
            else
            {
                Ucret = Secilenkoltuksayisi * 10;
                lblucret.Text = Ucret + "";
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (txtad.Text.Trim() == "" || txtkoltuk.Text.Trim() == "")
            {
                MessageBox.Show("Bilgileri Doldurun!");
            }
            else
            {
                kaydet();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
