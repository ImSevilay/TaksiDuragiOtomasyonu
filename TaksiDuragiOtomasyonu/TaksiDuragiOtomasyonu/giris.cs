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
namespace TaksiDuragiOtomasyonu
{
    public partial class GİRİS : Form
    {
        public GİRİS()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U4RIC3I\\SQLEXPRESS;Initial Catalog=taksiDuragiOtomasyonu;Integrated Security=True");

        public static string gonderadkullaniciadi;
        public static string gonderad;
        public static string gonderadsoyad;
        public static string gondersoyad;
        public static string gondertel;
        bool durum;
        void karsilastir()
        {
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select * from kayit where tckimlik = @p1", baglanti);
            sorgu.Parameters.AddWithValue("@p1", tckimlik.Text);
            SqlDataReader dr = sorgu.ExecuteReader();
            if (dr.Read())
            {
                durum = false;
              
            }
            else
            {
                durum = true;
          
            }
            baglanti.Close();
        }
        private void adminGiris_Click(object sender, EventArgs e)
        {
            string kullanici = calisanK.Text;
            string sifre = calisanSifre.Text;
            SqlCommand komut = new SqlCommand("SELECT * FROM adminks where kullaniciadi='" + adminK.Text + "'AND sifre='" + adminSifre.Text + "'");
            baglanti.Open();
            komut.Connection = baglanti;
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");

                ADMIN f3 = new ADMIN();
                f3.tc = adminK.Text;
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();
        }
        private void calisanGiris_Click(object sender, EventArgs e)
        {
            string kullanici = calisanK.Text;
            string sifre = calisanSifre.Text;
            SqlCommand komut = new SqlCommand("SELECT * FROM calisanEkle where kullaniciAdi='" + calisanK.Text + "'AND sifre='" + calisanSifre.Text + "'");
            baglanti.Open();
            komut.Connection = baglanti;
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                GİRİS.gonderadsoyad = dr["ad"]+dr["soyad"].ToString();
                GİRİS.gonderad = dr["ad"].ToString();
                GİRİS.gondersoyad = dr["soyad"].ToString();
                CALİSAN f3 = new CALİSAN();
                f3.tc = calisanK.Text;
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();
        }
        private void musteriGiris_Click(object sender, EventArgs e)
        {
            string kullanici =musteriK.Text;
            string sifre = musteriSifre.Text;
            SqlCommand komut = new SqlCommand("SELECT * FROM kayit where kullaniciadi='" + musteriK.Text + "' AND parola='" + musteriSifre.Text + "'");
            baglanti.Open();
            komut.Connection = baglanti;
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Tebrikler! Başarılı bir şekilde giriş yaptınız.");
                GİRİS.gonderadkullaniciadi = dr["kullaniciadi"].ToString();
                GİRİS.gonderad = dr["ad"].ToString();
                GİRİS.gondersoyad = dr["soyad"].ToString();
                GİRİS.gondertel = dr["telefon"].ToString();
                MUSTERI f4 = new MUSTERI();
                f4.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adını ve şifrenizi kontrol ediniz.");
            }
            baglanti.Close();
           
        }
        private void kayit_ol_Click(object sender, EventArgs e)
        {
            karsilastir();
            if (durum == true)
            {
                baglanti.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM kayit", baglanti);
                adap.Fill(dt);
                SqlCommand komut = new SqlCommand("Insert into kayit(tckimlik,ad,soyad,telefon,eposta,kullaniciadi,parola) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komut.Parameters.AddWithValue("@p1", tckimlik.Text);
                komut.Parameters.AddWithValue("@p2", ad.Text);
                komut.Parameters.AddWithValue("@p3", soyad.Text);
                komut.Parameters.AddWithValue("@p4", telefon.Text);
                komut.Parameters.AddWithValue("@p5", eposta.Text);
                komut.Parameters.AddWithValue("@p6", kullaniciadi.Text);
                komut.Parameters.AddWithValue("@p7", parola.Text);
                if (String.IsNullOrEmpty(tckimlik.Text) || String.IsNullOrEmpty(ad.Text) || String.IsNullOrEmpty(soyad.Text) ||
                    String.IsNullOrEmpty(telefon.Text) || String.IsNullOrEmpty(eposta.Text) || String.IsNullOrEmpty(kullaniciadi.Text) || String.IsNullOrEmpty(parola.Text) || String.IsNullOrEmpty(txtGuvenlikKodu.Text))
                {
                    MessageBox.Show("Boş Alanları Doldurunuz");
                    baglanti.Close();
                }
                else if (parola.Text != parolatekrar.Text)
                {
                    MessageBox.Show("Parola Uyşmuyor");
                    baglanti.Close();
                }
                else if (txtGuvenlikKodu.Text != label19.Text)
                {
                    MessageBox.Show("Lütfen yukarıdaki güvenlik kodunu giriniz");
                    baglanti.Close();
                }
                else
                {
                    komut.Connection = baglanti;
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Eklendi");
                    tckimlik.Clear();
                    ad.Clear();
                    soyad.Clear();
                    telefon.Clear();
                    eposta.Clear();
                    kullaniciadi.Clear();
                    parola.Clear();
                    parolatekrar.Clear();
                    txtGuvenlikKodu.Clear();
                    label19.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Bu TC Kimlik Numarasına Ait Bir Kayıt Zaten Var");
            }
        }
        private void guvenlikKodu_Click(object sender, EventArgs e)
        {
            Random Rnd = new Random();
            StringBuilder StrBuild = new StringBuilder();
            for (int i = 0; i < 8; i++)
            {
                int ASCII = Rnd.Next(48,122);
                char Karakter = Convert.ToChar(ASCII);   
                StrBuild.Append(Karakter); 
            }
        label19.Text = StrBuild.ToString();
        }

        private void GİRİS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
