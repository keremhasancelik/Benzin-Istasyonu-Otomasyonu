using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayac_Proje
{
    public partial class FrmKasa : Form
    {
        public FrmKasa()
        {
            InitializeComponent();
        }

        private void btnYakit_Click(object sender, EventArgs e)
        {
            FrmYakitKasasi frm = new FrmYakitKasasi();
            frm.ShowDialog();
        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            Frm_MarketKasasi frm = new Frm_MarketKasasi();
            frm.ShowDialog();
        }

        private void btnYikama_Click(object sender, EventArgs e)
        {
            Frm_YikamaKasasi frm = new Frm_YikamaKasasi();
            frm.ShowDialog();
        }

        private void btnCadir_Click(object sender, EventArgs e)
        {
            Frm_RestaurantKasasi frm = new Frm_RestaurantKasasi();
            frm.ShowDialog();
        }
    }
}
