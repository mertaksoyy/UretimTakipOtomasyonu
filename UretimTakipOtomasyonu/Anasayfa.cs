using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UretimAgaci
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

       

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StokTakibi stokTakibi = new StokTakibi();
            stokTakibi.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Makina makina = new Makina();
            makina.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UrunRecetesi urunRecetesi = new UrunRecetesi();
            urunRecetesi.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonelBilg personelBilg = new PersonelBilg();
            personelBilg.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UrunUret urunUret = new UrunUret();
            urunUret.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DurumRaporu durumraporu = new DurumRaporu();
            durumraporu.Show();
        }
    }
    
}
