namespace BorsaProjesi
{
    partial class Islemler
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
            this.islemlerGrid = new System.Windows.Forms.DataGridView();
            this.islemzamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemdetayi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harcanantutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alicikalanpara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimfiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.islemlerGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // islemlerGrid
            // 
            this.islemlerGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.islemlerGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.islemlerGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.islemzamani,
            this.islemdetayi,
            this.harcanantutar,
            this.alicikalanpara,
            this.birimfiyat});
            this.islemlerGrid.Location = new System.Drawing.Point(16, 15);
            this.islemlerGrid.Margin = new System.Windows.Forms.Padding(4);
            this.islemlerGrid.Name = "islemlerGrid";
            this.islemlerGrid.RowHeadersWidth = 51;
            this.islemlerGrid.Size = new System.Drawing.Size(1035, 524);
            this.islemlerGrid.TabIndex = 0;
            // 
            // islemzamani
            // 
            this.islemzamani.HeaderText = "İşlem Zamanı";
            this.islemzamani.MinimumWidth = 6;
            this.islemzamani.Name = "islemzamani";
            // 
            // islemdetayi
            // 
            this.islemdetayi.HeaderText = "Yapılan İşlem Detayı";
            this.islemdetayi.MinimumWidth = 6;
            this.islemdetayi.Name = "islemdetayi";
            // 
            // harcanantutar
            // 
            this.harcanantutar.HeaderText = "Harcanan Tutar";
            this.harcanantutar.MinimumWidth = 6;
            this.harcanantutar.Name = "harcanantutar";
            // 
            // alicikalanpara
            // 
            this.alicikalanpara.HeaderText = "Alıcının Kalan Parası";
            this.alicikalanpara.MinimumWidth = 6;
            this.alicikalanpara.Name = "alicikalanpara";
            // 
            // birimfiyat
            // 
            this.birimfiyat.HeaderText = "Satılan Malın Birim Fiyatı";
            this.birimfiyat.MinimumWidth = 6;
            this.birimfiyat.Name = "birimfiyat";
            // 
            // Islemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.islemlerGrid);
            this.Location = new System.Drawing.Point(400, 160);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Islemler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Islemler";
            this.Load += new System.EventHandler(this.Islemler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.islemlerGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView islemlerGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemzamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemdetayi;
        private System.Windows.Forms.DataGridViewTextBoxColumn harcanantutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn alicikalanpara;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimfiyat;
    }
}