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
    public partial class FrmFatura : Form
    {
        public FrmFatura()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void FrmFatura_Load(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Fatura(FATURANO,FATKURULUS,FATTUTAR,FATSONODEME,FATDURUM,FATACIKLAMA) VALUES(@p1,@p2,@p3,@p4,@p5,@p6)", conn);
            komut.Parameters.AddWithValue("@p1", TxtFaturaNO.Text);
            komut.Parameters.AddWithValue("@p2", TxtFaturaKurum.Text);
            komut.Parameters.AddWithValue("@p3", Convert.ToDecimal( TxtFaturaTutar.Text));
            komut.Parameters.AddWithValue("@p4", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@p5", Convert.ToByte( TxtFaturaDurum.Text));
            komut.Parameters.AddWithValue("@p6", richTextBox1.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Eklendi");
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_Fatura order by FATSONODEME desc", conn);
            conn.Open();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            TxtFaturaID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            TxtFaturaNO.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TxtFaturaKurum.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            TxtFaturaTutar.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            TxtFaturaDurum.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            conn.Open();
            SqlCommand komut = new SqlCommand("update Tbl_Fatura set FATURANO=@p1,FATKURULUS=@p2,FATTUTAR=@p3,FATSONODEME=@p4,FATDURUM=@p5,FATACIKLAMA=@p6 where FATURAID=@p7 ", conn);
            komut.Parameters.AddWithValue("@p1", TxtFaturaNO.Text);
            komut.Parameters.AddWithValue("@p2", TxtFaturaKurum.Text);
            komut.Parameters.AddWithValue("@p3", Convert.ToDecimal(TxtFaturaTutar.Text));
            komut.Parameters.AddWithValue("@p4", dateTimePicker1.Value);
            komut.Parameters.AddWithValue("@p5", Convert.ToByte(TxtFaturaDurum.Text));
            komut.Parameters.AddWithValue("@p6", richTextBox1.Text);
            komut.Parameters.AddWithValue("@p7", TxtFaturaID.Text);
            komut.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Güncellendi");
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            TxtFaturaNO.Text = "";
            TxtFaturaKurum.Text = "";
            TxtFaturaTutar.Text = "";
            TxtFaturaDurum.Text = "";
            richTextBox1.Text = "";
            TxtFaturaID.Text = "";
        }
    }
}
