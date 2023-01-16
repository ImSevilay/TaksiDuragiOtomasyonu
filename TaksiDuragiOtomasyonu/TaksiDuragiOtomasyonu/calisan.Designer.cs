namespace TaksiDuragiOtomasyonu
{
    partial class CALİSAN
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
            this.cikis = new System.Windows.Forms.Button();
            this.txtAdaGore = new System.Windows.Forms.TextBox();
            this.izinTalebi = new System.Windows.Forms.Button();
            this.bitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.baslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.izinNedeni = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.soyadIzin = new System.Windows.Forms.TextBox();
            this.adIzin = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bildiri = new System.Windows.Forms.RichTextBox();
            this.bildirisoyad = new System.Windows.Forms.TextBox();
            this.bildiriad = new System.Windows.Forms.TextBox();
            this.gonder = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bildirimcalisandt = new System.Windows.Forms.DataGridView();
            this.siraNo = new System.Windows.Forms.TextBox();
            this.adresEkle = new System.Windows.Forms.RichTextBox();
            this.telefonEkle = new System.Windows.Forms.MaskedTextBox();
            this.aracPlakaEkle = new System.Windows.Forms.TextBox();
            this.soyadEkle = new System.Windows.Forms.TextBox();
            this.adEkle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Kayit = new System.Windows.Forms.Button();
            this.dtkayit = new System.Windows.Forms.DataGridView();
            this.sil = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bildirimcalisandt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtkayit)).BeginInit();
            this.SuspendLayout();
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(242, 12);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(70, 36);
            this.cikis.TabIndex = 2;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAdaGore
            // 
            this.txtAdaGore.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtAdaGore.Location = new System.Drawing.Point(724, 327);
            this.txtAdaGore.Name = "txtAdaGore";
            this.txtAdaGore.Size = new System.Drawing.Size(233, 20);
            this.txtAdaGore.TabIndex = 17;
            this.txtAdaGore.TextChanged += new System.EventHandler(this.txtAdaGore_TextChanged);
            // 
            // izinTalebi
            // 
            this.izinTalebi.Location = new System.Drawing.Point(158, 185);
            this.izinTalebi.Name = "izinTalebi";
            this.izinTalebi.Size = new System.Drawing.Size(93, 28);
            this.izinTalebi.TabIndex = 26;
            this.izinTalebi.Text = "İzin Talebi";
            this.izinTalebi.UseVisualStyleBackColor = true;
            this.izinTalebi.Click += new System.EventHandler(this.izinTalebi_Click);
            // 
            // bitisTarihi
            // 
            this.bitisTarihi.Location = new System.Drawing.Point(102, 159);
            this.bitisTarihi.Name = "bitisTarihi";
            this.bitisTarihi.Size = new System.Drawing.Size(149, 20);
            this.bitisTarihi.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.baslangicTarihi);
            this.groupBox1.Controls.Add(this.izinNedeni);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.bitisTarihi);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.izinTalebi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.soyadIzin);
            this.groupBox1.Controls.Add(this.adIzin);
            this.groupBox1.Location = new System.Drawing.Point(15, 363);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 219);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İzin Talebi";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(14, 130);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 13);
            this.label15.TabIndex = 43;
            this.label15.Text = "Başlangıç Tarihi";
            // 
            // baslangicTarihi
            // 
            this.baslangicTarihi.Location = new System.Drawing.Point(102, 130);
            this.baslangicTarihi.Name = "baslangicTarihi";
            this.baslangicTarihi.Size = new System.Drawing.Size(149, 20);
            this.baslangicTarihi.TabIndex = 41;
            this.baslangicTarihi.Value = new System.DateTime(2023, 1, 5, 0, 0, 0, 0);
            // 
            // izinNedeni
            // 
            this.izinNedeni.Location = new System.Drawing.Point(102, 68);
            this.izinNedeni.Name = "izinNedeni";
            this.izinNedeni.Size = new System.Drawing.Size(149, 52);
            this.izinNedeni.TabIndex = 40;
            this.izinNedeni.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Bitiş Tarihi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Soyad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Ad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "izin nedeni";
            // 
            // soyadIzin
            // 
            this.soyadIzin.Location = new System.Drawing.Point(104, 42);
            this.soyadIzin.Name = "soyadIzin";
            this.soyadIzin.Size = new System.Drawing.Size(147, 20);
            this.soyadIzin.TabIndex = 30;
            // 
            // adIzin
            // 
            this.adIzin.Location = new System.Drawing.Point(104, 16);
            this.adIzin.Name = "adIzin";
            this.adIzin.Size = new System.Drawing.Size(147, 20);
            this.adIzin.TabIndex = 29;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bildiri);
            this.groupBox2.Controls.Add(this.bildirisoyad);
            this.groupBox2.Controls.Add(this.bildiriad);
            this.groupBox2.Controls.Add(this.gonder);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(278, 365);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 219);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bildiride Bulun";
            // 
            // bildiri
            // 
            this.bildiri.Location = new System.Drawing.Point(58, 75);
            this.bildiri.Name = "bildiri";
            this.bildiri.Size = new System.Drawing.Size(158, 96);
            this.bildiri.TabIndex = 47;
            this.bildiri.Text = "";
            // 
            // bildirisoyad
            // 
            this.bildirisoyad.Location = new System.Drawing.Point(58, 48);
            this.bildirisoyad.Name = "bildirisoyad";
            this.bildirisoyad.Size = new System.Drawing.Size(158, 20);
            this.bildirisoyad.TabIndex = 46;
            // 
            // bildiriad
            // 
            this.bildiriad.Location = new System.Drawing.Point(58, 22);
            this.bildiriad.Name = "bildiriad";
            this.bildiriad.Size = new System.Drawing.Size(158, 20);
            this.bildiriad.TabIndex = 45;
            // 
            // gonder
            // 
            this.gonder.Location = new System.Drawing.Point(123, 177);
            this.gonder.Name = "gonder";
            this.gonder.Size = new System.Drawing.Size(93, 28);
            this.gonder.TabIndex = 30;
            this.gonder.Text = "Gönder";
            this.gonder.UseVisualStyleBackColor = true;
            this.gonder.Click += new System.EventHandler(this.gonder_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "Soyad";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Ad";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(11, 121);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Bildiri";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(704, 365);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(75, 13);
            this.label16.TabIndex = 31;
            this.label16.Text = "BİLDİRİMLER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(17, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "label6";
            // 
            // bildirimcalisandt
            // 
            this.bildirimcalisandt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bildirimcalisandt.Location = new System.Drawing.Point(523, 387);
            this.bildirimcalisandt.Name = "bildirimcalisandt";
            this.bildirimcalisandt.Size = new System.Drawing.Size(434, 197);
            this.bildirimcalisandt.TabIndex = 36;
            this.bildirimcalisandt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bildirimcalisandt_CellClick);
            // 
            // siraNo
            // 
            this.siraNo.Location = new System.Drawing.Point(92, 21);
            this.siraNo.Name = "siraNo";
            this.siraNo.Size = new System.Drawing.Size(144, 20);
            this.siraNo.TabIndex = 59;
            // 
            // adresEkle
            // 
            this.adresEkle.Location = new System.Drawing.Point(168, 166);
            this.adresEkle.Name = "adresEkle";
            this.adresEkle.Size = new System.Drawing.Size(144, 62);
            this.adresEkle.TabIndex = 58;
            this.adresEkle.Text = "";
            // 
            // telefonEkle
            // 
            this.telefonEkle.Location = new System.Drawing.Point(168, 130);
            this.telefonEkle.Mask = "(999) 000-0000";
            this.telefonEkle.Name = "telefonEkle";
            this.telefonEkle.Size = new System.Drawing.Size(144, 20);
            this.telefonEkle.TabIndex = 56;
            // 
            // aracPlakaEkle
            // 
            this.aracPlakaEkle.Location = new System.Drawing.Point(168, 238);
            this.aracPlakaEkle.Name = "aracPlakaEkle";
            this.aracPlakaEkle.Size = new System.Drawing.Size(144, 20);
            this.aracPlakaEkle.TabIndex = 55;
            // 
            // soyadEkle
            // 
            this.soyadEkle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.soyadEkle.Location = new System.Drawing.Point(168, 96);
            this.soyadEkle.Name = "soyadEkle";
            this.soyadEkle.Size = new System.Drawing.Size(144, 20);
            this.soyadEkle.TabIndex = 54;
            // 
            // adEkle
            // 
            this.adEkle.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.adEkle.Location = new System.Drawing.Point(168, 60);
            this.adEkle.Name = "adEkle";
            this.adEkle.Size = new System.Drawing.Size(144, 20);
            this.adEkle.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "MÜŞTERİ AD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "MÜŞTERİ SOYAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 64;
            this.label3.Text = "MÜŞTERİ TELEFON";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 13);
            this.label4.TabIndex = 65;
            this.label4.Text = "GİDİLECEK ADRES";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 13);
            this.label5.TabIndex = 66;
            this.label5.Text = "GİDEN ARACIN PLAKASI";
            // 
            // Kayit
            // 
            this.Kayit.Location = new System.Drawing.Point(221, 305);
            this.Kayit.Name = "Kayit";
            this.Kayit.Size = new System.Drawing.Size(92, 30);
            this.Kayit.TabIndex = 67;
            this.Kayit.Text = "Kayıt Ekle";
            this.Kayit.UseVisualStyleBackColor = true;
            this.Kayit.Click += new System.EventHandler(this.Kayit_Click);
            // 
            // dtkayit
            // 
            this.dtkayit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtkayit.ColumnHeadersVisible = false;
            this.dtkayit.Location = new System.Drawing.Point(318, 12);
            this.dtkayit.Name = "dtkayit";
            this.dtkayit.Size = new System.Drawing.Size(639, 290);
            this.dtkayit.TabIndex = 117;
            this.dtkayit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtkayit_CellClick);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(350, 305);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(93, 30);
            this.sil.TabIndex = 118;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(721, 305);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(139, 13);
            this.label17.TabIndex = 120;
            this.label17.Text = "ADA GÖRE ARAMA YAPIN";
            // 
            // CALİSAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(977, 608);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.dtkayit);
            this.Controls.Add(this.Kayit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siraNo);
            this.Controls.Add(this.adresEkle);
            this.Controls.Add(this.telefonEkle);
            this.Controls.Add(this.aracPlakaEkle);
            this.Controls.Add(this.soyadEkle);
            this.Controls.Add(this.adEkle);
            this.Controls.Add(this.bildirimcalisandt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtAdaGore);
            this.Controls.Add(this.cikis);
            this.Name = "CALİSAN";
            this.Text = "ÇALIŞAN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CALİSAN_FormClosed);
            this.Load += new System.EventHandler(this.CALİSAN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bildirimcalisandt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtkayit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.TextBox txtAdaGore;
        private System.Windows.Forms.Button izinTalebi;
        private System.Windows.Forms.DateTimePicker bitisTarihi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox soyadIzin;
        private System.Windows.Forms.TextBox adIzin;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button gonder;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox bildirisoyad;
        private System.Windows.Forms.TextBox bildiriad;
       // private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.RichTextBox izinNedeni;
        private System.Windows.Forms.RichTextBox bildiri;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView bildirimcalisandt;
        private System.Windows.Forms.TextBox siraNo;
        private System.Windows.Forms.RichTextBox adresEkle;
        //private System.Windows.Forms.Button kayitEkle;
        private System.Windows.Forms.MaskedTextBox telefonEkle;
        private System.Windows.Forms.TextBox aracPlakaEkle;
        private System.Windows.Forms.TextBox soyadEkle;
        private System.Windows.Forms.TextBox adEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Kayit;
        private System.Windows.Forms.DataGridView dtkayit;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.DateTimePicker baslangicTarihi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
    }
}