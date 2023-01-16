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
    public partial class KASADURMU : Form
    {
        public KASADURMU()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U4RIC3I\\SQLEXPRESS;Initial Catalog=taksiDuragiOtomasyonu;Integrated Security=True");
        public string tc;
        double km, gider,kazanc,taksimetre,gider_kazanc;
        public double kasa;
        private void button3_Click(object sender, EventArgs e)
        {
            ADMIN f2 = new ADMIN();
            f2.tc = tc;
            f2.Show();
            this.Hide();
        }

        public void doldur()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("select * from kasad", baglanti);
            adap.Fill(dt);
            dtkasa.DataSource = dt;
        }
        private void hesapla_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(giderler.Text) || String.IsNullOrEmpty(kmbilgisi.Text) || String.IsNullOrEmpty(cbplaka.Text) || String.IsNullOrEmpty(taksimetrefiyat.Text))
            {
                MessageBox.Show("BOŞ ALAN BIRAKMAYINIZ");
            }
            else
            {
                kazanc = Convert.ToInt32(giderler.Text);
                km = Convert.ToInt32(kmbilgisi.Text);
                taksimetre = Convert.ToInt32(taksimetrefiyat.Text);
                gider = Convert.ToInt32(giderler.Text);
                kazanc = taksimetre + (km * 7);
                gider_kazanc = kazanc - gider;
                kasa = gider + (gider_kazanc * 40) / 100;
                label10.Text = kazanc.ToString();
                label11.Text = gider_kazanc.ToString();
                label3.Text = kasa.ToString();
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into kasad(gelir,gider,toplamKazanc,km,kasayaGelenPara,tarih,plaka) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                komut.Parameters.AddWithValue("@p1", label11.Text.ToString());
                komut.Parameters.AddWithValue("@p2", giderler.Text);
                komut.Parameters.AddWithValue("@p3", label10.Text);
                komut.Parameters.AddWithValue("@p4", kmbilgisi.Text);
                komut.Parameters.AddWithValue("@p5", label3.Text);
                komut.Parameters.AddWithValue("@p6", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@p7", cbplaka.Text);
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();
                baglanti.Close();
                doldur();
            }
            giderler.Clear();
            kmbilgisi.Clear();
            cbplaka.Text = "";
            taksimetrefiyat.Clear();
        }
        public void kazancdoldur()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("select * from kasad", baglanti);
            adap.Fill(dt);
            dtkasa.DataSource = dt;
        }
        private void KASADURMU_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select aracplakasi from calisanEkle", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbplaka.Items.Add(dr[0]);
            }
            baglanti.Close();
            doldur();
            kazancdoldur();
            label10.Visible = false;
            label11.Visible = false;
            label3.Visible = false;
        }
        private void KASADURMU_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
