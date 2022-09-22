using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace UretimAgaci
{
    public partial class UrunEkle : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\merta\Desktop\UretimAgaci son upload\UretimAgaci\Sistem Analizi Database.mdb");
        StokTakibi fr = new StokTakibi();

        public UrunEkle()
        {
            InitializeComponent();
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Insert Into stok_urun(id,urunadi,urunturu,uretimtar,urun_maliyet,urun_satis_fiyati,stok_adet,max_stok_kapasite,stok_durum) values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + comboBox2.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            
            baglanti.Close();
            MessageBox.Show("Ürün eklendi!");
       
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
          
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = "";

            fr.Listele();
            this.Close();
            fr.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            fr.Show();
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
