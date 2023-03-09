using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sayac_Proje
{
    public class Tedarikci
    {
        public int TedarikciId { get; set; }
        public string TedarikciAd { get; set; }
        public ICollection<Alis> Alis { get; set; }
    }
}
