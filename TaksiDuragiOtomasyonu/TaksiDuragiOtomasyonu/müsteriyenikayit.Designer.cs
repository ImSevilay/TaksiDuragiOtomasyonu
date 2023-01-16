namespace TaksiDuragiOtomasyonu
{
    partial class KAYİT
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
            this.dtgecmis = new System.Windows.Forms.DataGridView();
            this.kayitsil = new System.Windows.Forms.Button();
            this.geri = new System.Windows.Forms.Button();
            this.txtSiraNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dttalep = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgecmis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttalep)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgecmis
            // 
            this.dtgecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgecmis.Location = new System.Drawing.Point(15, 220);
            this.dtgecmis.Name = "dtgecmis";
            this.dtgecmis.Size = new System.Drawing.Size(333, 174);
            this.dtgecmis.TabIndex = 0;
            this.dtgecmis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgecmis_CellClick_1);
            // 
            // kayitsil
            // 
            this.kayitsil.Location = new System.Drawing.Point(12, 411);
            this.kayitsil.Name = "kayitsil";
            this.kayitsil.Size = new System.Drawing.Size(137, 23);
            this.kayitsil.TabIndex = 1;
            this.kayitsil.Text = "Seçili Kaydı Sil";
            this.kayitsil.UseVisualStyleBackColor = true;
            this.kayitsil.Click += new System.EventHandler(this.kayitsil_Click);
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(273, 410);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 23);
            this.geri.TabIndex = 3;
            this.geri.Text = "GERİ";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtSiraNo
            // 
            this.txtSiraNo.Location = new System.Drawing.Point(210, 12);
            this.txtSiraNo.Name = "txtSiraNo";
            this.txtSiraNo.Size = new System.Drawing.Size(100, 20);
            this.txtSiraNo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Silinecek Kaydın Sıra Numarasını Giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "SİLME TALEPLERİ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "KAYITLAR";
            // 
            // dttalep
            // 
            this.dttalep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dttalep.Location = new System.Drawing.Point(62, 65);
            this.dttalep.Name = "dttalep";
            this.dttalep.Size = new System.Drawing.Size(237, 105);
            this.dttalep.TabIndex = 10;
            // 
            // KAYİT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 446);
            this.Controls.Add(this.dttalep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSiraNo);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.kayitsil);
            this.Controls.Add(this.dtgecmis);
            this.Name = "KAYİT";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MÜŞTERİ YENİ KAYIT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KAYİT_FormClosed);
            this.Load += new System.EventHandler(this.KAYİT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgecmis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dttalep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button kayitsil;
        private System.Windows.Forms.Button geri;
        public System.Windows.Forms.DataGridView dtgecmis;
        private System.Windows.Forms.TextBox txtSiraNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dttalep;
    }
}