namespace TaksiDuragiOtomasyonu
{
    partial class ADMIN
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
            this.adSoyad = new System.Windows.Forms.Label();
            this.dtgecmis = new System.Windows.Forms.DataGridView();
            this.aracDurumuEsya = new System.Windows.Forms.Button();
            this.kasaDurumu = new System.Windows.Forms.Button();
            this.calisanEkle_IDsifre = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.dtaracsirasi = new System.Windows.Forms.DataGridView();
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.MusteriYeniKayit_silme = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtbildirim = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.aracgonder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgecmis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaracsirasi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbildirim)).BeginInit();
            this.SuspendLayout();
            // 
            // adSoyad
            // 
            this.adSoyad.AutoSize = true;
            this.adSoyad.Location = new System.Drawing.Point(23, 22);
            this.adSoyad.Name = "adSoyad";
            this.adSoyad.Size = new System.Drawing.Size(35, 13);
            this.adSoyad.TabIndex = 25;
            this.adSoyad.Text = "label1";
            // 
            // dtgecmis
            // 
            this.dtgecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgecmis.Location = new System.Drawing.Point(629, 129);
            this.dtgecmis.Name = "dtgecmis";
            this.dtgecmis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgecmis.Size = new System.Drawing.Size(617, 300);
            this.dtgecmis.TabIndex = 24;
            // 
            // aracDurumuEsya
            // 
            this.aracDurumuEsya.Location = new System.Drawing.Point(877, 26);
            this.aracDurumuEsya.Name = "aracDurumuEsya";
            this.aracDurumuEsya.Size = new System.Drawing.Size(189, 61);
            this.aracDurumuEsya.TabIndex = 16;
            this.aracDurumuEsya.Text = "Araçların Durumu - Unutulan Eşya";
            this.aracDurumuEsya.UseVisualStyleBackColor = true;
            this.aracDurumuEsya.Click += new System.EventHandler(this.aracDurumu_Click);
            // 
            // kasaDurumu
            // 
            this.kasaDurumu.Location = new System.Drawing.Point(593, 27);
            this.kasaDurumu.Name = "kasaDurumu";
            this.kasaDurumu.Size = new System.Drawing.Size(121, 60);
            this.kasaDurumu.TabIndex = 15;
            this.kasaDurumu.Text = "Kasa Durumu";
            this.kasaDurumu.UseVisualStyleBackColor = true;
            this.kasaDurumu.Click += new System.EventHandler(this.kasaDurumu_Click);
            // 
            // calisanEkle_IDsifre
            // 
            this.calisanEkle_IDsifre.Location = new System.Drawing.Point(375, 27);
            this.calisanEkle_IDsifre.Name = "calisanEkle_IDsifre";
            this.calisanEkle_IDsifre.Size = new System.Drawing.Size(212, 60);
            this.calisanEkle_IDsifre.TabIndex = 14;
            this.calisanEkle_IDsifre.Text = "Çalışan Ekle - Araç Kaydı - Kullanıcı adı ve Şifre Oluştur";
            this.calisanEkle_IDsifre.UseVisualStyleBackColor = true;
            this.calisanEkle_IDsifre.Click += new System.EventHandler(this.calisanEkle_Click);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(289, 26);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(80, 61);
            this.cikis.TabIndex = 13;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // dtaracsirasi
            // 
            this.dtaracsirasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtaracsirasi.Location = new System.Drawing.Point(26, 129);
            this.dtaracsirasi.Name = "dtaracsirasi";
            this.dtaracsirasi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtaracsirasi.Size = new System.Drawing.Size(243, 300);
            this.dtaracsirasi.TabIndex = 30;
            this.dtaracsirasi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtaracsirasi_CellClick);
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.Location = new System.Drawing.Point(1007, 458);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(239, 20);
            this.txtAdaGore.TabIndex = 31;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // MusteriYeniKayit_silme
            // 
            this.MusteriYeniKayit_silme.Location = new System.Drawing.Point(1072, 26);
            this.MusteriYeniKayit_silme.Name = "MusteriYeniKayit_silme";
            this.MusteriYeniKayit_silme.Size = new System.Drawing.Size(176, 61);
            this.MusteriYeniKayit_silme.TabIndex = 38;
            this.MusteriYeniKayit_silme.Text = "Müşteri Yeni Kayıt - Kayıt Silme";
            this.MusteriYeniKayit_silme.UseVisualStyleBackColor = true;
            this.MusteriYeniKayit_silme.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(26, 68);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 20);
            this.dateTimePicker1.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "ARAÇ SIRASI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(873, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "GEÇMİŞ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(368, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "SON ARAÇ ÇAĞRILARI";
            // 
            // dtbildirim
            // 
            this.dtbildirim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbildirim.Location = new System.Drawing.Point(285, 129);
            this.dtbildirim.Name = "dtbildirim";
            this.dtbildirim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtbildirim.Size = new System.Drawing.Size(328, 300);
            this.dtbildirim.TabIndex = 46;
            this.dtbildirim.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtbildirim_CellClick);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1011, 442);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 13);
            this.label17.TabIndex = 49;
            this.label17.Text = "ADA GÖRE ARAMA YAPIN";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(720, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 60);
            this.button1.TabIndex = 50;
            this.button1.Text = "İzin Talepleri-Bildiriler";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // aracgonder
            // 
            this.aracgonder.Location = new System.Drawing.Point(26, 437);
            this.aracgonder.Name = "aracgonder";
            this.aracgonder.Size = new System.Drawing.Size(243, 23);
            this.aracgonder.TabIndex = 51;
            this.aracgonder.Text = "SEÇİLİ ARACİ GÖNDER";
            this.aracgonder.UseVisualStyleBackColor = true;
            this.aracgonder.Click += new System.EventHandler(this.aracgonder_Click);
            // 
            // ADMIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1268, 499);
            this.Controls.Add(this.aracgonder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtbildirim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.MusteriYeniKayit_silme);
            this.Controls.Add(this.txtAdaGore);
            this.Controls.Add(this.dtaracsirasi);
            this.Controls.Add(this.adSoyad);
            this.Controls.Add(this.aracDurumuEsya);
            this.Controls.Add(this.kasaDurumu);
            this.Controls.Add(this.calisanEkle_IDsifre);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.dtgecmis);
            this.Name = "ADMIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMİN ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ADMIN_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgecmis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtaracsirasi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtbildirim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label adSoyad;
        private System.Windows.Forms.DataGridView dtgecmis;
        private System.Windows.Forms.Button aracDurumuEsya;
        private System.Windows.Forms.Button kasaDurumu;
        private System.Windows.Forms.Button calisanEkle_IDsifre;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.DataGridView dtaracsirasi;
        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.Button MusteriYeniKayit_silme;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtbildirim;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button aracgonder;
    }
}