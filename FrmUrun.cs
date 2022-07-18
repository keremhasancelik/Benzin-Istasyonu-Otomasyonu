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

namespace Sayac_Proje
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();


        //public decimal b_fiyat;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Urunn(URUNAD,BIRIMFIYATI,STOK) VALUES(@p1,@p2,@p3)", conn);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", Convert.ToDecimal( TxtBirimFiyati.Text));
            komut.Parameters.AddWithValue("@p3", Convert.ToDecimal( TxtStokLT.Text));
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Eklendi");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Urunn", conn);
            conn.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("update Tbl_Urunn set URUNAD=@p1,BIRIMFIYATI=@p2,STOK=@p3 where URUNID=@p4", conn);
            komut.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut.Parameters.AddWithValue("@p2", Convert.ToDecimal (TxtBirimFiyati.Text));
            komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(TxtStokLT.Text));
            komut.Parameters.AddWithValue("@p4", TxtUrunID.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Güncellendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtUrunID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtBirimFiyati.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtStokLT.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Urunn where URUNID=@p1", conn);
            komut.Parameters.AddWithValue("@p1", TxtUrunID.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Silindi");
        }
    }
}
