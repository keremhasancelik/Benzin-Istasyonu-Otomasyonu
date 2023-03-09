using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayac_Proje
{
    public class Satis
    {
        public int SATISID { get; set; }
        public DateTime TARIH { get; set; }
        public int SATISMUSTERI { get; set; }
        public int musteriID { get; set; }
        public int satisID { get; set; }

        public virtual Musteri Musteri { get; set; }
        public virtual Urun Urun { get; set; }
        public string URUN { get; set; }
        public string SATISMUSTER { get; set; }
        public string FISNO { get; set; }
        public int YAKITCINSI { get; set; }
        public double SATLITRE { get; set; }
        public double BFIYAT { get; set; }
        public double SATISTUTAR { get; set; }
        public double TAHSILAT { get; set; }
        public string ACIKLAMA { get; set; }
    }
}
