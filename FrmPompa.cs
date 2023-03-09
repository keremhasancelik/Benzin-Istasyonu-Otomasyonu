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
    public partial class FrmPompa : Form
    {
        public FrmPompa()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        int urun;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {

                urun = int.Parse(CmbUrun.SelectedValue.ToString());
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Pompa(POMPANO,ADA,TANK,URUNNO,ACIKLAMA) VALUES(@p1,@p2,@p3,@p4,@p5)", conn);
                komut.Parameters.AddWithValue("@p1", int.Parse(TxtPompaNO.Text));
                komut.Parameters.AddWithValue("@p2", int.Parse(TxtAdaNo.Text));
                komut.Parameters.AddWithValue("@p3", urun);
                komut.Parameters.AddWithValue("@p4", int.Parse(TxtTankNo.Text));
                komut.Parameters.AddWithValue("@p5", richTextBox1.Text);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Eklendi");

            }
            catch (Exception)
            {
                MessageBox.Show("Bilgileri Kontrol Ediniz");
                //throw;
            }
        }

        private void FrmPompa_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("select URUNID,URUNAD from Tbl_Urunn", conn);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            CmbUrun.DisplayMember = "URUNAD";
            CmbUrun.ValueMember = "URUNID";
            CmbUrun.DataSource = dt;

            //SqlDataAdapter da = new SqlDataAdapter("select top(10) SAYACID,URUNAD,POMPA,BRMFIYATI,ACILIS,KAPANIS,SATILANLITRE,TUTAR,TARIH from Tbl_Sayac INNER JOIN Tbl_Urunn ON Tbl_Sayac.URUN=Tbl_Urunn.URUNID WHERE TARIH=@p1", conn);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select POPPAID,POMPANO,ADA,TANK,URUNNO,ACIKLAMA from Tbl_Pompa ORDER BY POPPAID asc ", conn);
            conn.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                urun = int.Parse(CmbUrun.SelectedValue.ToString());
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open();
                SqlCommand komut = new SqlCommand("update Tbl_Pompa set POMPANO=@p1,ADA=@p2,TANK=@p3,URUNNO=@p4,ACIKLAMA=@p5 where POPPAID=@p6", conn);
                komut.Parameters.AddWithValue("@p1", int.Parse(TxtPompaNO.Text));
                komut.Parameters.AddWithValue("@p2", int.Parse(TxtAdaNo.Text));
                komut.Parameters.AddWithValue("@p3", int.Parse(TxtTankNo.Text));
                komut.Parameters.AddWithValue("@p4", CmbUrun.Text);
                komut.Parameters.AddWithValue("@p5", richTextBox1.Text);
                komut.Parameters.AddWithValue("@p6", TxtPompaID.Text);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Güncellendi");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtPompaID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtPompaNO.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtAdaNo.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            CmbUrun.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtTankNo.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            TxtPompaID.Text = "";
            TxtAdaNo.Text = "";
            TxtPompaNO.Text = "";
            TxtTankNo.Text = "";
            TxtUrunAd.Text = "";
            richTextBox1.Text = "";
            CmbUrun.Text = "";
        }
    }
}
