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
    public partial class izinbildiriler : Form
    {
        public izinbildiriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U4RIC3I\\SQLEXPRESS;Initial Catalog=taksiDuragiOtomasyonu;Integrated Security=True");
        public string tc;
        public void doldur()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT izinid, ad,soyad,izinnedeni,baslangict,bitist,kontrol FROM izin", baglanti);
            adap.Fill(dt);
            izindt.DataSource = dt;
        }
        public void doldurlt()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM bildiri", baglanti);
            komut.Connection = baglanti;
            SqlDataReader dr;
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem oge = new ListViewItem(dr["bildiriid"].ToString());
                oge.SubItems.Add(dr["ad"].ToString());
                oge.SubItems.Add(dr["soyad"].ToString());
                oge.SubItems.Add(dr["bildiri"].ToString());
                bildirilw.Items.Add(oge);
            }
            baglanti.Close();
        }
        private void izinbildiriler_Load(object sender, EventArgs e)
        {
            doldurlt();
            doldur();
        }
        private void izinbildiriler_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ADMIN f1 = new ADMIN();
            f1.tc = tc;
            f1.Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update izin set onay=@p1,kontrol=@p3 where izinid=@p2",baglanti);
            komut.Parameters.AddWithValue("@p1",1);
            komut.Parameters.AddWithValue("@p2", izinsira.Text);
            komut.Parameters.AddWithValue("@p3", "Onaylandı");
            komut.ExecuteNonQuery();
                if (checkBox1.Checked == true)
                {
                    MessageBox.Show("izin onaylandı");
                    doldur();
                    baglanti.Close();
                }
                else
                {
                    MessageBox.Show("ONAY KUTUSUNU İŞARETLEYİN...", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    doldur();
                    baglanti.Close();    
            }
        }
        private void izindt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = izindt.SelectedCells[0].RowIndex;
            izinsira.Text = izindt.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
