namespace TaksiDuragiOtomasyonu
{
    partial class GİRİS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GİRİS));
            this.kullanici_Girisi = new System.Windows.Forms.TabControl();
            this.adminGirisi = new System.Windows.Forms.TabPage();
            this.adminGiris = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.adminSifre = new System.Windows.Forms.TextBox();
            this.adminK = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.calisanGiris = new System.Windows.Forms.Button();
            this.calisanSifre = new System.Windows.Forms.TextBox();
            this.calisanK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.musteriGirisi = new System.Windows.Forms.TabPage();
            this.musteriGiris = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.musteriSifre = new System.Windows.Forms.TextBox();
            this.musteriK = new System.Windows.Forms.TextBox();
            this.kayitOl = new System.Windows.Forms.TabPage();
            this.guvenlikKodu = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label19 = new System.Windows.Forms.Label();
            this.txtGuvenlikKodu = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.parolatekrar = new System.Windows.Forms.TextBox();
            this.parola = new System.Windows.Forms.TextBox();
            this.kullaniciadi = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.kayit_ol = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.eposta = new System.Windows.Forms.TextBox();
            this.soyad = new System.Windows.Forms.TextBox();
            this.ad = new System.Windows.Forms.TextBox();
            this.telefon = new System.Windows.Forms.MaskedTextBox();
            this.tckimlik = new System.Windows.Forms.MaskedTextBox();
            this.kullanici_Girisi.SuspendLayout();
            this.adminGirisi.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.musteriGirisi.SuspendLayout();
            this.kayitOl.SuspendLayout();
            this.SuspendLayout();
            // 
            // kullanici_Girisi
            // 
            this.kullanici_Girisi.Controls.Add(this.adminGirisi);
            this.kullanici_Girisi.Controls.Add(this.tabPage1);
            this.kullanici_Girisi.Controls.Add(this.musteriGirisi);
            this.kullanici_Girisi.Controls.Add(this.kayitOl);
            this.kullanici_Girisi.Location = new System.Drawing.Point(0, 0);
            this.kullanici_Girisi.Name = "kullanici_Girisi";
            this.kullanici_Girisi.SelectedIndex = 0;
            this.kullanici_Girisi.Size = new System.Drawing.Size(351, 416);
            this.kullanici_Girisi.TabIndex = 1;
            // 
            // adminGirisi
            // 
            this.adminGirisi.BackColor = System.Drawing.Color.Gold;
            this.adminGirisi.Controls.Add(this.adminGiris);
            this.adminGirisi.Controls.Add(this.label2);
            this.adminGirisi.Controls.Add(this.label1);
            this.adminGirisi.Controls.Add(this.adminSifre);
            this.adminGirisi.Controls.Add(this.adminK);
            this.adminGirisi.Location = new System.Drawing.Point(4, 22);
            this.adminGirisi.Name = "adminGirisi";
            this.adminGirisi.Padding = new System.Windows.Forms.Padding(3);
            this.adminGirisi.Size = new System.Drawing.Size(343, 390);
            this.adminGirisi.TabIndex = 0;
            this.adminGirisi.Text = "Admin Girişi";
            // 
            // adminGiris
            // 
            this.adminGiris.Location = new System.Drawing.Point(110, 209);
            this.adminGiris.Name = "adminGiris";
            this.adminGiris.Size = new System.Drawing.Size(86, 52);
            this.adminGiris.TabIndex = 4;
            this.adminGiris.Text = "Giriş";
            this.adminGiris.UseVisualStyleBackColor = true;
            this.adminGiris.Click += new System.EventHandler(this.adminGiris_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Şifre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // adminSifre
            // 
            this.adminSifre.Location = new System.Drawing.Point(108, 155);
            this.adminSifre.Name = "adminSifre";
            this.adminSifre.Size = new System.Drawing.Size(187, 20);
            this.adminSifre.TabIndex = 1;
            this.adminSifre.Text = "123456    ";
            this.adminSifre.UseSystemPasswordChar = true;
            // 
            // adminK
            // 
            this.adminK.Location = new System.Drawing.Point(108, 118);
            this.adminK.Name = "adminK";
            this.adminK.Size = new System.Drawing.Size(187, 20);
            this.adminK.TabIndex = 0;
            this.adminK.Text = "40583726154";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gold;
            this.tabPage1.Controls.Add(this.calisanGiris);
            this.tabPage1.Controls.Add(this.calisanSifre);
            this.tabPage1.Controls.Add(this.calisanK);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(343, 390);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Çalışan Girişi";
            // 
            // calisanGiris
            // 
            this.calisanGiris.Location = new System.Drawing.Point(110, 209);
            this.calisanGiris.Name = "calisanGiris";
            this.calisanGiris.Size = new System.Drawing.Size(86, 52);
            this.calisanGiris.TabIndex = 4;
            this.calisanGiris.Text = "Giriş";
            this.calisanGiris.UseVisualStyleBackColor = true;
            this.calisanGiris.Click += new System.EventHandler(this.calisanGiris_Click);
            // 
            // calisanSifre
            // 
            this.calisanSifre.Location = new System.Drawing.Point(108, 155);
            this.calisanSifre.Name = "calisanSifre";
            this.calisanSifre.Size = new System.Drawing.Size(187, 20);
            this.calisanSifre.TabIndex = 3;
            this.calisanSifre.Text = "EON571bkw";
            this.calisanSifre.UseSystemPasswordChar = true;
            // 
            // calisanK
            // 
            this.calisanK.Location = new System.Drawing.Point(108, 118);
            this.calisanK.Name = "calisanK";
            this.calisanK.Size = new System.Drawing.Size(187, 20);
            this.calisanK.TabIndex = 2;
            this.calisanK.Text = "14725836910";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Şifre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kullanıcı Adı";
            // 
            // musteriGirisi
            // 
            this.musteriGirisi.BackColor = System.Drawing.Color.Teal;
            this.musteriGirisi.Controls.Add(this.musteriGiris);
            this.musteriGirisi.Controls.Add(this.label4);
            this.musteriGirisi.Controls.Add(this.label3);
            this.musteriGirisi.Controls.Add(this.musteriSifre);
            this.musteriGirisi.Controls.Add(this.musteriK);
            this.musteriGirisi.Location = new System.Drawing.Point(4, 22);
            this.musteriGirisi.Name = "musteriGirisi";
            this.musteriGirisi.Padding = new System.Windows.Forms.Padding(3);
            this.musteriGirisi.Size = new System.Drawing.Size(343, 390);
            this.musteriGirisi.TabIndex = 1;
            this.musteriGirisi.Text = "Müşteri Girişi";
            // 
            // musteriGiris
            // 
            this.musteriGiris.Location = new System.Drawing.Point(110, 209);
            this.musteriGiris.Name = "musteriGiris";
            this.musteriGiris.Size = new System.Drawing.Size(86, 52);
            this.musteriGiris.TabIndex = 4;
            this.musteriGiris.Text = "Giriş";
            this.musteriGiris.UseVisualStyleBackColor = true;
            this.musteriGiris.Click += new System.EventHandler(this.musteriGiris_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kullanıcı Adı";
            // 
            // musteriSifre
            // 
            this.musteriSifre.Location = new System.Drawing.Point(108, 155);
            this.musteriSifre.Name = "musteriSifre";
            this.musteriSifre.Size = new System.Drawing.Size(187, 20);
            this.musteriSifre.TabIndex = 1;
            this.musteriSifre.Text = "123456";
            this.musteriSifre.UseSystemPasswordChar = true;
            // 
            // musteriK
            // 
            this.musteriK.Location = new System.Drawing.Point(108, 118);
            this.musteriK.Name = "musteriK";
            this.musteriK.Size = new System.Drawing.Size(187, 20);
            this.musteriK.TabIndex = 0;
            this.musteriK.Text = "sevgi123";
            // 
            // kayitOl
            // 
            this.kayitOl.BackColor = System.Drawing.Color.Teal;
            this.kayitOl.Controls.Add(this.guvenlikKodu);
            this.kayitOl.Controls.Add(this.label19);
            this.kayitOl.Controls.Add(this.txtGuvenlikKodu);
            this.kayitOl.Controls.Add(this.label18);
            this.kayitOl.Controls.Add(this.parolatekrar);
            this.kayitOl.Controls.Add(this.parola);
            this.kayitOl.Controls.Add(this.kullaniciadi);
            this.kayitOl.Controls.Add(this.label17);
            this.kayitOl.Controls.Add(this.label16);
            this.kayitOl.Controls.Add(this.label15);
            this.kayitOl.Controls.Add(this.kayit_ol);
            this.kayitOl.Controls.Add(this.label11);
            this.kayitOl.Controls.Add(this.label10);
            this.kayitOl.Controls.Add(this.label9);
            this.kayitOl.Controls.Add(this.label8);
            this.kayitOl.Controls.Add(this.label7);
            this.kayitOl.Controls.Add(this.eposta);
            this.kayitOl.Controls.Add(this.soyad);
            this.kayitOl.Controls.Add(this.ad);
            this.kayitOl.Controls.Add(this.telefon);
            this.kayitOl.Controls.Add(this.tckimlik);
            this.kayitOl.Location = new System.Drawing.Point(4, 22);
            this.kayitOl.Name = "kayitOl";
            this.kayitOl.Size = new System.Drawing.Size(343, 390);
            this.kayitOl.TabIndex = 2;
            this.kayitOl.Text = "Kayıt Ol";
            // 
            // guvenlikKodu
            // 
            this.guvenlikKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.guvenlikKodu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.guvenlikKodu.ImageKey = "arrow_circle2.png";
            this.guvenlikKodu.ImageList = this.ımageList1;
            this.guvenlikKodu.Location = new System.Drawing.Point(31, 235);
            this.guvenlikKodu.Name = "guvenlikKodu";
            this.guvenlikKodu.Size = new System.Drawing.Size(134, 42);
            this.guvenlikKodu.TabIndex = 21;
            this.guvenlikKodu.Text = "Güvenlik kodu Oluştur";
            this.guvenlikKodu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.guvenlikKodu.UseVisualStyleBackColor = true;
            this.guvenlikKodu.Click += new System.EventHandler(this.guvenlikKodu_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "arrow_circle2.png");
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label19.Location = new System.Drawing.Point(192, 246);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(0, 18);
            this.label19.TabIndex = 20;
            // 
            // txtGuvenlikKodu
            // 
            this.txtGuvenlikKodu.Location = new System.Drawing.Point(195, 292);
            this.txtGuvenlikKodu.Name = "txtGuvenlikKodu";
            this.txtGuvenlikKodu.Size = new System.Drawing.Size(100, 20);
            this.txtGuvenlikKodu.TabIndex = 19;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(38, 299);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(110, 13);
            this.label18.TabIndex = 18;
            this.label18.Text = "Güvenlik kodunu girin";
            // 
            // parolatekrar
            // 
            this.parolatekrar.Location = new System.Drawing.Point(107, 204);
            this.parolatekrar.Name = "parolatekrar";
            this.parolatekrar.Size = new System.Drawing.Size(188, 20);
            this.parolatekrar.TabIndex = 16;
            // 
            // parola
            // 
            this.parola.Location = new System.Drawing.Point(107, 177);
            this.parola.Name = "parola";
            this.parola.Size = new System.Drawing.Size(188, 20);
            this.parola.TabIndex = 15;
            // 
            // kullaniciadi
            // 
            this.kullaniciadi.Location = new System.Drawing.Point(107, 149);
            this.kullaniciadi.Name = "kullaniciadi";
            this.kullaniciadi.Size = new System.Drawing.Size(188, 20);
            this.kullaniciadi.TabIndex = 14;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(38, 209);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(71, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Parola Tekrar";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(38, 180);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Parola";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(38, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Kullanıcı adı";
            // 
            // kayit_ol
            // 
            this.kayit_ol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kayit_ol.Location = new System.Drawing.Point(107, 329);
            this.kayit_ol.Name = "kayit_ol";
            this.kayit_ol.Size = new System.Drawing.Size(188, 33);
            this.kayit_ol.TabIndex = 10;
            this.kayit_ol.Text = "Kayıt Ol";
            this.kayit_ol.UseVisualStyleBackColor = true;
            this.kayit_ol.Click += new System.EventHandler(this.kayit_ol_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(38, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "E-Posta";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(38, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Telefon";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Soyad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Ad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "TC Kimlik";
            // 
            // eposta
            // 
            this.eposta.Location = new System.Drawing.Point(107, 123);
            this.eposta.Name = "eposta";
            this.eposta.Size = new System.Drawing.Size(188, 20);
            this.eposta.TabIndex = 4;
            // 
            // soyad
            // 
            this.soyad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.soyad.Location = new System.Drawing.Point(107, 71);
            this.soyad.Name = "soyad";
            this.soyad.Size = new System.Drawing.Size(188, 20);
            this.soyad.TabIndex = 2;
            // 
            // ad
            // 
            this.ad.Location = new System.Drawing.Point(107, 43);
            this.ad.Name = "ad";
            this.ad.Size = new System.Drawing.Size(188, 20);
            this.ad.TabIndex = 1;
            // 
            // telefon
            // 
            this.telefon.Location = new System.Drawing.Point(107, 97);
            this.telefon.Mask = "(999) 000-0000";
            this.telefon.Name = "telefon";
            this.telefon.Size = new System.Drawing.Size(188, 20);
            this.telefon.TabIndex = 3;
            // 
            // tckimlik
            // 
            this.tckimlik.Location = new System.Drawing.Point(107, 17);
            this.tckimlik.Mask = "00000000000";
            this.tckimlik.Name = "tckimlik";
            this.tckimlik.Size = new System.Drawing.Size(188, 20);
            this.tckimlik.TabIndex = 0;
            // 
            // GİRİS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 413);
            this.Controls.Add(this.kullanici_Girisi);
            this.Name = "GİRİS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GİRİŞ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GİRİS_FormClosed);
            this.kullanici_Girisi.ResumeLayout(false);
            this.adminGirisi.ResumeLayout(false);
            this.adminGirisi.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.musteriGirisi.ResumeLayout(false);
            this.musteriGirisi.PerformLayout();
            this.kayitOl.ResumeLayout(false);
            this.kayitOl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl kullanici_Girisi;
        private System.Windows.Forms.TabPage adminGirisi;
        private System.Windows.Forms.Button adminGiris;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adminSifre;
        private System.Windows.Forms.TextBox adminK;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button calisanGiris;
        private System.Windows.Forms.TextBox calisanSifre;
        private System.Windows.Forms.TextBox calisanK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage musteriGirisi;
        private System.Windows.Forms.Button musteriGiris;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox musteriSifre;
        private System.Windows.Forms.TextBox musteriK;
        private System.Windows.Forms.TabPage kayitOl;
        private System.Windows.Forms.Button kayit_ol;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox eposta;
        private System.Windows.Forms.TextBox soyad;
        private System.Windows.Forms.TextBox ad;
        private System.Windows.Forms.MaskedTextBox telefon;
        private System.Windows.Forms.MaskedTextBox tckimlik;
        private System.Windows.Forms.TextBox parolatekrar;
        private System.Windows.Forms.TextBox parola;
        private System.Windows.Forms.TextBox kullaniciadi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtGuvenlikKodu;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button guvenlikKodu;
        private System.Windows.Forms.ImageList ımageList1;
    }
}

