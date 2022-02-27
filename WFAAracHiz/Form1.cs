using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAAracHiz
{
    public partial class Form1 : Form
    {
        Arac arac1 = new Arac("35 NK 153");
        Arac arac2 = new Arac("06 AN 6547");
        public Form1()
        {
            InitializeComponent();
            arac1.Ceza += Arac_Ceza;
            arac2.Ceza += Arac_Ceza;
        }
        private void Arac_Ceza(object sender, CezaEventArgs e)
        {
            Arac arac = (Arac)sender;
            lblInfo.Text = $"{arac.Plaka} plakalı aracınız {arac.Hiz}km/h ile hız sınırını aşmıştır.\r\nYediğiniz ceza tutariniz: {e.CezaTutari}\r\nCeza Tarihiniz: {e.CezaTarihi}\r\nToplam ceza tutarınız: {arac.ToplamCezaTutari}";
        }
        

       

        private void nudHiz_ValueChanged_1(object sender, EventArgs e)
        {
            arac1.Hiz = (int)nudHiz.Value;
        }

        private void nudArac2Hiz_ValueChanged_1(object sender, EventArgs e)
        {
            arac2.Hiz = (int)nudArac2Hiz.Value;
        }
    }
}
