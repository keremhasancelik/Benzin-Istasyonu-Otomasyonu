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
    public partial class FrmPersonel : Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void FrmPersonel_Load(object sender, EventArgs e)
        {

        }
        public decimal kalanmaas, avans, kalan;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                kalanmaas = Convert.ToDecimal(TxtKalanMaas.Text);
                //avans = Convert.ToDecimal(TxtAvans.Text);
                kalan = kalanmaas - avans;
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open();
                SqlCommand komut = new SqlCommand("update Tbl_Personel set PERAD=@p1,PERGOREV=@p2,PERMAAS=@p3,PERTELEFON=@p6,PERMAIL=@p7 where PERID=@p8", conn);
                komut.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtGorev.Text);
                komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(TxtMaas.Text));
                //komut.Parameters.AddWithValue("@p4", Convert.ToDecimal(TxtAvans.Text));
                //komut.Parameters.AddWithValue("@p5", kalan);
                komut.Parameters.AddWithValue("@p6", MskTel.Text);
                komut.Parameters.AddWithValue("@p7", TxtMail.Text);
                komut.Parameters.AddWithValue("@p8", TxtPersonelID.Text);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Güncellendi");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
           
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            try
            {
                TxtPersonelID.Text = "";
                TxtPersonelAd.Text = "";
                TxtUrunAd.Text = "";
                TxtMail.Text = "";
                TxtMaas.Text = "";
                TxtKalanMaas.Text = "";
                //TxtAvans.Text = "";
                MskTel.Text = "";
                //SqlConnection conn = new SqlConnection(bgl.Adres);
                //conn.Open();
                //SqlCommand komut = new SqlCommand("delete from Tbl_Personel where PERID=@p1", conn);
                //komut.Parameters.AddWithValue("@p1", TxtPersonelID.Text);
                //komut.ExecuteNonQuery();
                //conn.Close();
                //MessageBox.Show("Silindi");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
            
        }

        private void btnAvansEkle_Click(object sender, EventArgs e)
        {
            FrmPersonelMaasHareket frm = new FrmPersonelMaasHareket();
            frm.ShowDialog();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            YakitKasasiRaporlar.PersonelRaporlar(dataGridView1);
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtPersonelID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtPersonelAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtGorev.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtMaas.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            //TxtAvans.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtKalanMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            MskTel.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            TxtMail.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select PERID,PERAD,PERGOREV,PERMAAS,PERKALANMAAS,PERTELEFON,PERMAIL from Tbl_Personel",conn);
            conn.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                //maas = Convert.ToDecimal(TxtMaas.Text);
                //avans = Convert.ToDecimal(TxtAvans.Text);
                //kalan = maas - avans;
                SqlConnection conn = new SqlConnection(bgl.Adres);
                conn.Open();
                SqlCommand komut = new SqlCommand("insert into Tbl_Personel(PERAD,PERGOREV,PERMAAS,PERTELEFON,PERMAIL) values(@p1,@p2,@p3,@p6,@p7)", conn);
                komut.Parameters.AddWithValue("@p1", TxtPersonelAd.Text);
                komut.Parameters.AddWithValue("@p2", TxtGorev.Text);
                komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(TxtMaas.Text));
                //komut.Parameters.AddWithValue("@p4", Convert.ToDecimal(TxtAvans.Text));
                //komut.Parameters.AddWithValue("@p5", kalan);
                komut.Parameters.AddWithValue("@p6", MskTel.Text);
                komut.Parameters.AddWithValue("@p7", TxtMail.Text);
                komut.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Eklendi");
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
            
        }
    }
}
