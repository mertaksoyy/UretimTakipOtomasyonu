namespace UretimAgaci
{
    partial class UrunRecetesi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sistem_Analizi_DatabaseDataSet3 = new UretimAgaci.Sistem_Analizi_DatabaseDataSet3();
            this.gömlekBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gömlekTableAdapter = new UretimAgaci.Sistem_Analizi_DatabaseDataSet3TableAdapters.GömlekTableAdapter();
            this.malzeme_adeti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzeme_adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistem_Analizi_DatabaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gömlekBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(28, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(301, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 321);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "REÇETE BİLGİLERİ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Malzeme Listesi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ÜRÜN SEÇİNİZ ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(251, 55);
            this.button1.TabIndex = 3;
            this.button1.Text = "REÇETE DÜZENLE";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 217);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(251, 55);
            this.button2.TabIndex = 4;
            this.button2.Text = "REÇETE EKLE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(28, 278);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(251, 55);
            this.button3.TabIndex = 5;
            this.button3.Text = "KAPAT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.malzeme_adeti,
            this.malzeme_adi});
            this.dataGridView1.DataSource = this.gömlekBindingSource;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(6, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(443, 250);
            this.dataGridView1.TabIndex = 1;
            // 
            // sistem_Analizi_DatabaseDataSet3
            // 
            this.sistem_Analizi_DatabaseDataSet3.DataSetName = "Sistem_Analizi_DatabaseDataSet3";
            this.sistem_Analizi_DatabaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gömlekBindingSource
            // 
            this.gömlekBindingSource.DataMember = "Gömlek";
            this.gömlekBindingSource.DataSource = this.sistem_Analizi_DatabaseDataSet3;
            // 
            // gömlekTableAdapter
            // 
            this.gömlekTableAdapter.ClearBeforeFill = true;
            // 
            // malzeme_adeti
            // 
            this.malzeme_adeti.DataPropertyName = "malzeme_adeti";
            this.malzeme_adeti.HeaderText = "Malzeme Adedi";
            this.malzeme_adeti.Name = "malzeme_adeti";
            this.malzeme_adeti.Width = 250;
            // 
            // malzeme_adi
            // 
            this.malzeme_adi.DataPropertyName = "malzeme_adi";
            this.malzeme_adi.HeaderText = "Malzeme Adı";
            this.malzeme_adi.Name = "malzeme_adi";
            this.malzeme_adi.Width = 150;
            // 
            // UrunRecetesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 335);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Name = "UrunRecetesi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UrunRecetesi";
            this.Load += new System.EventHandler(this.UrunRecetesi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistem_Analizi_DatabaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gömlekBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Sistem_Analizi_DatabaseDataSet3 sistem_Analizi_DatabaseDataSet3;
        private System.Windows.Forms.BindingSource gömlekBindingSource;
        private Sistem_Analizi_DatabaseDataSet3TableAdapters.GömlekTableAdapter gömlekTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzeme_adeti;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzeme_adi;
    }
}