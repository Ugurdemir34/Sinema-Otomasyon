using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace SinemaOtomasyonu
{
    public partial class Bilet_Iptal : Form
    {
        public Bilet_Iptal()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=sinema.accdb");//VERİTABANININ ISMINI BELİRTTİK
        OleDbCommand komut; //SORGU YAZIP VERİ ÇEKMEK İÇİN OLEDBCOMMAND TİPİNDE KOMUT  OLUŞTURDUK.
        DataTable tablo = new DataTable(); //SANAL BİR TABLO OLUŞTURDUK ÇÜNKÜ DATAGRIDVIEW E BU TABLODAN VERİ YAZDIRCAZ
        void kontrol() //KONTROL ADINDA METOD OLUŞTURUYORUZ. BAĞLANTIYI KONTROL EDEBİLMEK İÇİN
        {
            if (bag.State == ConnectionState.Open) //EĞER BAĞLANTI AÇIKSA
            {
                bag.Close(); //KAPAT
            }
            else                                  //EĞER BAĞLANTI KAPALIYSA
            {
                bag.Open(); // AÇ
            }
        }
        void biletgetir()//BİLET GETİR ADINDA METOD OLUŞTURUYORUZ. EKLENEN VERİLERİ DATAGRIDVIEW DE GOSTERMEK İÇİN
        {         
            try // İÇİNDE Kİ KODLARI DENER EĞER BİR SIKINTI ÇIKARSA HEMEN CATCH BLOGUNA GİDER
            {
                kontrol();//BAĞLANTININ AÇIK OLUP OLMADIĞINI KONTROL ETTİRDİK
                tablo.Clear();//VERİLER ARD ARDA YAZILMASIN DİYE TABLOYU TEMİZLEDİK
                OleDbDataAdapter adp = new OleDbDataAdapter("SELECT * FROM BILET",bag); //BILETLER TABLOSUNA bag DEĞİŞKENİ SAYESİNDE BAĞLANDIK
                adp.Fill(tablo); //BAĞLANDIKTAN SONRA SORGUDAN ELDE EDİLEN VERİLERİ TABLOYA DOLDURDUK
                dataGridView1.DataSource = tablo;//DATAGRIDVIEW İN VERİ KAYNAĞINI TABLO OLARAK BELİRTTİK YANİ ÇEKİLEN VERİLERİ TABLOYA YAZDIRDIK
                kontrol();    //TEKRAR  BAĞLANTIYI KONTROL ETTİRDİK.          
            }
            catch (Exception hata)//HATA OLDUĞUNDA HATAYI YAZDIRIR.
            {
                MessageBox.Show("Hata : " + hata.Message);
            }           
        }
        void sil()
        {
            try // İÇİNDE Kİ KODLARI DENER EĞER BİR SIKINTI ÇIKARSA HEMEN CATCH BLOGUNA GİDER
            {
                kontrol();//BAĞLANTININ AÇIK OLUP OLMADIĞINI KONTROL ETTİRDİK
                if(textBox1.Text=="")//ID SEÇİLMEDİYSE HATA BELİRTTİK
                {
                    MessageBox.Show("ID SEÇİNİZ!");
                }
                else
                {
                    DialogResult a = new DialogResult();//KULLANICIYA SORU SORMAK İÇİN DİALOG RESULT OLUŞTURDUK
                    a = MessageBox.Show("Silmek İstediğinize Emin Misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);//SORUYU BELİRTTİK
                    if (a == DialogResult.Yes)//EĞER CEVAP EVETSE
                    {
                        komut = new OleDbCommand("DELETE FROM BILET Where Bilet_ID =" + textBox1.Text + "", bag);
                        //BILETLER TABLOSUNDAN BILET_ID'si TEXTBOX1.TEXT'TEKİ DEĞER OLAN DEĞERİ SİL DEDİK, YANİ TEXTBOX1.TEXK 3 İSE ID Sİ 3 OLANI SİLİCEK
                        komut.ExecuteNonQuery();//KOMUTU YERİNE GETİRDİK YANİ SİLME İŞLEMİNİ YAPTIRDIK
                        MessageBox.Show("Silindi!");//KULLANICIYA MESAJ VERDİRDİK.
                        biletgetir();//SİLİNDİĞİ BELLİ OLSUN DİYE TEKRAR DATAGRİDVIEWDE GOSTERDİK
                    }
                    kontrol();//BAĞLANTIYI KONTROL ETTTIRDIK
                }
               
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata : " + hata.Message);
            }
        }
        private void Bilet_Iptal_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sinemaDataSet.BILET' table. You can move, or remove it, as needed.
            this.bILETTableAdapter.Fill(this.sinemaDataSet.BILET);
            biletgetir();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            sil();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int secili = dataGridView1.SelectedCells[0].RowIndex;
            textBox1.Text = dataGridView1.Rows[secili].Cells[0].Value.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
