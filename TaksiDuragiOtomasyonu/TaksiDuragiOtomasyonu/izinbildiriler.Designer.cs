namespace TaksiDuragiOtomasyonu
{
    partial class izinbildiriler
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
            this.izindt = new System.Windows.Forms.DataGridView();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.bildirilw = new System.Windows.Forms.ListView();
            this.bildiriid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.soyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bildiri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.izinsira = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.izindt)).BeginInit();
            this.SuspendLayout();
            // 
            // izindt
            // 
            this.izindt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.izindt.Location = new System.Drawing.Point(12, 39);
            this.izindt.Name = "izindt";
            this.izindt.Size = new System.Drawing.Size(337, 188);
            this.izindt.TabIndex = 0;
            this.izindt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.izindt_CellClick);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(12, 236);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(73, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Onaylandı";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // bildirilw
            // 
            this.bildirilw.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bildiriid,
            this.ad,
            this.soyad,
            this.bildiri});
            this.bildirilw.Location = new System.Drawing.Point(12, 265);
            this.bildirilw.Name = "bildirilw";
            this.bildirilw.Size = new System.Drawing.Size(337, 188);
            this.bildirilw.TabIndex = 4;
            this.bildirilw.UseCompatibleStateImageBehavior = false;
            this.bildirilw.View = System.Windows.Forms.View.Details;
            // 
            // bildiriid
            // 
            this.bildiriid.Text = "BİLDİRİ İD";
            this.bildiriid.Width = 70;
            // 
            // ad
            // 
            this.ad.Text = "AD";
            this.ad.Width = 80;
            // 
            // soyad
            // 
            this.soyad.Text = "SOYAD";
            this.soyad.Width = 80;
            // 
            // bildiri
            // 
            this.bildiri.Text = "BİLDİRİ";
            this.bildiri.Width = 100;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "GERİ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Onayla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // izinsira
            // 
            this.izinsira.Location = new System.Drawing.Point(100, 12);
            this.izinsira.Name = "izinsira";
            this.izinsira.Size = new System.Drawing.Size(100, 20);
            this.izinsira.TabIndex = 7;
            // 
            // izinbildiriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 459);
            this.Controls.Add(this.izinsira);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bildirilw);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.izindt);
            this.Name = "izinbildiriler";
            this.Text = "İZİN TALEPLERİ-BİLDİRİLER";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.izinbildiriler_FormClosed);
            this.Load += new System.EventHandler(this.izinbildiriler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.izindt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView izindt;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListView bildirilw;
        private System.Windows.Forms.ColumnHeader bildiriid;
        private System.Windows.Forms.ColumnHeader ad;
        private System.Windows.Forms.ColumnHeader soyad;
        private System.Windows.Forms.ColumnHeader bildiri;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox izinsira;
    }
}