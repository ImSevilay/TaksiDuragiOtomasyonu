namespace TaksiDuragiOtomasyonu
{
    partial class ARACDURUMU
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gecti = new System.Windows.Forms.RadioButton();
            this.kaldi = new System.Windows.Forms.RadioButton();
            this.kalmanedeni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.var = new System.Windows.Forms.RadioButton();
            this.yok = new System.Windows.Forms.RadioButton();
            this.ekle = new System.Windows.Forms.Button();
            this.sil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.unutulanesyalar = new System.Windows.Forms.TextBox();
            this.geri = new System.Windows.Forms.Button();
            this.aracdurumudt = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbplaka = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.sira = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.aracdurumudt)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Plaka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Muayene Durumu";
            // 
            // gecti
            // 
            this.gecti.AutoSize = true;
            this.gecti.Location = new System.Drawing.Point(1, 10);
            this.gecti.Name = "gecti";
            this.gecti.Size = new System.Drawing.Size(50, 17);
            this.gecti.TabIndex = 3;
            this.gecti.TabStop = true;
            this.gecti.Text = "Geçti";
            this.gecti.UseVisualStyleBackColor = true;
            // 
            // kaldi
            // 
            this.kaldi.AutoSize = true;
            this.kaldi.Location = new System.Drawing.Point(63, 10);
            this.kaldi.Name = "kaldi";
            this.kaldi.Size = new System.Drawing.Size(48, 17);
            this.kaldi.TabIndex = 4;
            this.kaldi.TabStop = true;
            this.kaldi.Text = "Kaldı";
            this.kaldi.UseVisualStyleBackColor = true;
            this.kaldi.CheckedChanged += new System.EventHandler(this.kaldi_CheckedChanged);
            // 
            // kalmanedeni
            // 
            this.kalmanedeni.Location = new System.Drawing.Point(89, 102);
            this.kalmanedeni.Name = "kalmanedeni";
            this.kalmanedeni.Size = new System.Drawing.Size(152, 20);
            this.kalmanedeni.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kalma nedeni";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kaza Durumu";
            // 
            // var
            // 
            this.var.AutoSize = true;
            this.var.Location = new System.Drawing.Point(5, 7);
            this.var.Name = "var";
            this.var.Size = new System.Drawing.Size(41, 17);
            this.var.TabIndex = 8;
            this.var.TabStop = true;
            this.var.Text = "Var";
            this.var.UseVisualStyleBackColor = true;
            // 
            // yok
            // 
            this.yok.AutoSize = true;
            this.yok.Location = new System.Drawing.Point(68, 8);
            this.yok.Name = "yok";
            this.yok.Size = new System.Drawing.Size(44, 17);
            this.yok.TabIndex = 9;
            this.yok.TabStop = true;
            this.yok.Text = "Yok";
            this.yok.UseVisualStyleBackColor = true;
            // 
            // ekle
            // 
            this.ekle.Location = new System.Drawing.Point(307, 262);
            this.ekle.Name = "ekle";
            this.ekle.Size = new System.Drawing.Size(75, 23);
            this.ekle.TabIndex = 11;
            this.ekle.Text = "Ekle";
            this.ekle.UseVisualStyleBackColor = true;
            this.ekle.Click += new System.EventHandler(this.ekle_Click);
            // 
            // sil
            // 
            this.sil.Location = new System.Drawing.Point(384, 262);
            this.sil.Name = "sil";
            this.sil.Size = new System.Drawing.Size(75, 23);
            this.sil.TabIndex = 12;
            this.sil.Text = "Sil";
            this.sil.UseVisualStyleBackColor = true;
            this.sil.Click += new System.EventHandler(this.sil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Unutulan Eşya";
            // 
            // unutulanesyalar
            // 
            this.unutulanesyalar.Location = new System.Drawing.Point(89, 166);
            this.unutulanesyalar.Name = "unutulanesyalar";
            this.unutulanesyalar.Size = new System.Drawing.Size(152, 20);
            this.unutulanesyalar.TabIndex = 15;
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(15, 262);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 23);
            this.geri.TabIndex = 18;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.button5_Click);
            // 
            // aracdurumudt
            // 
            this.aracdurumudt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aracdurumudt.Location = new System.Drawing.Point(255, 17);
            this.aracdurumudt.Name = "aracdurumudt";
            this.aracdurumudt.Size = new System.Drawing.Size(334, 239);
            this.aracdurumudt.TabIndex = 20;
            this.aracdurumudt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.aracdurumudt_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kaldi);
            this.groupBox1.Controls.Add(this.gecti);
            this.groupBox1.Location = new System.Drawing.Point(109, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(132, 32);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.yok);
            this.groupBox2.Controls.Add(this.var);
            this.groupBox2.Location = new System.Drawing.Point(109, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(132, 28);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            // 
            // cbplaka
            // 
            this.cbplaka.FormattingEnabled = true;
            this.cbplaka.Location = new System.Drawing.Point(89, 34);
            this.cbplaka.Name = "cbplaka";
            this.cbplaka.Size = new System.Drawing.Size(152, 21);
            this.cbplaka.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 204);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(85, 17);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "ilk yardım kiti";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(110, 204);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(82, 17);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.Text = "yedek lastik";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(16, 240);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(49, 17);
            this.checkBox3.TabIndex = 27;
            this.checkBox3.Text = "kriko";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(109, 238);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(74, 17);
            this.checkBox4.TabIndex = 28;
            this.checkBox4.Text = "taksimetre";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // sira
            // 
            this.sira.Location = new System.Drawing.Point(89, 8);
            this.sira.Name = "sira";
            this.sira.Size = new System.Drawing.Size(152, 20);
            this.sira.TabIndex = 29;
            this.sira.Visible = false;
            // 
            // ARACDURUMU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 295);
            this.Controls.Add(this.sira);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.cbplaka);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aracdurumudt);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.unutulanesyalar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sil);
            this.Controls.Add(this.ekle);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kalmanedeni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ARACDURUMU";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARAÇ DURUMU";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ARACDURUMU_FormClosed);
            this.Load += new System.EventHandler(this.ARACDURUMU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aracdurumudt)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton gecti;
        private System.Windows.Forms.RadioButton kaldi;
        private System.Windows.Forms.TextBox kalmanedeni;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton var;
        private System.Windows.Forms.RadioButton yok;
        private System.Windows.Forms.Button ekle;
        private System.Windows.Forms.Button sil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox unutulanesyalar;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.DataGridView aracdurumudt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbplaka;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox sira;
    }
}