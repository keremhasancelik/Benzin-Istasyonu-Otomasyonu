using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayac_Proje
{
    public class Urun
    {
        public int URUNID { get; set; }
        public string URUNAD { get; set; }
        public double BIRIMFIYATI { get; set; }
        public double BIRIMFIYATIALIS { get; set; }
        public double STOK { get; set; }
        public ICollection<Satis> Satis { get; set; }
        public ICollection<Musteri> Musteri { get; set; }
        public ICollection<Alis> Alis { get; set; }
    }
}
