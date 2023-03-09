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
    public partial class FrmYakiKasasiRapor : Form
    {
        public FrmYakiKasasiRapor()
        {
            InitializeComponent();
        }

        private void FrmYakiKasasiRapor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'db_SayacDataSet3.Tbl_YakitKasasi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tbl_YakitKasasiTableAdapter.Fill(this.db_SayacDataSet3.Tbl_YakitKasasi);

            this.reportViewer1.RefreshReport();
        }
    }
}
