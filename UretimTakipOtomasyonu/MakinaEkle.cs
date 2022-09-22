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
    public partial class MakinaEkle : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\merta\Desktop\UretimAgaci son upload\UretimAgaci\Sistem Analizi Database.mdb");
        DataTable tablo = new DataTable();
        StokTakibi fr = new StokTakibi();

        public MakinaEkle()
        {
            InitializeComponent();
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Insert Into makine(id,adi,islevi,kullanimda,son_muayne_tar,fiyat,adet,gunluk_kapasite) values('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            MessageBox.Show("Ürün kelendi!");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MakinaEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
