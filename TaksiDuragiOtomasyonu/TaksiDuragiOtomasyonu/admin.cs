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
    public partial class ADMIN : Form
    {
        public ADMIN()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U4RIC3I\\SQLEXPRESS;Initial Catalog=taksiDuragiOtomasyonu;Integrated Security=True");
        public string tc;
        public string plakacek="";
        public string adcek="";
        public string soyadcek="";
        public string adrescek="";
        public string tarihcek="";
        public string telcek="";
        public string idcek = "";
        private void button2_Click(object sender, EventArgs e)
        {
            CALİSANEKLE f5 = new CALİSANEKLE();
            f5.Show();
            this.Hide();
        }
        private void cikis_Click(object sender, EventArgs e)
        {
            GİRİS f1 = new GİRİS();
            f1.Show();
            this.Hide();
        }
        private void calisanEkle_Click(object sender, EventArgs e)
        {
            CALİSANEKLE f5 = new CALİSANEKLE();
            f5.tc = tc;
            f5.Show();
            this.Hide();
        }
        public void doldur()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("select * FROM calisan_isKaydi", baglanti);
            adap.Fill(dt);
            dtgecmis.DataSource = dt;
        }
        public void aracsirasidoldur()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM arac_Sirasi WHERE onay='"+0+"'", baglanti);
            adap.Fill(dt);
            dtaracsirasi.DataSource = dt;
        }
        public void yeniIs()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT musteriid,ad,soyad,telefon,adres FROM musteriAracCagir where onay='"+0+"'", baglanti);
            adap.Fill(dt);
            dtbildirim.DataSource = dt;
        } 
        private void Form2_Load(object sender, EventArgs e)
        {
             baglanti.Open();
            SqlCommand komut = new SqlCommand("select ad+' '+soyad from adminks where kullaniciadi='"+tc+"'",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                adSoyad.Text = dr[0].ToString();
            }
            baglanti.Close();
            yeniIs();
            aracsirasidoldur();
            doldur();
        }
        private void aracDurumu_Click(object sender, EventArgs e)
        {
            ARACDURUMU f8= new ARACDURUMU();
            f8.tc = tc;
            f8.Show();
            this.Hide();
        }
        private void kasaDurumu_Click(object sender, EventArgs e)
        {
            KASADURMU f7 = new KASADURMU();
            f7.tc = tc;
            f7.Show();
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            KAYİT f9 = new KAYİT();
            f9.tc = tc;
            f9.Show();
            this.Hide();
        }
        private void ADMIN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from calisan_isKaydi where ad like '" + txtAdaGore.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgecmis.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            izinbildiriler f10 = new izinbildiriler();
            f10.tc = tc;
            f10.Show();
            this.Hide();
        }

        private void dtaracsirasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            plakacek = dtaracsirasi.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void dtbildirim_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idcek= dtbildirim.Rows[e.RowIndex].Cells[0].Value.ToString();
            adcek =dtbildirim.Rows[e.RowIndex].Cells[1].Value.ToString();
            soyadcek = dtbildirim.Rows[e.RowIndex].Cells[2].Value.ToString();
            adrescek = dtbildirim.Rows[e.RowIndex].Cells[3].Value.ToString();
            telcek = dtbildirim.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void aracgonder_Click(object sender, EventArgs e)
        {
            
            if (plakacek != "")
            {

                if (idcek != "")
                {
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("update musteriAracCagir set onay=@p1,kontrol=@p2,plaka=@p3 where musteriid=@p4");
                    komut.Parameters.AddWithValue("@p1", 1);
                    komut.Parameters.AddWithValue("@p2", "Yönlendiriliyor");
                    komut.Parameters.AddWithValue("@p3", plakacek);
                    komut.Parameters.AddWithValue("@p4", idcek);
                    komut.Connection = baglanti;
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    baglanti.Open();
                    SqlCommand komut1 = new SqlCommand("update arac_Sirasi set onay=@p1 where plaka='" + plakacek + "'", baglanti);
                    komut1.Parameters.AddWithValue("@p1", 1);
                    komut1.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Yönlendirilme gerçekleştirildi");
                    aracsirasidoldur();
                    doldur();
                    yeniIs();
                } else
                {
                    MessageBox.Show("TABLODAN MÜŞTERİ SEÇİN", "UYARI");
                }
            }
            else
            {
                MessageBox.Show("TABLODAN ARAÇ SEÇİN", "UYARİ");
            }
        }
    }
}
