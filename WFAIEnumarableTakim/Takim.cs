using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAIEnumarableTakim
{
    public class Takim : IEnumerable
    {
        public Futbolcu[] futbolcular;

        public Takim(params Futbolcu[] futbolcular) // takım oluşturdurğumuzda istediğimiz kadar futbolcu eklememiz için param yaptık
        {
            this.futbolcular = futbolcular;
        }
        public int FutbolcuSayisi // => futbolcular.Length;
        {
            get
            {
                return futbolcular.Length;
            }
        }

        public double FormaNoOrtalamasi
        { 
            get
            {
                double toplam = 0;
                foreach (var item in futbolcular)
                {
                    toplam += item.FormaNo;
                }
                return toplam / FutbolcuSayisi;
            }

        }
        public IEnumerator GetEnumerator()
        {
            return new TakımEnumarator(futbolcular);
        }
        public void FutbolcuEkle(Futbolcu futbolcu)
        {
            Array.Resize(ref futbolcular, futbolcular.Length + 1);
            futbolcular[futbolcular.Length - 1] = futbolcu;
        }
        public void FutbolcuEkle(params Futbolcu [] futbolcu)
        {
            foreach (var item in futbolcular)
            {
                Array.Resize(ref futbolcular, futbolcular.Length + 1);
                futbolcular[futbolcular.Length - 1] = item;
            }
        }
        // ÖDEV Takım classı içerisindeki metodların tamamlanması ve design ile kullanıma sokulması
        public Futbolcu FutbolcuBul(string adsoyad)
        {
            return this.Cast<Futbolcu>().FirstOrDefault(x => x.AdSoyad == adsoyad);
        }

        public Futbolcu FutbolcuBul(int formaNo)
        {
            return futbolcular.FirstOrDefault(x => x.FormaNo == formaNo);
        }
        public List<Futbolcu> MevkiiyeGöreGetir(MevkiiEnum mevkii)
        {
            List<Futbolcu> result = futbolcular.Where(x => x.Mevkii == mevkii).ToList();
            return result;
        }
        public void FutbolcuSil(int seciliIndex)
        {
            futbolcular = futbolcular.Where((futbolcular, index) => index != seciliIndex).ToArray();
        }
        public void FutbolcuGuncelle(Futbolcu eski,Futbolcu yeni)
        {
            for (int i = 0; i < futbolcular.Length - 1; i++)
            {
                if (futbolcular[i] == eski)
                    futbolcular[i] = yeni;
            }

        }
    }
}
