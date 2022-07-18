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
    public partial class FrmRaporlar : Form
    {
        public FrmRaporlar()
        {
            InitializeComponent();
        }

        private void FrmRaporlar_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'Db_SayacDataSet.Tbl_Sayac' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            this.Tbl_SayacTableAdapter.Fill(this.Db_SayacDataSet.Tbl_Sayac);

            this.reportViewer1.RefreshReport();

           
        }
    }
}
