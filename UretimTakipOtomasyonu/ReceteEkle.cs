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
    public partial class ReceteEkle : Form
    {
        public static TextBox adı = new TextBox();
        public static TextBox adet = new TextBox();


        public ReceteEkle()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("Create table " + textBox2.Text + " (malzeme_adi varchar(20) , malzeme_adeti varchar(10))", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                button1.Enabled = true;
            }

            catch (Exception)
            {
                MessageBox.Show("Lütfen Gerekli alanları doldurunuz !");
            }
        }

        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source =C:\Users\merta\Desktop\UretimAgaci son upload\UretimAgaci\Sistem Analizi Database.mdb");
        DataTable tablo = new DataTable();
       public int sayac = 0 ;
        public int sayac1 = 10 ;
        public int satır = 0;
        public int baslaX = 15;
        public int baslaY = 124;
        public int baslaXX = 216;
        public int baslaYY = 124;

        public void uret ()
        {
            sayac++;
            adı.Name = sayac.ToString();

            adı.Size = new Size(183, 20);
            adı.AutoSize = false;
            adı.Location = new Point(baslaX, baslaY);
            baslaY += adı.Height + 7;
            Controls.Add(adı);

            sayac1++;
            adet.Name = sayac1.ToString();

            adet.Size = new Size(74, 20);
            adet.Location = new Point(baslaXX, baslaYY);
            baslaYY += adet.Height + 7;
            Controls.Add(adet);
           
            baglanti.Open();
            OleDbCommand kmt = new OleDbCommand("insert into " + textBox2.Text + "(malzeme_adi , malzeme_adeti) values ('" + adı.Text + "','" + adet.Text + "')", baglanti);
            kmt.ExecuteNonQuery();
            baglanti.Close();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            uret();
        }

        private void button2_Click(object sender, EventArgs e)
        {
    
            baglanti.Open();
            OleDbCommand komt = new OleDbCommand("insert into " + textBox2.Text + "(malzeme_adi , malzeme_adeti) values ('" + textBox3.Text + "','" + textBox4.Text + "')", baglanti);
            komt.ExecuteNonQuery();
            baglanti.Close();
         
        }



        public void ReceteEkle_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
