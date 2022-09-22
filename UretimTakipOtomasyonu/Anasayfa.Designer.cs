namespace UretimAgaci
{
    partial class AnaMenu
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.StokTkb = new System.Windows.Forms.Button();
            this.UrunYrt = new System.Windows.Forms.Button();
            this.UrunRct = new System.Windows.Forms.Button();
            this.PersonelBilg = new System.Windows.Forms.Button();
            this.Makİs = new System.Windows.Forms.Button();
            this.DurumRapor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StokTkb
            // 
            this.StokTkb.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StokTkb.Location = new System.Drawing.Point(119, 78);
            this.StokTkb.Name = "StokTkb";
            this.StokTkb.Size = new System.Drawing.Size(110, 55);
            this.StokTkb.TabIndex = 1;
            this.StokTkb.Text = "Stok Takibi";
            this.StokTkb.UseVisualStyleBackColor = true;
            this.StokTkb.Click += new System.EventHandler(this.button1_Click);
            // 
            // UrunYrt
            // 
            this.UrunYrt.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunYrt.Location = new System.Drawing.Point(263, 78);
            this.UrunYrt.Name = "UrunYrt";
            this.UrunYrt.Size = new System.Drawing.Size(110, 55);
            this.UrunYrt.TabIndex = 2;
            this.UrunYrt.Text = "Ürün Yarat";
            this.UrunYrt.UseVisualStyleBackColor = true;
            this.UrunYrt.Click += new System.EventHandler(this.button2_Click);
            // 
            // UrunRct
            // 
            this.UrunRct.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.UrunRct.Location = new System.Drawing.Point(119, 164);
            this.UrunRct.Name = "UrunRct";
            this.UrunRct.Size = new System.Drawing.Size(110, 55);
            this.UrunRct.TabIndex = 3;
            this.UrunRct.Text = "Ürün Reçete İşlemleri";
            this.UrunRct.UseVisualStyleBackColor = true;
            this.UrunRct.Click += new System.EventHandler(this.button3_Click);
            // 
            // PersonelBilg
            // 
            this.PersonelBilg.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PersonelBilg.Location = new System.Drawing.Point(263, 164);
            this.PersonelBilg.Name = "PersonelBilg";
            this.PersonelBilg.Size = new System.Drawing.Size(110, 55);
            this.PersonelBilg.TabIndex = 4;
            this.PersonelBilg.Text = "Personel İşlemleri";
            this.PersonelBilg.UseVisualStyleBackColor = true;
            this.PersonelBilg.Click += new System.EventHandler(this.button4_Click);
            // 
            // Makİs
            // 
            this.Makİs.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Makİs.Location = new System.Drawing.Point(119, 262);
            this.Makİs.Name = "Makİs";
            this.Makİs.Size = new System.Drawing.Size(110, 55);
            this.Makİs.TabIndex = 5;
            this.Makİs.Text = "Makina İşlemleri";
            this.Makİs.UseVisualStyleBackColor = true;
            this.Makİs.Click += new System.EventHandler(this.button5_Click);
            // 
            // DurumRapor
            // 
            this.DurumRapor.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DurumRapor.Location = new System.Drawing.Point(263, 262);
            this.DurumRapor.Name = "DurumRapor";
            this.DurumRapor.Size = new System.Drawing.Size(110, 55);
            this.DurumRapor.TabIndex = 6;
            this.DurumRapor.Text = "Durum Raporu";
            this.DurumRapor.UseVisualStyleBackColor = true;
            this.DurumRapor.Click += new System.EventHandler(this.button6_Click);
            // 
            // AnaMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 414);
            this.Controls.Add(this.DurumRapor);
            this.Controls.Add(this.Makİs);
            this.Controls.Add(this.PersonelBilg);
            this.Controls.Add(this.UrunRct);
            this.Controls.Add(this.UrunYrt);
            this.Controls.Add(this.StokTkb);
            this.Name = "AnaMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainInterface";
            this.Load += new System.EventHandler(this.AnaMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button StokTkb;
        private System.Windows.Forms.Button UrunYrt;
        private System.Windows.Forms.Button UrunRct;
        private System.Windows.Forms.Button PersonelBilg;
        private System.Windows.Forms.Button Makİs;
        private System.Windows.Forms.Button DurumRapor;
    }
}

