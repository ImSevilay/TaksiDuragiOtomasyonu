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
    public partial class GECMİS : Form
    {

        public GECMİS()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U4RIC3I\\SQLEXPRESS;Initial Catalog=taksiDuragiOtomasyonu;Integrated Security=True");

        private void geri_Click(object sender, EventArgs e)
        {
            MUSTERI f1 = new MUSTERI();
            
            f1.Show();
            this.Hide();
        }
        public void doldur()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("select * from musteriAracCagir where telefon='" + musteritel.Text + "'", baglanti);
            adap.Fill(dt);
            musterigecmis.DataSource = dt;
        }
        private void cikis_Click(object sender, EventArgs e)
        {
            GİRİS f2 = new GİRİS();
            f2.Show();
            this.Hide();
        }
        private void GECMİS_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void GECMİS_Load(object sender, EventArgs e)
        {
            musteritel.Text = GİRİS.gondertel;
            doldur();
        }

        private void iptalEt_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM musteriAracCagir WHERE musteriid=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtsira.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt silindi");
            doldur();
        }
    }
}
