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
    public partial class StokTakibi : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\merta\Desktop\UretimAgaci son upload\UretimAgaci\Sistem Analizi Database.mdb");
        DataTable tablo = new DataTable();
        AnaMenu anasayfa = new AnaMenu();

        public void Listele()
        {
            tablo.Clear();
            baglanti.Open();
            OleDbDataAdapter adptr = new OleDbDataAdapter("Select * from stok_urun", baglanti);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }
       


        public StokTakibi()
        {
            InitializeComponent();
        }

        private void StokTakibi_Load(object sender, EventArgs e)
        {
            /*
            if (dataGridView1.Rows.Count > 0)
            {
                label10.Text = dataGridView1.Rows.Count.ToString();
                float ex = 0;

                for (int i = 0; i < dataGridView1.Rows.Count; ++i) {
                    ex += float.Parse(dataGridView1.Rows[i].Cells["stok_adet"].Value.ToString());
                    label11.Text = ex.ToString();
                
                }
            }
            else
            {
                label10.Text = "0";
                label11.Text = "0";
            }
            */

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(208, 209, 209);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(150, 145, 79);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            Listele();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from stok_urun where id='" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            Listele();

        }

        private void Cıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
            anasayfa.Show();
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            UrunEkle urunEkle = new UrunEkle();
            urunEkle.Show();
            this.Close();
        }

        private void Grid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            comboBox2.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();

        }

        private void GnclBtn_Click(object sender, EventArgs e)
        {
        baglanti.Open();
        OleDbCommand komut = new OleDbCommand("update stok_urun set id='" + textBox1.Text + "',urunadi='" + textBox2.Text + "',urunturu='" + comboBox1.Text + "',uretimtar='" + dateTimePicker1.Text + "',urun_maliyet='" + textBox3.Text + "',urun_satis_fiyati='" + textBox4.Text + "',stok_adet='" + textBox5.Text + "',max_stok_kapasite='" + textBox6.Text + "',stok_durum='" + comboBox2.Text + "' where id = '" + textBox1.Text + "'", baglanti);
        komut.ExecuteNonQuery();
        baglanti.Close();
        tablo.Clear();
        Listele();
        MessageBox.Show("Güncellendi !");

        }
    }
}
