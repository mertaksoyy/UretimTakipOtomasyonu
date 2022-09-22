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
    public partial class PersonelBilg : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\merta\Desktop\UretimAgaci son upload\UretimAgaci\Sistem Analizi Database.mdb");
        DataTable tablo = new DataTable();
        public void Listele()
        {
            baglanti.Open();
            OleDbDataAdapter adptr = new OleDbDataAdapter("Select * from personel",baglanti);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
        public PersonelBilg()
        {
            InitializeComponent();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void PersonelBilg_Load(object sender, EventArgs e)
        {
            Listele();  
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Insert Into personel(adi,soyadi,tckimlik,departman,unvan,cinsiyet,dogtar,dogyeri,telno,email) values('"+textBox1.Text+ "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + comboBox1.Text + "','" + comboBox2.Text + "','" + dateTimePicker1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            Listele();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = "";
        }
        private void BtnSil_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from personel where tckimlik='"+dataGridView1.CurrentRow.Cells["tckimlik"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            Listele();
            
        }

        private void BtnKapat_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            dateTimePicker1.Text = "";
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
