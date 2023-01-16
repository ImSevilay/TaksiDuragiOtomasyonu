namespace TaksiDuragiOtomasyonu
{
    partial class CALİSANEKLE
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
            this.geri = new System.Windows.Forms.Button();
            this.calisanekledt = new System.Windows.Forms.DataGridView();
            this.calisanEkle = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.saglikdurumu = new System.Windows.Forms.ComboBox();
            this.ehliyet = new System.Windows.Forms.ComboBox();
            this.kadin = new System.Windows.Forms.RadioButton();
            this.erkek = new System.Windows.Forms.RadioButton();
            this.eposta = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.MaskedTextBox();
            this.tckimlik = new System.Windows.Forms.MaskedTextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.temizle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.guncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.kullaniciAdi = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.txtSiraNo = new System.Windows.Forms.TextBox();
            this.sifre = new System.Windows.Forms.TextBox();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.plaka = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.txtaracsirasi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.calisanekledt)).BeginInit();
            this.SuspendLayout();
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(12, 12);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(80, 30);
            this.geri.TabIndex = 77;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.button3_Click);
            // 
            // calisanekledt
            // 
            this.calisanekledt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calisanekledt.Location = new System.Drawing.Point(277, 53);
            this.calisanekledt.Name = "calisanekledt";
            this.calisanekledt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.calisanekledt.Size = new System.Drawing.Size(769, 386);
            this.calisanekledt.TabIndex = 75;
            this.calisanekledt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calisanekledt_CellClick);
            this.calisanekledt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.calisanekledt_CellContentClick);
            // 
            // calisanEkle
            // 
            this.calisanEkle.Location = new System.Drawing.Point(144, 391);
            this.calisanEkle.Name = "calisanEkle";
            this.calisanEkle.Size = new System.Drawing.Size(128, 36);
            this.calisanEkle.TabIndex = 74;
            this.calisanEkle.Text = "Çalışan Ekle";
            this.calisanEkle.UseVisualStyleBackColor = true;
            this.calisanEkle.Click += new System.EventHandler(this.calisanEkle_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(13, 235);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 13);
            this.label14.TabIndex = 73;
            this.label14.Text = "Sağlık Durumu";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 211);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 72;
            this.label13.Text = "Ehliyet Sınıfı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 71;
            this.label12.Text = "Cinsiyet";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 166);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 70;
            this.label11.Text = "E-Posta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Telefon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Soyad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Ad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "TC Kimlik";
            // 
            // saglikdurumu
            // 
            this.saglikdurumu.FormattingEnabled = true;
            this.saglikdurumu.Location = new System.Drawing.Point(96, 233);
            this.saglikdurumu.Name = "saglikdurumu";
            this.saglikdurumu.Size = new System.Drawing.Size(176, 21);
            this.saglikdurumu.TabIndex = 65;
            // 
            // ehliyet
            // 
            this.ehliyet.FormattingEnabled = true;
            this.ehliyet.Location = new System.Drawing.Point(96, 206);
            this.ehliyet.Name = "ehliyet";
            this.ehliyet.Size = new System.Drawing.Size(176, 21);
            this.ehliyet.TabIndex = 64;
            // 
            // kadin
            // 
            this.kadin.AutoSize = true;
            this.kadin.Location = new System.Drawing.Point(187, 183);
            this.kadin.Name = "kadin";
            this.kadin.Size = new System.Drawing.Size(52, 17);
            this.kadin.TabIndex = 63;
            this.kadin.TabStop = true;
            this.kadin.Text = "Kadın";
            this.kadin.UseVisualStyleBackColor = true;
            // 
            // erkek
            // 
            this.erkek.AutoSize = true;
            this.erkek.Location = new System.Drawing.Point(96, 183);
            this.erkek.Name = "erkek";
            this.erkek.Size = new System.Drawing.Size(53, 17);
            this.erkek.TabIndex = 62;
            this.erkek.TabStop = true;
            this.erkek.Text = "Erkek";
            this.erkek.UseVisualStyleBackColor = true;
            // 
            // eposta
            // 
            this.eposta.Location = new System.Drawing.Point(95, 157);
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(176, 20);
            this.eposta.TabIndex = 61;
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(95, 131);
            this.telefon.Mask = "(999) 000-0000";
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(176, 20);
            this.telefon.TabIndex = 60;
            // 
            // tckimlik
            // 
            this.tckimlik.Location = new System.Drawing.Point(95, 53);
            this.tckimlik.Mask = "00000000000";
            this.tckimlik.Name = "tckimlik";
            this.tckimlik.Size = new System.Drawing.Size(176, 20);
            this.tckimlik.TabIndex = 59;
            this.tckimlik.Click += new System.EventHandler(this.tckimlik_Click);
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(95, 79);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(176, 20);
            this.ad.TabIndex = 57;
            // 
            // temizle
            // 
            this.temizle.Location = new System.Drawing.Point(9, 391);
            this.temizle.Name = "temizle";
            this.temizle.Size = new System.Drawing.Size(127, 36);
            this.temizle.TabIndex = 78;
            this.temizle.Text = "Temizle";
            this.temizle.UseVisualStyleBackColor = true;
            this.temizle.Click += new System.EventHandler(this.temizle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(145, 436);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(127, 34);
            this.sil.TabIndex = 79;
            this.sil.Text = "Seçili Kaydı Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // guncelle
            // 
            this.guncelle.Location = new System.Drawing.Point(9, 436);
            this.guncelle.Name = "guncelle";
            this.guncelle.Size = new System.Drawing.Size(128, 34);
            this.guncelle.TabIndex = 80;
            this.guncelle.Text = "Seçili Kaydı Güncelle";
            this.guncelle.UseVisualStyleBackColor = true;
            this.guncelle.Click += new System.EventHandler(this.guncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 84;
            this.label1.Text = "Doğum Tarihi";
            // 
            // dogumTarihi
            // 
            this.dogumTarihi.Location = new System.Drawing.Point(96, 260);
            this.dogumTarihi.Mask = "00/00/0000";
            this.dogumTarihi.Name = "dogumTarihi";
            this.dogumTarihi.Size = new System.Drawing.Size(176, 20);
            this.dogumTarihi.TabIndex = 85;
            this.dogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "şifre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 92;
            this.label2.Text = "kullanıcı adı";
            // 
            // kullaniciAdi
            // 
            this.kullaniciAdi.Location = new System.Drawing.Point(96, 286);
            this.kullaniciAdi.Name = "kullaniciAdi";
            this.kullaniciAdi.Size = new System.Drawing.Size(176, 20);
            this.kullaniciAdi.TabIndex = 100;
            this.kullaniciAdi.Click += new System.EventHandler(this.kullaniciAdi_Click);
            // 
            // soyad
            // 
            this.soyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.soyad.Location = new System.Drawing.Point(95, 105);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(176, 20);
            this.soyad.TabIndex = 101;
            // 
            // txtSiraNo
            // 
            this.txtSiraNo.Location = new System.Drawing.Point(95, 22);
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.Size = new System.Drawing.Size(176, 20);
            this.txtSiraNo.TabIndex = 104;
            // 
            // sifre
            // 
            this.sifre.Location = new System.Drawing.Point(96, 312);
            this.sifre.Name = "sifre";
            this.sifre.Size = new System.Drawing.Size(175, 20);
            this.sifre.TabIndex = 105;
            this.sifre.Click += new System.EventHandler(this.sifre_Click);
            // 
            // tarih
            // 
            this.tarih.Location = new System.Drawing.Point(96, 365);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(176, 20);
            this.tarih.TabIndex = 115;
            // 
            // plaka
            // 
            this.plaka.Location = new System.Drawing.Point(96, 338);
            this.plaka.Name = "plaka";
            this.plaka.Size = new System.Drawing.Size(176, 20);
            this.plaka.TabIndex = 114;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 367);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 113;
            this.label4.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 112;
            this.label5.Text = "Araç Plakası";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(816, 464);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 13);
            this.label17.TabIndex = 117;
            this.label17.Text = "ADA GÖRE ARAMA YAPIN";
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.Location = new System.Drawing.Point(814, 480);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(233, 20);
            this.txtAdaGore.TabIndex = 116;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.txtAdaGore_TextChanged);
            // 
            // txtaracsirasi
            // 
            this.txtaracsirasi.Location = new System.Drawing.Point(277, 22);
            this.txtaracsirasi.Name = "txtaracsirasi";
            this.txtaracsirasi.Size = new System.Drawing.Size(176, 20);
            this.txtaracsirasi.TabIndex = 118;
            // 
            // CALİSANEKLE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 512);
            this.Controls.Add(this.txtaracsirasi);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtAdaGore);
            this.Controls.Add(this.tarih);
            this.Controls.Add(this.plaka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sifre);
            this.Controls.Add(this.txtSiraNo);
            this.Controls.Add(this.soyad);
            this.Controls.Add(this.kullaniciAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dogumTarihi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guncelle);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.temizle);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.calisanekledt);
            this.Controls.Add(this.calisanEkle);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.saglikdurumu);
            this.Controls.Add(this.ehliyet);
            this.Controls.Add(this.kadin);
            this.Controls.Add(this.erkek);
            this.Controls.Add(this.eposta);
            this.Controls.Add(this.telefon);
            this.Controls.Add(this.tckimlik);
            this.Controls.Add(this.ad);
            this.Name = "CALİSANEKLE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ÇALIŞAN EKLE";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CALİSANEKLE_FormClosed);
            this.Load += new System.EventHandler(this.CALİSANEKLE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calisanekledt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.DataGridView calisanekledt;
        private System.Windows.Forms.Button calisanEkle;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox saglikdurumu;
        private System.Windows.Forms.ComboBox ehliyet;
        private System.Windows.Forms.RadioButton kadin;
        private System.Windows.Forms.RadioButton erkek;
        private System.Windows.Forms.TextBox eposta;
        private System.Windows.Forms.MaskedTextBox telefon;
        private System.Windows.Forms.MaskedTextBox tckimlik;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.Button temizle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Button guncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox dogumTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox kullaniciAdi;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox txtSiraNo;
        private System.Windows.Forms.TextBox sifre;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.TextBox plaka;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.TextBox txtaracsirasi;
    }
}