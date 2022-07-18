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
    public partial class FrmGelir : Form
    {
        public FrmGelir()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        int urun;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            urun = int.Parse(comboBox1.SelectedValue.ToString());
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Gelir(GELIRACIKLAMA,GELIRTUTAR,GELIRTARIH) VALUES(@p1,@p2,@p3)", conn);
            komut.Parameters.AddWithValue("@p1", TxtGelirAciklama.Text);
            komut.Parameters.AddWithValue("@p2", Convert.ToDecimal( TxtGelirTutar.Text));
            komut.Parameters.AddWithValue("@p3", dateTimePicker1.Value);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Eklendi");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Gelir ORDER BY GELIRID DESC", conn);
            conn.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            urun = int.Parse(comboBox1.SelectedValue.ToString());
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("update Tbl_Gelir set GELIRACIKLAMA=@p1,YAKIT=@p2,GELIRTUTAR=@p3,GELIRTARIH=@p4 where GELIRID=@p6", conn);
            komut.Parameters.AddWithValue("@p1", TxtGelirAciklama.Text);
            komut.Parameters.AddWithValue("@p2", urun);
            komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(TxtGelirTutar.Text));
            komut.Parameters.AddWithValue("@p4", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@p6", TxtUrunID.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Güncellendi");
        }

        private void FrmGelir_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("select URUNID,URUNAD from Tbl_Urunn", conn);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "URUNAD";
            comboBox1.ValueMember = "URUNID";
            comboBox1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtUrunID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtGelirAciklama.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            comboBox1.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtGelirTutar.Text= dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int satir = dataGridView1.Rows.Count - 1;
            decimal tutar = 0;
            for (int i = 0; i < satir; i++)
            {
                tutar += decimal.Parse(dataGridView1.Rows[i].Cells["GELIRTUTAR"].Value.ToString());
                
            }
            dataGridView1.Rows[satir].Cells["GELIRTUTAR"].Value = "Toplam = " + string.Format("{0:C2}", tutar);
            
        }
    }
}
