namespace BorsaProjesi
{
    partial class YoneticiPaneli
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
            this.Kullanicilar = new System.Windows.Forms.ListBox();
            this.btnBakiyeOnayla = new System.Windows.Forms.Button();
            this.UrunTalepleri = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbltalep = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTalepOnay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnİslemler = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.dteTmePckrYonetici = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kullanicilar
            // 
            this.Kullanicilar.FormattingEnabled = true;
            this.Kullanicilar.ItemHeight = 16;
            this.Kullanicilar.Location = new System.Drawing.Point(16, 31);
            this.Kullanicilar.Margin = new System.Windows.Forms.Padding(4);
            this.Kullanicilar.Name = "Kullanicilar";
            this.Kullanicilar.Size = new System.Drawing.Size(400, 164);
            this.Kullanicilar.TabIndex = 0;
            this.Kullanicilar.SelectedIndexChanged += new System.EventHandler(this.Kullanicilar_SelectedIndexChanged);
            // 
            // btnBakiyeOnayla
            // 
            this.btnBakiyeOnayla.Location = new System.Drawing.Point(832, 9);
            this.btnBakiyeOnayla.Margin = new System.Windows.Forms.Padding(4);
            this.btnBakiyeOnayla.Name = "btnBakiyeOnayla";
            this.btnBakiyeOnayla.Size = new System.Drawing.Size(192, 28);
            this.btnBakiyeOnayla.TabIndex = 1;
            this.btnBakiyeOnayla.Text = "Bakiyeyi Onayla";
            this.btnBakiyeOnayla.UseVisualStyleBackColor = true;
            this.btnBakiyeOnayla.Click += new System.EventHandler(this.btnBakiyeOnayla_Click);
            // 
            // UrunTalepleri
            // 
            this.UrunTalepleri.FormattingEnabled = true;
            this.UrunTalepleri.ItemHeight = 16;
            this.UrunTalepleri.Location = new System.Drawing.Point(425, 63);
            this.UrunTalepleri.Margin = new System.Windows.Forms.Padding(4);
            this.UrunTalepleri.Name = "UrunTalepleri";
            this.UrunTalepleri.Size = new System.Drawing.Size(597, 100);
            this.UrunTalepleri.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(425, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bakiye Talebi :";
            // 
            // lbltalep
            // 
            this.lbltalep.AutoSize = true;
            this.lbltalep.Location = new System.Drawing.Point(580, 15);
            this.lbltalep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltalep.Name = "lbltalep";
            this.lbltalep.Size = new System.Drawing.Size(33, 17);
            this.lbltalep.TabIndex = 2;
            this.lbltalep.Text = "0TL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ürün Talepleri:";
            // 
            // btnTalepOnay
            // 
            this.btnTalepOnay.Location = new System.Drawing.Point(425, 171);
            this.btnTalepOnay.Margin = new System.Windows.Forms.Padding(4);
            this.btnTalepOnay.Name = "btnTalepOnay";
            this.btnTalepOnay.Size = new System.Drawing.Size(401, 28);
            this.btnTalepOnay.TabIndex = 1;
            this.btnTalepOnay.Text = "Tüm Talepleri Onayla";
            this.btnTalepOnay.UseVisualStyleBackColor = true;
            this.btnTalepOnay.Click += new System.EventHandler(this.btnTalepOnay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Kullanıcılar";
            // 
            // btnİslemler
            // 
            this.btnİslemler.Location = new System.Drawing.Point(832, 169);
            this.btnİslemler.Margin = new System.Windows.Forms.Padding(4);
            this.btnİslemler.Name = "btnİslemler";
            this.btnİslemler.Size = new System.Drawing.Size(192, 28);
            this.btnİslemler.TabIndex = 1;
            this.btnİslemler.Text = "İşlemler";
            this.btnİslemler.UseVisualStyleBackColor = true;
            this.btnİslemler.Click += new System.EventHandler(this.btnİslemler_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(16, 233);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(401, 28);
            this.btnGuncelle.TabIndex = 1;
            this.btnGuncelle.Text = "Mevcut Döviz Tarihini Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // dteTmePckrYonetici
            // 
            this.dteTmePckrYonetici.Location = new System.Drawing.Point(151, 201);
            this.dteTmePckrYonetici.Margin = new System.Windows.Forms.Padding(4);
            this.dteTmePckrYonetici.Name = "dteTmePckrYonetici";
            this.dteTmePckrYonetici.Size = new System.Drawing.Size(265, 22);
            this.dteTmePckrYonetici.TabIndex = 3;
            this.dteTmePckrYonetici.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 208);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tarih:";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(881, 216);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(143, 45);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // YoneticiPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1041, 265);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dteTmePckrYonetici);
            this.Controls.Add(this.lbltalep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnTalepOnay);
            this.Controls.Add(this.btnİslemler);
            this.Controls.Add(this.btnBakiyeOnayla);
            this.Controls.Add(this.UrunTalepleri);
            this.Controls.Add(this.Kullanicilar);
            this.Location = new System.Drawing.Point(400, 160);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "YoneticiPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Yönetici Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.YoneticiPaneli_FormClosing);
            this.Load += new System.EventHandler(this.YoneticiPaneli_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Kullanicilar;
        private System.Windows.Forms.Button btnBakiyeOnayla;
        private System.Windows.Forms.ListBox UrunTalepleri;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltalep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTalepOnay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnİslemler;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.DateTimePicker dteTmePckrYonetici;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCikis;
    }
}