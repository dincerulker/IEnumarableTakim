using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAIEnumarableTakim
{
    public class Futbolcu
    {
        public Futbolcu()
        {

        }
        public Futbolcu(string adSoyad,byte formaNo, MevkiiEnum mevkii)
        {
            AdSoyad = adSoyad;
            FormaNo = formaNo;
            Mevkii = mevkii;
        }
        public string AdSoyad { get; set; }
        public byte FormaNo { get; set; }
        public MevkiiEnum Mevkii { get; set; }

        public override string ToString()
        {
            return $"{AdSoyad}, {FormaNo}, {Mevkii}";
        }

    }
    
}
