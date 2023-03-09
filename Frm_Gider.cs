using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sayac_Proje
{
    public partial class Frm_Gider : Form
    {
        public Frm_Gider()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Gider(GiderBaslik,GiderAciklama,GiderTutar,GiderTarih) VALUES(@p1,@p2,@p3,@p4)", conn);
                komut.Parameters.AddWithValue("@p1", txtGiderBaslik.Text);
                komut.Parameters.AddWithValue("@p2", TxtGiderAciklama.Text);
                komut.Parameters.AddWithValue("@p3", Convert.ToDouble(TxtGiderTutar.Text));
                komut.Parameters.AddWithValue("@p4", dateTimePicker1.Value);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Eklendi");
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik bilgileri doldurunuz");
            }
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open();
                SqlCommand komut = new SqlCommand("update Tbl_Gider set GiderBaslik=@p1,GiderAciklama=@p2,GiderTutar=@p3,GiderTarih=@p4 where GiderId=@p5", conn);
                komut.Parameters.AddWithValue("@p1", txtGiderBaslik.Text);
                komut.Parameters.AddWithValue("@p2", TxtGiderAciklama.Text);
                komut.Parameters.AddWithValue("@p3", Convert.ToDouble(TxtGiderTutar.Text));
                komut.Parameters.AddWithValue("@p4", dateTimePicker1.Value);
                komut.Parameters.AddWithValue("@p5", TxtGiderID.Text);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Güncellendi");
            }
            catch (Exception)
            {

                MessageBox.Show("Eksik bilgileri doldurunuz");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtGiderID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtGiderBaslik.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtGiderAciklama.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtGiderTutar.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Gider ORDER BY GiderId DESC", conn);
                conn.Open();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Beklenmedik bir hata oluştu...");
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            TxtGiderID.Text = "";
            txtGiderBaslik.Text = "";
            TxtGiderAciklama.Text = "";
            TxtGiderTutar.Text = "";
            dateTimePicker1.Text = "";
        }

        private void BtnFiltrele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);

            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Gider where GiderTarih between @p1 and @p2 ORDER BY GiderId DESC", conn);
            conn.Open();
            da.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker3.Value;
            da.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnUrunGrubuFiltreleme_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);

            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Gider where GiderBaslik LIKE @search ORDER BY GiderId DESC", conn);
            conn.Open();
            da.SelectCommand.Parameters.AddWithValue("@search", "%" + txtGiderBaslikFiltre.Text + "%");

            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            YakitKasasiRaporlar.GiderRaporlar(dataGridView1);
        }
    }
}
