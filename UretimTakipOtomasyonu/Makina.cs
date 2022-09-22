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
    public partial class Makina : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\merta\Desktop\UretimAgaci son upload\UretimAgaci\Sistem Analizi Database.mdb");
        DataTable tablo = new DataTable();


        public void Listele()
        {
            baglanti.Open();
            OleDbDataAdapter adptr = new OleDbDataAdapter("Select * from makine", baglanti);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        public Makina()
        {
            InitializeComponent();
        }

        private void Makina_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'sistem_Analizi_DatabaseDataSet.makine' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.makineTableAdapter.Fill(this.sistem_Analizi_DatabaseDataSet.makine);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(221, 236, 245);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(250, 150, 150);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            Listele(); 

        }

        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            MakinaEkle makinaEkle = new MakinaEkle();
            makinaEkle.Show();
        }

        private void SilBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("delete from makine where id='" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            Listele();

        }

        private void GnclBtn_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("update makine set id='" + textBox1.Text + "',adi='" + textBox2.Text + "',islevi='" + comboBox1.Text + "',kullanimda='" + comboBox2.Text + "',son_muayne_tar='" + dateTimePicker1.Text + "',fiyat='" + textBox3.Text + "',adet='" + textBox4.Text + "',gunluk_kapasite='" + textBox5.Text + "' where id = '" + textBox1.Text + "'", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            tablo.Clear();
            Listele();
            MessageBox.Show("Güncellendi !");
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
                textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                comboBox2.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            }

        private void Cıkıs_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == dataGridView1.Columns["kullanimda"].Index)

        //    {

        //        dataGridView1.EndEdit();  //Stop editing of cell.

        //        if ((bool)dataGridView1.Rows[e.RowIndex].Cells["kullanimda"].Value)

        //            MessageBox.Show("İşlem Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //        else

        //            MessageBox.Show("Artık Kullanılmıyor Olacak", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //    }
        //}
    }
}
