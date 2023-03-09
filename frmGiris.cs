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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }
        Baglanti bgl = new Baglanti();
        private void btnYazdir_Click(object sender, EventArgs e)
        {
            GirisYap();
        }
        private void GirisYap()
        {
            try
            {
                SqlConnection conn = new SqlConnection(bgl.Adres);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("select * from Tbl_User where UserName=@p1 and UserPassword=@p2", conn);
                da.SelectCommand.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text.Trim());
                da.SelectCommand.Parameters.AddWithValue("@p2", txtSifre.Text.Trim());
                conn.Open();
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Form1 frm = new Form1();
                    frm.Show();
                    this.Hide();
                }

                conn.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("Hatalı Giriş");
            }
        }
        private void btnYazdir_KeyDown(object sender, KeyEventArgs e)
        {
            GirisYap();
        }
    }
}
