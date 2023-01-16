namespace TaksiDuragiOtomasyonu
{
    partial class GECMİS
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
            this.musterigecmis = new System.Windows.Forms.DataGridView();
            this.geri = new System.Windows.Forms.Button();
            this.iptalEt = new System.Windows.Forms.Button();
            this.musteritel = new System.Windows.Forms.MaskedTextBox();
            this.txtsira = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.musterigecmis)).BeginInit();
            this.SuspendLayout();
            // 
            // musterigecmis
            // 
            this.musterigecmis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musterigecmis.Location = new System.Drawing.Point(8, 41);
            this.musterigecmis.Name = "musterigecmis";
            this.musterigecmis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.musterigecmis.Size = new System.Drawing.Size(548, 221);
            this.musterigecmis.TabIndex = 4;
            // 
            // geri
            // 
            this.geri.Location = new System.Drawing.Point(8, 12);
            this.geri.Name = "geri";
            this.geri.Size = new System.Drawing.Size(75, 23);
            this.geri.TabIndex = 8;
            this.geri.Text = "Geri";
            this.geri.UseVisualStyleBackColor = true;
            this.geri.Click += new System.EventHandler(this.geri_Click);
            // 
            // iptalEt
            // 
            this.iptalEt.Location = new System.Drawing.Point(291, 268);
            this.iptalEt.Name = "iptalEt";
            this.iptalEt.Size = new System.Drawing.Size(265, 27);
            this.iptalEt.TabIndex = 9;
            this.iptalEt.Text = "SEÇİLİ KAYDI İPTAL ET";
            this.iptalEt.UseVisualStyleBackColor = true;
            this.iptalEt.Click += new System.EventHandler(this.iptalEt_Click);
            // 
            // musteritel
            // 
            this.musteritel.Location = new System.Drawing.Point(89, 15);
            this.musteritel.Mask = "(999) 000-0000";
            this.musteritel.Name = "musteritel";
            this.musteritel.Size = new System.Drawing.Size(158, 20);
            this.musteritel.TabIndex = 22;
            this.musteritel.Visible = false;
            // 
            // txtsira
            // 
            this.txtsira.Location = new System.Drawing.Point(253, 15);
            this.txtsira.Name = "txtsira";
            this.txtsira.Size = new System.Drawing.Size(100, 20);
            this.txtsira.TabIndex = 23;
            // 
            // GECMİS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 304);
            this.Controls.Add(this.txtsira);
            this.Controls.Add(this.musteritel);
            this.Controls.Add(this.iptalEt);
            this.Controls.Add(this.geri);
            this.Controls.Add(this.musterigecmis);
            this.Name = "GECMİS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GEÇMİŞ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GECMİS_FormClosed);
            this.Load += new System.EventHandler(this.GECMİS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musterigecmis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView musterigecmis;
        private System.Windows.Forms.Button geri;
        private System.Windows.Forms.Button iptalEt;
        private System.Windows.Forms.MaskedTextBox musteritel;
        private System.Windows.Forms.TextBox txtsira;
    }
}