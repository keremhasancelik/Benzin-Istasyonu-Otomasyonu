using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayac_Proje
{
    public class Musteri
    {
        public int MUSTERIID { get; set; }
        public string MUSTERIAD { get; set; }
        public decimal toplamAlacak { get; set; }
        public DateTime sonOdeme { get; set; }
        public string telefon { get; set; }
        public string aciklama { get; set; }
        public string mail { get; set; }
        
        public ICollection <Satis> Satis { get; set; }
        public ICollection <Urun> Uruns { get; set; }
    }
}
