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
    public partial class FrmTedarikci : Form
    {
        public FrmTedarikci()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        decimal borc_alacak,odeme,borc;

        private void FrmTedarikci_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("select URUNID,URUNAD from Tbl_Urunn", conn);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbUrunAdi.DisplayMember = "URUNAD";
            CmbUrunAdi.ValueMember = "URUNID";
            CmbUrunAdi.DataSource = dt;
            conn.Close();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select TEDID,TEDFIRMA,URUNAD,TEDODEME,TEDBORC,TEDBORCALACAK,TEDTELEFON,TEDMAIL from Tbl_Tedarikci INNER JOIN Tbl_Urunn ON Tbl_Tedarikci.TEDURUN=Tbl_Urunn.URUNID", conn);
            conn.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtTedarikciID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtTedarikciFirma.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            CmbUrunAdi.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtOdeme.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            TxtBorc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtBorcAlacak.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            MskTel.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            odeme = Convert.ToDecimal(TxtOdeme.Text);
            borc = Convert.ToDecimal(TxtBorc.Text);
            borc_alacak = borc - odeme;
            
            urun = int.Parse(CmbUrunAdi.SelectedValue.ToString());
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("update Tbl_Tedarikci set TEDFIRMA=@p1,TEDURUN=@p2,TEDODEME=@p3,TEDBORC=@p4,TEDBORCALACAK=@p5,TEDTELEFON=@p6,TEDMAIL=@p7 where TEDID=@p8", conn);
            komut.Parameters.AddWithValue("@p1", TxtTedarikciFirma.Text);
            komut.Parameters.AddWithValue("@p2", urun);
            komut.Parameters.AddWithValue("@p3", Convert.ToDecimal( TxtOdeme.Text));
            komut.Parameters.AddWithValue("@p4", Convert.ToDecimal(TxtBorc.Text));
            komut.Parameters.AddWithValue("@p5", Convert.ToDecimal(borc_alacak)); 
            komut.Parameters.AddWithValue("@p6", MskTel.Text);
            komut.Parameters.AddWithValue("@p7", TxtMail.Text);
            komut.Parameters.AddWithValue("@p8", TxtTedarikciID.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Güncellendi");
        }

        int urun;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            odeme = Convert.ToDecimal( TxtOdeme.Text);
            borc = Convert.ToDecimal( TxtBorc.Text);
            borc_alacak = borc - odeme;
            urun = int.Parse(CmbUrunAdi.SelectedValue.ToString());
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Tedarikci(TEDFIRMA,TEDURUN,TEDODEME,TEDBORC,TEDBORCALACAK,TEDTELEFON,TEDMAIL) VALUES(@p1,@p2,@p3,@p4,@p5,@p6,@p7)",conn);
            komut.Parameters.AddWithValue("@p1", TxtTedarikciFirma.Text);
            komut.Parameters.AddWithValue("@p2", urun);
            komut.Parameters.AddWithValue("@p3", TxtOdeme.Text);
            komut.Parameters.AddWithValue("@p4", TxtBorc.Text);
            komut.Parameters.AddWithValue("@p5", Convert.ToDecimal(borc_alacak));
            komut.Parameters.AddWithValue("@p6", MskTel.Text);
            komut.Parameters.AddWithValue("@p7", TxtMail.Text);
            
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Eklendi");
        }
    }
}
