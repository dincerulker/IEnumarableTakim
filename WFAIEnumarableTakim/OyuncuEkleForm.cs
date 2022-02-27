using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAIEnumarableTakim
{
    public partial class OyuncuEkleForm : Form
    {
        private readonly Takim takim;
        private readonly Futbolcu futbolcu;

        public OyuncuEkleForm(Takim takim)
        {
            InitializeComponent();
            this.takim = takim;
            MevkiiEkle();

        }
        public OyuncuEkleForm(Takim takim,Futbolcu futbolcu)
        {
            InitializeComponent();
            this.futbolcu = futbolcu;
            this.takim = takim;
            MevkiiEkle();
            this.Text = "Futbolcu Güncelle";
            btnEkle2.Text = "Güncelle";
            txtAdSoyad.Text = futbolcu.AdSoyad;
            nudFormaNo.Value = futbolcu.FormaNo;
            cmbMevkii.SelectedItem = futbolcu.Mevkii;
        }

        private void MevkiiEkle()
        {
            cmbMevkii.DataSource = Enum.GetValues(typeof(MevkiiEnum));
        }

        private void btnEkle2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAdSoyad.Text)&&cmbMevkii.SelectedItem != null)
            {
                takim.FutbolcuEkle(new Futbolcu() // takıma yeni futbolcu ekliyoruz.
                {
                    AdSoyad = txtAdSoyad.Text,
                    Mevkii = (MevkiiEnum)cmbMevkii.SelectedIndex,
                    FormaNo = (byte)nudFormaNo.Value
                });

            }
            DialogResult = DialogResult.OK;
            Close();
            

        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            Close();
            DialogResult = DialogResult.Cancel;
        }
    }
}
