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

namespace Sayac_Proje
{
    public partial class Frm_YakitSatisOzet : Form
    {
        public Frm_YakitSatisOzet()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void Frm_YakitSatisOzet_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_MotorinSatis ORDER BY MSATISID DESC", conn);
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_BenzinSatis ORDER BY SATISID DESC", conn);
            SqlDataAdapter da3 = new SqlDataAdapter("select * from Tbl_LpgSatis ORDER BY LSATISID DESC", conn);
            conn.Open();
            da.Fill(dt);
            da2.Fill(dt2);
            da3.Fill(dt3);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt2;
            dataGridView3.DataSource = dt3;
            
            SqlCommand komut2 = new SqlCommand("select sum(MTLITRE), sum(MTTUTAR) from Tbl_MotorinSatis", conn);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblMotirinToplamLitre.Text = dr2[0].ToString();
                lblMotirinToplamTutar.Text = dr2[1].ToString();
               


            }
            conn.Close();
            
            SqlCommand komut3 = new SqlCommand("select sum(TLITRE), sum(TTUTAR) from Tbl_BenzinSatis", conn);
            conn.Open();
            SqlDataReader dr3 = komut3.ExecuteReader();
           
            while (dr3.Read())
            {
                lblBenzinToplamLitre.Text = dr3[0].ToString();
                lblBenzinToplamTutar.Text = dr3[1].ToString();



            }
            conn.Close();

            SqlCommand komut4 = new SqlCommand("select sum(LTLITRE), sum(LTTUTAR) from Tbl_LpgSatis", conn);
            conn.Open();
            SqlDataReader dr4 = komut4.ExecuteReader();

            while (dr4.Read())
            {
                lblLpgToplamLitre.Text = dr4[0].ToString();
                lblLpgToplamTutar.Text = dr4[1].ToString();



            }
            conn.Close();
        }

        private void btnFiltrele_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(bgl.Adres);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_MotorinSatis where MTARIH between @p1 and @p2 ORDER BY MSATISID DESC", conn);
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Tbl_BenzinSatis where BTARIH between @p1 and @p2 ORDER BY SATISID DESC", conn);
            SqlDataAdapter da3 = new SqlDataAdapter("select * from Tbl_LpgSatis where LTARIH between @p1 and @p2 ORDER BY LSATISID DESC", conn);
            da.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
            da.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
            da2.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
            da2.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
            da3.SelectCommand.Parameters.AddWithValue("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
            da3.SelectCommand.Parameters.AddWithValue("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
            conn.Open();
            da.Fill(dt);
            da2.Fill(dt2);
            da3.Fill(dt3);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt2;
            dataGridView3.DataSource = dt3;

            SqlCommand komut2 = new SqlCommand("select sum(MTLITRE), sum(MTTUTAR) from Tbl_MotorinSatis where MTARIH between @p1 and @p2", conn);
            komut2.Parameters.Add("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
            komut2.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblMotirinToplamLitre.Text = dr2[0].ToString();
                lblMotirinToplamTutar.Text = dr2[1].ToString();



            }
            conn.Close();

            SqlCommand komut3 = new SqlCommand("select sum(TLITRE), sum(TTUTAR) from Tbl_BenzinSatis where BTARIH between @p1 and @p2", conn);
            komut3.Parameters.Add("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
            komut3.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
            conn.Open();
            SqlDataReader dr3 = komut3.ExecuteReader();

            while (dr3.Read())
            {
                lblBenzinToplamLitre.Text = dr3[0].ToString();
                lblBenzinToplamTutar.Text = dr3[1].ToString();



            }
            conn.Close();

            SqlCommand komut4 = new SqlCommand("select sum(LTLITRE), sum(LTTUTAR) from Tbl_LpgSatis where LTARIH between @p1 and @p2", conn);
            komut4.Parameters.Add("@p1", SqlDbType.Date).Value = dateTimePicker1.Value;
            komut4.Parameters.Add("@p2", SqlDbType.Date).Value = dateTimePicker2.Value;
            conn.Open();
            SqlDataReader dr4 = komut4.ExecuteReader();

            while (dr4.Read())
            {
                lblLpgToplamLitre.Text = dr4[0].ToString();
                lblLpgToplamTutar.Text = dr4[1].ToString();



            }
            conn.Close();

        }
    }
}
