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
    public partial class MUSTERI : Form
    {
        public MUSTERI()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U4RIC3I\\SQLEXPRESS;Initial Catalog=taksiDuragiOtomasyonu;Integrated Security=True");
        public string gondertel ="";
        private void button1_Click(object sender, EventArgs e)
        {
            GİRİS f1 = new GİRİS();
            f1.Show();
            this.Hide();
        }
        public string gad;
        public string gsoyad;
        private void button3_Click(object sender, EventArgs e)
        {

            GECMİS f2 = new GECMİS();
            this.Hide();
            f2.Show();
        }
        private void hesapsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into musteritalep(talep) values(@p1)", baglanti);
            komut.Parameters.AddWithValue("@p1", 1);
            komut.Connection = baglanti;
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Hesap Silme İşlemi Gerçekleşti");
        }
        private void MUSTERI_Load(object sender, EventArgs e)
        {
            label5.Text = GİRİS.gonderadkullaniciadi;
            musteriad.Text = GİRİS.gonderad;
            musterisoyad.Text = GİRİS.gondersoyad;
            musteritel.Text = GİRİS.gondertel;
            musteritel.Enabled = false;
            musteriad.Enabled = false;
            musterisoyad.Enabled = false;
        }
        private void aracCagir_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into musteriAracCagir(ad,soyad,telefon,adres,tarih,onay) values(@p1,@p2,@p3,@p4,@p5,@p6)",baglanti);
            komut.Parameters.AddWithValue("@p1", musteriad.Text);
            komut.Parameters.AddWithValue("@p2", musterisoyad.Text);
            komut.Parameters.AddWithValue("@p3", musteritel.Text);
            komut.Parameters.AddWithValue("@p4", musteriadres.Text);
            komut.Parameters.AddWithValue("@p5", musteridtime.Value);
            komut.Parameters.AddWithValue("@p6", 0);
            
            if (String.IsNullOrEmpty(musteriad.Text) || String.IsNullOrEmpty(musterisoyad.Text) || String.IsNullOrEmpty(musteritel.Text)||String.IsNullOrEmpty(musteriadres.Text))
            {
                MessageBox.Show("Boş Alanları Doldurunuz");
                baglanti.Close();
            }
            else
            {
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Araç Çağırma Talebiniz Alınmıştır. Teşekkür Ederiz");
                string metin = musteriadres.Text;
                metin.ToUpper();
                musteriad.Clear();
                musterisoyad.Clear();
                musteritel.Clear();
                musteriadres.Clear();
            }
        }
        private void MUSTERI_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
