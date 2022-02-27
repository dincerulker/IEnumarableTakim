using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAAracHiz
{
    //public delegate void MyDelegate<TEventArgs>(object sender, TEventArgs args);
    //EventHandler<TEventArgs> ile aynı.
    public class Arac
    {
        // Aracın hızı 82'den büyük ve 100'den küçük iken 100TL, 100'den büyük ise 200TL
        // Aracın yediği tüm cezalar da ToplamCezaTutari'na eklenecektir.
        // Aracın anlık hızını nud ile yönet eğer ceza yerse, ceza yediği tarih, arac plaka no, anlık yediği ceza ve toplam ceza tutarını bir label ya da textbox readonly'de gösteriniz.
        public event EventHandler<CezaEventArgs> Ceza;
        public Arac(string plaka)
        {
            Plaka = plaka;
        }
        private int hiz;

        public int Hiz
        {
            get { return hiz; }
            set
            {
                hiz = value;
                if (hiz > 82 && hiz <= 100 && Ceza != null)
                {
                    decimal ceza = 100;
                    ToplamCezaTutari += ceza;
                    Ceza(this, new CezaEventArgs(DateTime.Now, ceza));
                }
                else if (hiz > 100 && Ceza != null)
                {
                    decimal ceza = 200;
                    ToplamCezaTutari += ceza;
                    Ceza(this, new CezaEventArgs(DateTime.Now, ceza));
                }
            }
        }
        public string Plaka { get; set; }
        public decimal ToplamCezaTutari { get; set; }
    }
}
