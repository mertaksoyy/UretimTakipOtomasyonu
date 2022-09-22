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
    public partial class UrunRecetesi : Form
    {
        OleDbConnection baglanti = new OleDbConnection(@"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\merta\Desktop\UretimAgaci son upload\UretimAgaci\Sistem Analizi Database.mdb");

        DataTable tablo = new DataTable();

        public void Listele()
        {
            baglanti.Open();
            OleDbDataAdapter adptr = new OleDbDataAdapter("SELECT malzeme_adi ,malzeme_adeti from " + comboBox1.Text + ";", baglanti);
            adptr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            baglanti.Close();
        }

        public UrunRecetesi()

        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UrunRecetesi_Load(object sender, EventArgs e)
        {

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


            // TODO: Bu kod satırı 'sistem_Analizi_DatabaseDataSet3.Gömlek' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.gömlekTableAdapter.Fill(this.sistem_Analizi_DatabaseDataSet3.Gömlek);
            OleDbConnection baglanti = new OleDbConnection();
            baglanti.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\merta\Desktop\UretimAgaci son upload\UretimAgaci\Sistem Analizi Database.mdb";
            OleDbCommand kmt = new OleDbCommand();
            kmt.CommandText = "SELECT * from stok_urun";
            kmt.Connection = baglanti;
            kmt.CommandType = CommandType.Text;
            OleDbDataReader dr;
            baglanti.Open();
            dr = kmt.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr["urunadi"]);
            }
            baglanti.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReceteDnzle receteDnzle = new ReceteDnzle();
            receteDnzle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReceteEkle receteEkle = new ReceteEkle();
            receteEkle.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection();
            baglanti.ConnectionString = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = C:\Users\merta\Desktop\UretimAgaci son upload\UretimAgaci\Sistem Analizi Database.mdb";
            OleDbCommand kmt = new OleDbCommand();
            //kmt.CommandText = "SELECT malzeme_adi ,malzeme_adeti from " + comboBox1.Text+ ";";
            kmt.CommandText = "SELECT malzeme_adi ,malzeme_adeti from " + comboBox1.Text + ";";
            kmt.Connection = baglanti;
            kmt.CommandType = CommandType.Text;
            DataTable dt = new DataTable();
            OleDbDataReader dr;
            baglanti.Open();
            dr = kmt.ExecuteReader();
            tablo.Clear();
            Listele();
           
            
        }
    }
}
