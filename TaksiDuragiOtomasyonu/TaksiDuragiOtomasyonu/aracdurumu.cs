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
    public partial class ARACDURUMU : Form
    {
        public ARACDURUMU()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U4RIC3I\\SQLEXPRESS;Initial Catalog=taksiDuragiOtomasyonu;Integrated Security=True");
        public string tc;
        private void button5_Click(object sender, EventArgs e)
        {
            ADMIN f2 = new ADMIN();
            f2.tc = tc;
            f2.Show();
            this.Hide();
        }
        public void doldur()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM arac_Durumu", baglanti);
            adap.Fill(dt);
            aracdurumudt.DataSource = dt;
        }
        private void ARACDURUMU_Load(object sender, EventArgs e)
        {
            kalmanedeni.Enabled = false;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select aracplakasi from calisanEkle", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cbplaka.Items.Add(dr[0]);
            }
            
            baglanti.Close();
            doldur();
        }
        private void ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string muayene = "", kaza = "";
            if (kaldi.Checked)
            {
                muayene = kaldi.Text;
            }
            else if (gecti.Checked)
            {
                muayene = gecti.Text;
            }
            if (var.Checked)
            {
                kaza = var.Text;
            }
            else if (yok.Checked)
            {
                kaza = yok.Text;
            }
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT * FROM calisanEkle", baglanti);
            adap.Fill(dt);
            if (checkBox1.Checked && checkBox2.Checked && checkBox3.Checked && checkBox4.Checked)
            {
                SqlCommand komut = new SqlCommand("insert into arac_Durumu(plaka,muayeneDurumu,kalmaNedeni,kazaDurumu,unutulanEsya,blndrlmasiZorunlu) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
                komut.Parameters.AddWithValue("@p1", cbplaka.Text);
                komut.Parameters.AddWithValue("@p2", muayene);
                komut.Parameters.AddWithValue("@p3", kalmanedeni.Text);
                komut.Parameters.AddWithValue("@p4", kaza);
                komut.Parameters.AddWithValue("@p5", unutulanesyalar.Text);
                komut.Parameters.AddWithValue("@p6", 1);
                if(String.IsNullOrEmpty(cbplaka.Text)|| String.IsNullOrEmpty(muayene) || String.IsNullOrEmpty(kaza))
                {
                    MessageBox.Show("Boş bırakılan alanlarıda doldurmalısınız");
                }
                else
                {
                    komut.Connection = baglanti;
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Kayıt Eklendi");
                    doldur();
                }
            }
            else
            {
                MessageBox.Show("Bulundurulması zorunlu olan bütün araç gereçleri işaretlemelisiniz");
                baglanti.Close();
            }
        }
        private void kaldi_CheckedChanged(object sender, EventArgs e)
        {
            if (kaldi.Checked == true)
            {
                kalmanedeni.Enabled = true;
            }
            else if (gecti.Checked == true)
            {
                kalmanedeni.Enabled = false;
            }
        }
        private void ARACDURUMU_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void aracdurumudt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string muayene = "";
            string kaza="";
            int secilen = aracdurumudt.SelectedCells[0].RowIndex;
            sira.Text = aracdurumudt.Rows[secilen].Cells[0].Value.ToString();
            cbplaka.Text = aracdurumudt.Rows[secilen].Cells[1].Value.ToString();
            muayene = aracdurumudt.Rows[secilen].Cells[2].Value.ToString();
            kalmanedeni.Text = aracdurumudt.Rows[secilen].Cells[3].Value.ToString();
            kaza = aracdurumudt.Rows[secilen].Cells[4].Value.ToString();
            unutulanesyalar.Text = aracdurumudt.Rows[secilen].Cells[5].Value.ToString();
            if (kaza == "Var")
            {
                var.Checked = true;
            }else if (kaza == "Yok")
            {
                yok.Checked = true;
            }
            if (muayene == "Geçti")
            {
                gecti.Checked = true;
            }
            else if (muayene == "Kaldı")
            {
                kaldi.Checked = true;
            }
        }
        private void sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM arac_Durumu WHERE aracdurumuid=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", sira.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt silindi");
            doldur();       
        }
    }
}
