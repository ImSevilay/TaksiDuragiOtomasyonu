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
    public partial class CALİSANEKLE : Form
    {
        public CALİSANEKLE()
        {
            InitializeComponent();
        }
       public SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U4RIC3I\\SQLEXPRESS;Initial Catalog=taksiDuragiOtomasyonu;Integrated Security=True");
        public string tc;
        public void doldur()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM calisanEkle", baglanti);
            adap.Fill(dt);
            calisanekledt.DataSource = dt;  
        }
        bool durum;
        void karsilastir()
        {
            baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select * from calisanEkle where tckimlik = @p1", baglanti);
            sorgu.Parameters.AddWithValue("@p1",tckimlik.Text);
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
        private void button3_Click(object sender, EventArgs e)
        {
            ADMIN f2 = new ADMIN();
            f2.tc = tc;
            f2.Show();
            this.Hide();
        }
        private void kullaniciAdi_Click(object sender, EventArgs e)
        {
            kullaniciAdi.Text = tckimlik.Text;
            kullaniciAdi.Enabled = false;
        }
        private void tckimlik_Click(object sender, EventArgs e)
        {
            kullaniciAdi.Text = tckimlik.Text;
            kullaniciAdi.Enabled = true;
            kullaniciAdi.Text = "";
        }
        private void calisanEkle_Click(object sender, EventArgs e)
        {
            string starih = tarih.Value.ToString();
            karsilastir();
            if (durum == true)
            {
                baglanti.Open();
                string cinsiyet = "";
                if (erkek.Checked)
                {
                    cinsiyet = erkek.Text;
                }
                else if(kadin.Checked)
                {
                    cinsiyet = kadin.Text;
                }          
                DataTable dt = new DataTable();
                SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM calisanEkle", baglanti);
                adap.Fill(dt);
                SqlCommand komut = new SqlCommand("insert into calisanEkle(tckimlik,ad,soyad,telefon,eposta,cinsiyet,ehliyetSinifi,saglikDurumu,dogumTarihi,kullaniciAdi,sifre,aracplakasi,tarih) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)", baglanti);    
                komut.Parameters.AddWithValue("@p1", tckimlik.Text);
                komut.Parameters.AddWithValue("@p2", ad.Text);
                komut.Parameters.AddWithValue("@p3", soyad.Text);
                komut.Parameters.AddWithValue("@p4", telefon.Text);
                komut.Parameters.AddWithValue("@p5", eposta.Text);
                komut.Parameters.AddWithValue("@p6", cinsiyet);
                komut.Parameters.AddWithValue("@p7", ehliyet.Text);
                komut.Parameters.AddWithValue("@p8", saglikdurumu.Text);
                komut.Parameters.AddWithValue("@p9", dogumTarihi.Text);
                komut.Parameters.AddWithValue("@p10", kullaniciAdi.Text);
                komut.Parameters.AddWithValue("@p11", sifre.Text);
                komut.Parameters.AddWithValue("@p12", plaka.Text);
                komut.Parameters.AddWithValue("@p13", tarih.Value);
                if (String.IsNullOrEmpty(tckimlik.Text) || String.IsNullOrEmpty(ad.Text) || String.IsNullOrEmpty(soyad.Text) ||
                    String.IsNullOrEmpty(telefon.Text) || String.IsNullOrEmpty(eposta.Text) || cinsiyet == "" || String.IsNullOrEmpty(ehliyet.Text) ||
                    String.IsNullOrEmpty(saglikdurumu.Text) || String.IsNullOrEmpty(dogumTarihi.Text)||String.IsNullOrEmpty(kullaniciAdi.Text)||
                    String.IsNullOrEmpty(sifre.Text)||String.IsNullOrEmpty(plaka.Text)||String.IsNullOrEmpty(starih))
                {
                    MessageBox.Show("Boş Alanları Doldurunuz");
                    baglanti.Close();
                }
                else{
                    komut.Connection = baglanti;
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Eklendi");
                    doldur();
                }
            }
            else
            {
                MessageBox.Show("Bu TC Kimlik Numarasına Ait Bir Kayıt Zaten Var");
            }
            baglanti.Open();
            DataTable dtt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM arac_Sirasi", baglanti);
            adapt.Fill(dtt);
            SqlCommand sql = new SqlCommand("insert into arac_Sirasi(plaka,onay) values(@plaka,@onay) ", baglanti);
            sql.Parameters.AddWithValue("@plaka", plaka.Text);
            sql.Parameters.AddWithValue("@onay", 0);
            sql.Connection = baglanti;
            sql.ExecuteNonQuery();
            baglanti.Close();
        }
        private void CALİSANEKLE_Load(object sender, EventArgs e)
        {
            string[] ehliyetdizi = {"B","BE", "C1", "C1E", "C", "CE", "D1", "D1E", "D", "DE" };
            ehliyet.Items.AddRange(ehliyetdizi);
            string[] saglik = {"Sağlık raporu yok"};
            saglikdurumu.Items.AddRange(saglik);
            txtSiraNo.Visible = false;
            txtaracsirasi.Visible = false;
            doldur();
        }
        private void temizle_Click(object sender, EventArgs e)
        {
            txtSiraNo.Clear();
            tckimlik.Clear();
            ad.Clear();
            soyad.Clear();
            telefon.Clear();
            eposta.Clear();
            erkek.Checked = false;
            kadin.Checked = false;
            ehliyet.Text="";
            saglikdurumu.SelectedIndex = -1;
            dogumTarihi.Clear();
            tckimlik.Focus();
            kullaniciAdi.Clear();
            sifre.Clear();
            plaka.Clear();
            kullaniciAdi.Enabled = true;
        }
        private void guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string cinsiyet = "";
            if (erkek.Checked)
            {
                cinsiyet = erkek.Text;
            }
            else if (kadin.Checked)
            {
                cinsiyet = kadin.Text;
            }
            SqlCommand komut = new SqlCommand("Update calisanEkle set tckimlik=@p1,ad=@p2,soyad=@p3,telefon=@p4,eposta=@p5,cinsiyet=@p6, ehliyetSinifi=@p7,saglikDurumu=@p8,dogumTarihi=@p9,kullaniciAdi=@p10,sifre=@p11,aracplakasi=@p13,tarih=@p14 where calisanid=@p12", baglanti);
            komut.Parameters.AddWithValue("@p1", tckimlik.Text);
            komut.Parameters.AddWithValue("@p2", ad.Text);
            komut.Parameters.AddWithValue("@p3", soyad.Text);
            komut.Parameters.AddWithValue("@p4", telefon.Text);
            komut.Parameters.AddWithValue("@p5", eposta.Text);
            komut.Parameters.AddWithValue("@p6",cinsiyet);
            komut.Parameters.AddWithValue("@p7", ehliyet.Text);
            komut.Parameters.AddWithValue("@p8", saglikdurumu.Text);
            komut.Parameters.AddWithValue("@p9", dogumTarihi.Text);
            komut.Parameters.AddWithValue("@p10", kullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p11",sifre.Text);
            komut.Parameters.AddWithValue("@p12", txtSiraNo.Text);
            komut.Parameters.AddWithValue("@p13", plaka.Text);
            komut.Parameters.AddWithValue("@p14", tarih.Value);     
            if(tckimlik.Text!=kullaniciAdi.Text)
            {
                MessageBox.Show("TC kimlik numarası ve kullanıcı adı uyuşmuyor");
                baglanti.Close();
            }
            else {
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt başarıyla güncellendi");
                doldur();
            }
            baglanti.Open();
            DataTable dtt = new DataTable();
            SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM arac_Sirasi", baglanti);
            adapt.Fill(dtt);
            SqlCommand sql = new SqlCommand("update arac_Sirasi set plaka=@plaka where aracid=@aracid", baglanti);
            sql.Parameters.AddWithValue("@plaka", plaka.Text);
            sql.Parameters.AddWithValue("@aracid", txtaracsirasi.Text);
            sql.Connection = baglanti;
            sql.ExecuteNonQuery();
            baglanti.Close();     
        }
        private void calisanekledt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string cinsiyet = "";
            int secilen = calisanekledt.SelectedCells[0].RowIndex;
            txtSiraNo.Text = calisanekledt.Rows[secilen].Cells[0].Value.ToString();
            txtaracsirasi.Text = calisanekledt.Rows[secilen].Cells[0].Value.ToString();
            tckimlik.Text = calisanekledt.Rows[secilen].Cells[1].Value.ToString();
            ad.Text = calisanekledt.Rows[secilen].Cells[2].Value.ToString();
            soyad.Text = calisanekledt.Rows[secilen].Cells[3].Value.ToString();
            telefon.Text = calisanekledt.Rows[secilen].Cells[4].Value.ToString();
            eposta.Text = calisanekledt.Rows[secilen].Cells[5].Value.ToString();
            cinsiyet = calisanekledt.Rows[secilen].Cells[6].Value.ToString();
            ehliyet.Text = calisanekledt.Rows[secilen].Cells[7].Value.ToString();
            saglikdurumu.Text = calisanekledt.Rows[secilen].Cells[8].Value.ToString();
            dogumTarihi.Text= calisanekledt.Rows[secilen].Cells[9].Value.ToString();
            kullaniciAdi.Text = calisanekledt.Rows[secilen].Cells[10].Value.ToString();
            sifre.Text = calisanekledt.Rows[secilen].Cells[11].Value.ToString();
            plaka.Text = calisanekledt.Rows[secilen].Cells[12].Value.ToString();
            tarih.Text = calisanekledt.Rows[secilen].Cells[13].Value.ToString();
            if (cinsiyet == "Kadın")
            {
                kadin.Checked = true;
            }
            else if (cinsiyet == "Erkek")
            {
                erkek.Checked = true;
            }
        }
        private void sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM calisanEkle WHERE calisanid=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtSiraNo.Text);
            komut.ExecuteNonQuery();
            SqlCommand sql = new SqlCommand("DELETE FROM arac_Sirasi WHERE plaka=@p2", baglanti);
            sql.Parameters.AddWithValue("@p2", plaka.Text);
            sql.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt silindi");
            doldur();
        }
        private void sifre_Click(object sender, EventArgs e)
        {
            Random Rnd = new Random();
            StringBuilder StrBuild = new StringBuilder();
           
                for (int j = 0; j < 3; j++)
                {
                    int ASCII2 = Rnd.Next(65, 90);
                    char Karakter2 = Convert.ToChar(ASCII2);
                    StrBuild.Append(Karakter2);
                }
                for (int n = 0; n < 3; n++)
                {
                int ASCII1 = Rnd.Next(48, 57);
                char Karakter1 = Convert.ToChar(ASCII1);
                StrBuild.Append(Karakter1);
                }
                for (int k = 0; k < 3; k++)
                {
                    int ASCII3 = Rnd.Next(97, 122);
                    char Karakter3 = Convert.ToChar(ASCII3);
                    StrBuild.Append(Karakter3);
                }
                 sifre.Text = StrBuild.ToString();
        }
        private void calisanekledt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            kullaniciAdi.Enabled = false;
        }
        private void CALİSANEKLE_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from calisanEkle where ad like '" + txtAdaGore.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            calisanekledt.DataSource = ds.Tables[0];
            baglanti.Close();
        }
    }
}
