namespace Veritabani_15May_1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaglan = new System.Windows.Forms.Button();
            this.btnTumOgrenciler = new System.Windows.Forms.Button();
            this.textBoxSQLBağlanti = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxBolumAra = new System.Windows.Forms.TextBox();
            this.btnBolumAra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAdAra = new System.Windows.Forms.TextBox();
            this.btnAdAra = new System.Windows.Forms.Button();
            this.btnSirala = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxBolum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.textBoxOgrenciID = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(236, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÖĞRENCİ OTOMASYON SİSTEMİ";
            // 
            // btnBaglan
            // 
            this.btnBaglan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaglan.Location = new System.Drawing.Point(10, 66);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(141, 66);
            this.btnBaglan.TabIndex = 1;
            this.btnBaglan.Text = "SQL Bağlantısı Kur";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // btnTumOgrenciler
            // 
            this.btnTumOgrenciler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumOgrenciler.Location = new System.Drawing.Point(10, 12);
            this.btnTumOgrenciler.Name = "btnTumOgrenciler";
            this.btnTumOgrenciler.Size = new System.Drawing.Size(197, 122);
            this.btnTumOgrenciler.TabIndex = 2;
            this.btnTumOgrenciler.Text = "Tüm Öğrencileri Listele";
            this.btnTumOgrenciler.UseVisualStyleBackColor = true;
            this.btnTumOgrenciler.Click += new System.EventHandler(this.btnTumOgrenciler_Click);
            // 
            // textBoxSQLBağlanti
            // 
            this.textBoxSQLBağlanti.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSQLBağlanti.Location = new System.Drawing.Point(10, 30);
            this.textBoxSQLBağlanti.Name = "textBoxSQLBağlanti";
            this.textBoxSQLBağlanti.Size = new System.Drawing.Size(806, 30);
            this.textBoxSQLBağlanti.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "SQL Connection String";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(157, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "DURUM:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(226, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "bağlı değil";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBoxBolumAra);
            this.panel1.Controls.Add(this.btnBolumAra);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBoxAdAra);
            this.panel1.Controls.Add(this.btnAdAra);
            this.panel1.Controls.Add(this.btnSirala);
            this.panel1.Controls.Add(this.btnTumOgrenciler);
            this.panel1.Location = new System.Drawing.Point(12, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 431);
            this.panel1.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(619, 137);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Bölüme göre arama SQL Kodu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(413, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Sıralama SQL kodu";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(213, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Ada göre arama SQL Kodu";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(7, 137);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(171, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Tüm öğrecileri listeleyen SQL Kodu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 159);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(806, 258);
            this.dataGridView1.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(619, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Bölüm";
            // 
            // textBoxBolumAra
            // 
            this.textBoxBolumAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBolumAra.Location = new System.Drawing.Point(619, 32);
            this.textBoxBolumAra.Name = "textBoxBolumAra";
            this.textBoxBolumAra.Size = new System.Drawing.Size(197, 30);
            this.textBoxBolumAra.TabIndex = 8;
            // 
            // btnBolumAra
            // 
            this.btnBolumAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBolumAra.Location = new System.Drawing.Point(619, 68);
            this.btnBolumAra.Name = "btnBolumAra";
            this.btnBolumAra.Size = new System.Drawing.Size(197, 66);
            this.btnBolumAra.TabIndex = 7;
            this.btnBolumAra.Text = "Bölüm Öğrencilerini Getir";
            this.btnBolumAra.UseVisualStyleBackColor = true;
            this.btnBolumAra.Click += new System.EventHandler(this.btnBolumAra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(213, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ad";
            // 
            // textBoxAdAra
            // 
            this.textBoxAdAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAdAra.Location = new System.Drawing.Point(213, 32);
            this.textBoxAdAra.Name = "textBoxAdAra";
            this.textBoxAdAra.Size = new System.Drawing.Size(197, 30);
            this.textBoxAdAra.TabIndex = 5;
            // 
            // btnAdAra
            // 
            this.btnAdAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdAra.Location = new System.Drawing.Point(213, 68);
            this.btnAdAra.Name = "btnAdAra";
            this.btnAdAra.Size = new System.Drawing.Size(197, 66);
            this.btnAdAra.TabIndex = 3;
            this.btnAdAra.Text = "Öğrenci Ara";
            this.btnAdAra.UseVisualStyleBackColor = true;
            this.btnAdAra.Click += new System.EventHandler(this.btnAdAra_Click);
            // 
            // btnSirala
            // 
            this.btnSirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSirala.Location = new System.Drawing.Point(416, 12);
            this.btnSirala.Name = "btnSirala";
            this.btnSirala.Size = new System.Drawing.Size(197, 122);
            this.btnSirala.TabIndex = 2;
            this.btnSirala.Text = "En Genç Öğrenciyi Listele ";
            this.btnSirala.UseVisualStyleBackColor = true;
            this.btnSirala.Click += new System.EventHandler(this.btnSirala_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnBaglan);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxSQLBağlanti);
            this.panel2.Location = new System.Drawing.Point(12, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 144);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.textBoxBolum);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.dateTimePickerDogumTarihi);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.textBoxSoyad);
            this.panel3.Controls.Add(this.btnOgrenciEkle);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.textBoxAd);
            this.panel3.Location = new System.Drawing.Point(12, 624);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 144);
            this.panel3.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(392, 103);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(157, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Yeni Öğrenci Ekleme SQL kodu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(195, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Bölüm";
            // 
            // textBoxBolum
            // 
            this.textBoxBolum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxBolum.Location = new System.Drawing.Point(195, 86);
            this.textBoxBolum.Name = "textBoxBolum";
            this.textBoxBolum.Size = new System.Drawing.Size(191, 30);
            this.textBoxBolum.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(195, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Dogum Tarihi";
            // 
            // dateTimePickerDogumTarihi
            // 
            this.dateTimePickerDogumTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePickerDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDogumTarihi.Location = new System.Drawing.Point(195, 30);
            this.dateTimePickerDogumTarihi.Name = "dateTimePickerDogumTarihi";
            this.dateTimePickerDogumTarihi.Size = new System.Drawing.Size(191, 30);
            this.dateTimePickerDogumTarihi.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(7, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Soyad";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxSoyad.Location = new System.Drawing.Point(10, 86);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(169, 30);
            this.textBoxSoyad.TabIndex = 5;
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrenciEkle.Location = new System.Drawing.Point(392, 10);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(424, 90);
            this.btnOgrenciEkle.TabIndex = 1;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(7, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ad";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxAd.Location = new System.Drawing.Point(10, 30);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(169, 30);
            this.textBoxAd.TabIndex = 3;
            // 
            // textBoxOgrenciID
            // 
            this.textBoxOgrenciID.Location = new System.Drawing.Point(874, 61);
            this.textBoxOgrenciID.Name = "textBoxOgrenciID";
            this.textBoxOgrenciID.Size = new System.Drawing.Size(100, 20);
            this.textBoxOgrenciID.TabIndex = 10;
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(874, 87);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(100, 23);
            this.buttonSil.TabIndex = 11;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(874, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(58, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Öğrenci ID";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 549);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.buttonSil);
            this.Controls.Add(this.textBoxOgrenciID);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "VERİTABANI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBaglan;
        private System.Windows.Forms.Button btnTumOgrenciler;
        private System.Windows.Forms.TextBox textBoxSQLBağlanti;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxBolumAra;
        private System.Windows.Forms.Button btnBolumAra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxAdAra;
        private System.Windows.Forms.Button btnAdAra;
        private System.Windows.Forms.Button btnSirala;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxBolum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerDogumTarihi;
        private System.Windows.Forms.TextBox textBoxOgrenciID;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Label label16;
    }
}

