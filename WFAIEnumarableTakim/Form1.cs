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
    public partial class Form1 : Form
    {
        Takim takim;
        public Form1()
        {
            InitializeComponent();

            takim = new Takim(
                    new Futbolcu("Alex de Souza", 10, MevkiiEnum.Forvet),
                    new Futbolcu("Hakan Şükür", 39, MevkiiEnum.Forvet),
                    new Futbolcu("Gökhan Töre", 77, MevkiiEnum.Ortasaha),
                    new Futbolcu("Ahmet Hulusi", 38, MevkiiEnum.Defans),
                    new Futbolcu("Mehmet Sağlam", 31, MevkiiEnum.Kaleci),
                    new Futbolcu()
                    {
                        AdSoyad = "George Hagi",
                        FormaNo = 10,
                        Mevkii = MevkiiEnum.Ortasaha
                    }
            );
            cboMevkiiAra.DataSource = Enum.GetValues(typeof(MevkiiEnum));
        }


        private void btnGetir_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void Listele()
        {
            lstFutbolcular.Items.Clear(); 
            // Liste tekrarlanmasın diye yeni liste eklediğimizde her başta temizliyor.

            this.Text = $"Futbolcu Sayısı: {takim.FutbolcuSayisi} - Forma No Ortalaması: {takim.FormaNoOrtalamasi}";

            foreach (Futbolcu futbolcu in takim)
            {
                lstFutbolcular.Items.Add(futbolcu);
            }
        }

        private void btnOyuncuEkle_Click(object sender, EventArgs e)
        {
            OyuncuEkleForm oyuncuEkleForm = new OyuncuEkleForm(takim);
            DialogResult dr = oyuncuEkleForm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                Listele();
            }

        }

        private void lstFutbolcular_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lstFutbolcular.SelectedIndex != -1)
            {
                takim.FutbolcuSil(lstFutbolcular.SelectedIndex);
                Listele();

            }
        }

        private void lstFutbolcular_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            OyuncuEkleForm oyuncuEkleForm = new OyuncuEkleForm(takim, (Futbolcu)lstFutbolcular.SelectedItem);
            if (lstFutbolcular.SelectedIndex == -1) return;
            oyuncuEkleForm.ShowDialog();
            Listele();
        }

        private void btnFutbolcuAra_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFutbolcuAraAdSoyad.Text))
            {
                if (takim.FutbolcuBul(txtFutbolcuAraAdSoyad.Text) != null)
                    MessageBox.Show(takim.FutbolcuBul(txtFutbolcuAraAdSoyad.Text).ToString());
                else
                    MessageBox.Show("Aradığınız Futbolcu Bulunamadı..!");
            }
            else
            {
                if (takim.FutbolcuBul((byte)nudFormaNoAra.Value) != null)
                    MessageBox.Show(takim.FutbolcuBul((byte)nudFormaNoAra.Value).ToString());
                else
                    MessageBox.Show("Aradığınız Futbolcu Bulunamadı..!");
            }
        }

        private void btnMevkiiAra_Click(object sender, EventArgs e)
        {
            takim.MevkiiyeGöreGetir((MevkiiEnum)cboMevkiiAra.SelectedItem).ForEach(x => MessageBox.Show(x.FormaNo + " - " + x.AdSoyad + " - " + x.Mevkii));
        }
    }
}
