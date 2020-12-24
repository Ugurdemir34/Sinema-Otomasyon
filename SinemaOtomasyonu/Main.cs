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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        OleDbConnection bag = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=sinema.accdb");
        OleDbCommand komut;
        public static string Salon = "";
        public static string Film_Adı = "";
        public static string Seans = "";
        void salongetir()
        {
            try
            {               
                bag.Open(); //bağlantıyı açtık
                komut = new OleDbCommand("SELECT * FROM FILMLER Where Film_Ad='"+Film_Adı+"'",bag);//secilen filmin salonuna eriştik.
                OleDbDataReader oku = komut.ExecuteReader();//sorgudan gelen veriyi okuduk
                if(oku.Read()) //eğer okunuyorsa yani veri varsa
                {
                    Salon=("Salon "+oku[4].ToString()); //filmin salon no sunu salon değişkenine ata (4 dedik cünkü veritabanında 4.sütun da
                }
                bag.Close();//bağlantıyı kapat
            }
            catch
            {
                MessageBox.Show("Bir Hata Meydana Geldi !");
            }
        }
        private void panel2_MouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).Size = new Size(140,190); //panellerden herhangi birine gelince boyutunu 140;190 yap
           
        }    
        int x = 0;
        private void panel5_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).Size = new Size(genislik, yukseklik); //mouse u panellerden ayrı tutunca eski haline getirdik yani küçültük
           
        }
        int yukseklik = 0;
        int genislik = 0;
        private void Main_Load(object sender, EventArgs e)
        {
            yukseklik = Celal_İle_Ceren.Height; //bütün panellerin boyutu aynı olduğu için herhangi bir panelin boyutunu aldım
            genislik = Celal_İle_Ceren.Width;  //yani burası siyah_giyen_adamlar.height ve width de olabilirdi
            timer1.Start(); //timer başlattım
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Left >= button2.Left) //yukardaki label button2 yi geçerse
            {
                x = panel1.Left - 200; 
                label1.Location = new Point(x, label1.Location.Y);  //label ı en başa al
            }
            else
            {
                label1.Location = new Point(x, label1.Location.Y); //değilse sağa doğru kaydırmaya devam et
                x += 7;
            }
        }     
        private void Siyah_Giyen_Adamlar_Click(object sender, EventArgs e)
        {
            Film_Adı=((Panel)sender).Name.Replace("_"," ");
            //Film adlarında "_" var mesala celal_ile_ceren, eğer "_" varsa onları yok ettik 
            salongetir();
            //secili filmin salonunu getirdik
            this.Width = 900; 
            //formun genişliğini arttırdık.
        }     
        private void button3_Click(object sender, EventArgs e)
        {
            Seans = comboBox2.SelectedItem.ToString();//combobox 2'de secileni seans değişkenine atadık
            Koltuk_Secme kl = new Koltuk_Secme(); //koltuk secme formunu açtık.
            kl.Show();
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult a = new DialogResult();
            a = MessageBox.Show("Çıkmak İstediğinize Emin Misiniz ?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(a == DialogResult.Yes)
            {
                Application.Exit();
            }   
            //Button 1 e tıklandığında kullanıcıya soru sordurduk eğer evet derse uygulamayı kapattırdık.
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;//button 2 ye basıldığında uygulamayı aşağı aldık.
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Bilet_Iptal ip = new Bilet_Iptal();//link label a tıklandığında bilet iptal formunu açtık
            ip.Show();
        }
        private void Sinister_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Sherlock_Holmes_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
