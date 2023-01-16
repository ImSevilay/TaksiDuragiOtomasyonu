namespace TaksiDuragiOtomasyonu
{
    partial class MUSTERI
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
            this.gecmisGoruntule = new System.Windows.Forms.Button();
            this.musteritel = new System.Windows.Forms.MaskedTextBox();
            this.musterisoyad = new System.Windows.Forms.TextBox();
            this.musteriad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.aracCagir = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.hesapsil = new System.Windows.Forms.Button();
            this.musteridtime = new System.Windows.Forms.DateTimePicker();
            this.musteriadres = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(249, 166);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(98, 51);
            this.cikis.TabIndex = 2;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.button1_Click);
            // 
            // gecmisGoruntule
            // 
            this.gecmisGoruntule.Location = new System.Drawing.Point(249, 55);
            this.gecmisGoruntule.Name = "gecmisGoruntule";
            this.gecmisGoruntule.Size = new System.Drawing.Size(98, 51);
            this.gecmisGoruntule.TabIndex = 6;
            this.gecmisGoruntule.Text = "Geçmişi Görüntüle";
            this.gecmisGoruntule.UseVisualStyleBackColor = true;
            this.gecmisGoruntule.Click += new System.EventHandler(this.button3_Click);
            // 
            // musteritel
            // 
            this.musteritel.Location = new System.Drawing.Point(80, 110);
            this.musteritel.Mask = "(999) 000-0000";
            this.musteritel.Name = "musteritel";
            this.musteritel.Size = new System.Drawing.Size(158, 20);
            this.musteritel.TabIndex = 21;
            // 
            // musterisoyad
            // 
            this.musterisoyad.Location = new System.Drawing.Point(80, 86);
            this.musterisoyad.Name = "musterisoyad";
            this.musterisoyad.Size = new System.Drawing.Size(158, 20);
            this.musterisoyad.TabIndex = 19;
            // 
            // musteriad
            // 
            this.musteriad.Location = new System.Drawing.Point(80, 61);
            this.musteriad.Name = "musteriad";
            this.musteriad.Size = new System.Drawing.Size(158, 20);
            this.musteriad.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "ADRES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "TELEFON";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "SOYAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "AD";
            // 
            // aracCagir
            // 
            this.aracCagir.Location = new System.Drawing.Point(80, 223);
            this.aracCagir.Name = "aracCagir";
            this.aracCagir.Size = new System.Drawing.Size(158, 23);
            this.aracCagir.TabIndex = 22;
            this.aracCagir.Text = "Araç Çağır";
            this.aracCagir.UseVisualStyleBackColor = true;
            this.aracCagir.Click += new System.EventHandler(this.aracCagir_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "label5";
            // 
            // hesapsil
            // 
            this.hesapsil.Location = new System.Drawing.Point(249, 111);
            this.hesapsil.Name = "hesapsil";
            this.hesapsil.Size = new System.Drawing.Size(98, 51);
            this.hesapsil.TabIndex = 25;
            this.hesapsil.Text = "Hesabımı Sil";
            this.hesapsil.UseVisualStyleBackColor = true;
            this.hesapsil.Click += new System.EventHandler(this.hesapsil_Click);
            // 
            // musteridtime
            // 
            this.musteridtime.Location = new System.Drawing.Point(80, 34);
            this.musteridtime.Name = "musteridtime";
            this.musteridtime.Size = new System.Drawing.Size(158, 20);
            this.musteridtime.TabIndex = 31;
            // 
            // musteriadres
            // 
            this.musteriadres.Location = new System.Drawing.Point(80, 136);
            this.musteriadres.Name = "musteriadres";
            this.musteriadres.Size = new System.Drawing.Size(158, 81);
            this.musteriadres.TabIndex = 33;
            this.musteriadres.Text = "";
            // 
            // MUSTERI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 269);
            this.Controls.Add(this.musteriadres);
            this.Controls.Add(this.musteridtime);
            this.Controls.Add(this.hesapsil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aracCagir);
            this.Controls.Add(this.musteritel);
            this.Controls.Add(this.musterisoyad);
            this.Controls.Add(this.musteriad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gecmisGoruntule);
            this.Controls.Add(this.cikis);
            this.Name = "MUSTERI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MUSTERI_FormClosed);
            this.Load += new System.EventHandler(this.MUSTERI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button gecmisGoruntule;
        private System.Windows.Forms.MaskedTextBox musteritel;
        private System.Windows.Forms.TextBox musterisoyad;
        private System.Windows.Forms.TextBox musteriad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button aracCagir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button hesapsil;
        private System.Windows.Forms.DateTimePicker musteridtime;
        private System.Windows.Forms.RichTextBox musteriadres;
    }
}