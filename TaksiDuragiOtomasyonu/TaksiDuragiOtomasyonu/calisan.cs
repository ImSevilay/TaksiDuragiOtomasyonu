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
    public partial class CALİSAN : Form
    {
        public CALİSAN()
        {
            InitializeComponent();
        }
        public string plakacek = "";
        public string tc;
        public string plakaal;
        public bool durum;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U4RIC3I\\SQLEXPRESS;Initial Catalog=taksiDuragiOtomasyonu;Integrated Security=True");
        DateTime tarih;
        public void doldur()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("select * from calisan_isKaydi where aracplakasi='"+plakaal+"'", baglanti);
            adap.Fill(dt);
            dtkayit.DataSource = dt;
        }    
        private void button1_Click(object sender, EventArgs e)
        {
            GİRİS f1 = new GİRİS();
            f1.Show();
            this.Hide();
        }
        public void yeniIs()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("select*from musteriAracCagir where kontrol='"+"Yönlendiriliyor"+"'", baglanti);
            adap.Fill(dt);
            bildirimcalisandt.DataSource = dt;
        }
        private void CALİSAN_Load(object sender, EventArgs e)
        {
            label6.Text = GİRİS.gonderadsoyad;
            adIzin.Text = GİRİS.gonderad;
            soyadIzin.Text = GİRİS.gondersoyad;
            bildiriad.Text = GİRİS.gonderad;
            bildirisoyad.Text = GİRİS.gondersoyad;
            adIzin.Enabled = false;
            soyadIzin.Enabled = false;
            bildiriad.Enabled = false;
            bildirisoyad.Enabled = false;
            siraNo.Visible = false;
            baglanti.Open();
            SqlCommand sql = new SqlCommand("select aracplakasi from calisanEkle where ad='" + adIzin.Text + "'and soyad='" + soyadIzin.Text + "'", baglanti);
            sql.Connection = baglanti;
            SqlDataReader dr = sql.ExecuteReader();
            while (dr.Read())
            {
                plakaal = dr[0].ToString();
            }
            baglanti.Close();
            yeniIs();
            doldur();
        }
        private void adaGore_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from calisan_isKaydi where ad like '" + txtAdaGore.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtkayit.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void txtAdaGore_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from calisan_isKaydi where ad like '" + txtAdaGore.Text + "%'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtkayit.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void Kayit_Click(object sender, EventArgs e)
        {
            MessageBox.Show(plakacek);
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM calisan_isKaydi", baglanti);
            adap.Fill(dt);
            SqlCommand komut = new SqlCommand("Insert into calisan_isKaydi(ad,soyad,telefon,adres,aracplakasi) values(@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", adEkle.Text);
            komut.Parameters.AddWithValue("@p2", soyadEkle.Text);
            komut.Parameters.AddWithValue("@p3", telefonEkle.Text);
            komut.Parameters.AddWithValue("@p4", adresEkle.Text);
            komut.Parameters.AddWithValue("@p5", aracPlakaEkle.Text);
            if (String.IsNullOrEmpty(adEkle.Text) || String.IsNullOrEmpty(soyadEkle.Text) || String.IsNullOrEmpty(telefonEkle.Text) ||
                   String.IsNullOrEmpty(adresEkle.Text) || String.IsNullOrEmpty(aracPlakaEkle.Text))
            {
                MessageBox.Show("Boş Alanları Doldurunuz");
                baglanti.Close();
            }
            else
            {
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Eklendi");
            }
                siraNo.Clear();
                adEkle.Clear();
                soyadEkle.Clear();
                telefonEkle.Clear();
                adresEkle.Clear();
                aracPlakaEkle.Clear();
        
                baglanti.Open();
                SqlCommand sql1 = new SqlCommand("update arac_Sirasi set onay=@p1 where plaka=@plaka", baglanti);
                sql1.Parameters.AddWithValue("@p1", 0);
                sql1.Parameters.AddWithValue("@plaka", plakaal);
                sql1.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand sql = new SqlCommand("update musteriAracCagir set kontrol=@kontrol where plaka=@p1", baglanti);
                sql.Parameters.AddWithValue("@kontrol","Yönlendirildi");
                sql.Parameters.AddWithValue("@p1", plakacek);
                sql.ExecuteNonQuery();
                baglanti.Close();
                doldur();
                yeniIs();
            
        }
        private void dtkayit_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtkayit.SelectedCells[0].RowIndex;
            siraNo.Text = dtkayit.Rows[secilen].Cells[0].Value.ToString();
            adEkle.Text = dtkayit.Rows[secilen].Cells[1].Value.ToString();
            soyadEkle.Text = dtkayit.Rows[secilen].Cells[2].Value.ToString();
            telefonEkle.Text = dtkayit.Rows[secilen].Cells[3].Value.ToString();
            adresEkle.Text = dtkayit.Rows[secilen].Cells[4].Value.ToString();
            aracPlakaEkle.Text = dtkayit.Rows[secilen].Cells[5].Value.ToString();
        }
        private void sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM calisan_isKaydi WHERE ad=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", adEkle.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt silindi");
            doldur();
        }
        private void CALİSAN_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void izinTalebi_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            if (tarih == baslangicTarihi.Value || tarih <= baslangicTarihi.Value)
            {
                    if (baslangicTarihi.Value <= bitisTarihi.Value)
                    {
                        baglanti.Open();
                        DataTable dt = new DataTable();
                        SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM izin", baglanti);
                        adap.Fill(dt);
                        SqlCommand komut = new SqlCommand("Insert into izin(ad,soyad,izinnedeni,baslangict,bitist,onay,kontrol) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", baglanti);
                        komut.Parameters.AddWithValue("@p1", adIzin.Text);
                        komut.Parameters.AddWithValue("@p2", soyadIzin.Text);
                        komut.Parameters.AddWithValue("@p3", izinNedeni.Text);
                        komut.Parameters.AddWithValue("@p4", baslangicTarihi.Value.ToString("yyyy.MM.dd"));
                        komut.Parameters.AddWithValue("@p5", bitisTarihi.Value.ToString("yyyy.MM.dd"));
                        komut.Parameters.AddWithValue("@p6", 0);
                        komut.Parameters.AddWithValue("@p7", "Onay Bekleniyor");
                        if (String.IsNullOrEmpty(izinNedeni.Text) || String.IsNullOrEmpty(baslangicTarihi.Text) || String.IsNullOrEmpty(bitisTarihi.Text))
                        {
                            MessageBox.Show("Boş Alanları Doldurunuz");
                            baglanti.Close();
                        }else
                        {
                            MessageBox.Show("İzin kaydı oluşturuldu.onay bekleniyor");
                            komut.Connection = baglanti;
                            komut.ExecuteNonQuery();
                            baglanti.Close();
                        }
                    }else
                    {MessageBox.Show("Başlangıç tarihi bitiş tarihinden geri olamaz.");
                    baglanti.Close();
                }
                }
            else{ MessageBox.Show("Geçmiş tarihten izin alınamaz.");
                baglanti.Close();
            }
        }
        private void gonder_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM izin", baglanti);
            adap.Fill(dt);
            SqlCommand komut = new SqlCommand("Insert into bildiri(ad,soyad,bildiri) values(@p1,@p2,@p3)", baglanti);
            komut.Parameters.AddWithValue("@p1", bildiriad.Text);
            komut.Parameters.AddWithValue("@p2", bildirisoyad.Text);
            komut.Parameters.AddWithValue("@p3", bildiri.Text);
            if (String.IsNullOrEmpty(bildiri.Text))
            {
                MessageBox.Show("Boş Alanları Doldurunuz.");
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Bildiri Kaydı Alındı.");
                komut.Connection = baglanti;
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
        }
        private void bildirimcalisandt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            plakacek = bildirimcalisandt.Rows[e.RowIndex].Cells[8].Value.ToString();
            int secilen = bildirimcalisandt.SelectedCells[0].RowIndex;
            adEkle.Text = bildirimcalisandt.Rows[secilen].Cells[1].Value.ToString();
            soyadEkle.Text = bildirimcalisandt.Rows[secilen].Cells[2].Value.ToString();
            telefonEkle.Text = bildirimcalisandt.Rows[secilen].Cells[3].Value.ToString();
            adresEkle.Text = bildirimcalisandt.Rows[secilen].Cells[4].Value.ToString();
            siraNo.Text= bildirimcalisandt.Rows[secilen].Cells[0].Value.ToString();
            aracPlakaEkle.Text = plakaal;
            adEkle.Enabled = false;
            soyadEkle.Enabled = false;
            telefonEkle.Enabled = false;
            adresEkle.Enabled = false;
            aracPlakaEkle.Enabled = false;
        }
    }
}
