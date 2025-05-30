using System;
using System.Windows.Forms;

namespace PSO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double parcacikSayisi = (double)ParcacikSayisi.Value;
            double jenerasyonSayisi = (double)JenerasyonSayisi.Value;
            double c1 = (double)C1.Value;
            double c2 = (double)C2.Value;
            chart1.Series["Uygunluk"].Points.Clear();
            Pso pso = new Pso(parcacikSayisi, jenerasyonSayisi, c1, c2);

            for (int i = 0; i < pso.uygunlukDegerleri.Count; i++)
            {
                chart1.Series["Uygunluk"].Points.Add(pso.uygunlukDegerleri[i]);
            }
            label4.Text = pso.uygunlukDegerleri[pso.uygunlukDegerleri.Count - 1].ToString();

            listBoxUygunluk.Items.Clear();
            for (int i = 0; i < pso.uygunlukDegerleri.Count; i++)
            {
                listBoxUygunluk.Items.Add($"Jenerasyon {i + 1}: {pso.uygunlukDegerleri[i]:F4}");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
