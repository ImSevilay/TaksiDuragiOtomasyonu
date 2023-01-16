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
    public partial class KAYİT : Form
    {
        public KAYİT()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U4RIC3I\\SQLEXPRESS;Initial Catalog=taksiDuragiOtomasyonu;Integrated Security=True");
        public string tc;
        public void doldur()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT kayitid,ad,soyad FROM kayit", baglanti);
            adap.Fill(dt);
            dtgecmis.DataSource = dt;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ADMIN f2 = new ADMIN();
            f2.tc = tc;
            f2.Show();
            this.Hide();
        }

        private void KAYİT_Load(object sender, EventArgs e)
        {
            mdoldur();
            doldur();
        }
        public void mdoldur()
        {

            DataTable dt = new DataTable();
            SqlDataAdapter adap = new SqlDataAdapter("SELECT*FROM musteritalep", baglanti);
            adap.Fill(dt);
            dttalep.DataSource = dt;
        }
        private void kayitsil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("DELETE FROM kayit WHERE kayitid=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtSiraNo.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt silindi");
            doldur();
        }
        private void dtgecmis_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dtgecmis.SelectedCells[0].RowIndex;
            txtSiraNo.Text = dtgecmis.Rows[secilen].Cells[0].Value.ToString();
        }
        private void KAYİT_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
