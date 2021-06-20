namespace BorsaProjesi
{
    partial class KullaniciPanel
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
            this.cmbBxUrunTipi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAlisTalebiGonder = new System.Windows.Forms.Button();
            this.btnUrunOnay = new System.Windows.Forms.Button();
            this.tbbirimfiyat = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbmiktar = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbBxBirim = new System.Windows.Forms.ComboBox();
            this.btnBakiyeOnay = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxBakiye = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bakiyelbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Urunler = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Talepler = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bakiyeonaylbl = new System.Windows.Forms.Label();
            this.btnRaporAl = new System.Windows.Forms.Button();
            this.dtBaslangic = new System.Windows.Forms.DateTimePicker();
            this.dtBitis = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbbirimfiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmiktar)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbBxUrunTipi
            // 
            this.cmbBxUrunTipi.FormattingEnabled = true;
            this.cmbBxUrunTipi.Items.AddRange(new object[] {
            "Buğday",
            "Arpa",
            "Yulaf",
            "Petrol",
            "Pamuk"});
            this.cmbBxUrunTipi.Location = new System.Drawing.Point(164, 16);
            this.cmbBxUrunTipi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxUrunTipi.Name = "cmbBxUrunTipi";
            this.cmbBxUrunTipi.Size = new System.Drawing.Size(176, 24);
            this.cmbBxUrunTipi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Tipi";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAlisTalebiGonder);
            this.groupBox1.Controls.Add(this.btnUrunOnay);
            this.groupBox1.Controls.Add(this.tbbirimfiyat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbmiktar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbBxUrunTipi);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(349, 162);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // btnAlisTalebiGonder
            // 
            this.btnAlisTalebiGonder.Location = new System.Drawing.Point(12, 113);
            this.btnAlisTalebiGonder.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlisTalebiGonder.Name = "btnAlisTalebiGonder";
            this.btnAlisTalebiGonder.Size = new System.Drawing.Size(144, 28);
            this.btnAlisTalebiGonder.TabIndex = 4;
            this.btnAlisTalebiGonder.Text = "Alış Talebi Gönder";
            this.btnAlisTalebiGonder.UseVisualStyleBackColor = true;
            this.btnAlisTalebiGonder.Click += new System.EventHandler(this.btnAlisTalebiGonder_Click);
            // 
            // btnUrunOnay
            // 
            this.btnUrunOnay.Location = new System.Drawing.Point(164, 113);
            this.btnUrunOnay.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrunOnay.Name = "btnUrunOnay";
            this.btnUrunOnay.Size = new System.Drawing.Size(177, 28);
            this.btnUrunOnay.TabIndex = 3;
            this.btnUrunOnay.Text = "Onaya Gönder";
            this.btnUrunOnay.UseVisualStyleBackColor = true;
            this.btnUrunOnay.Click += new System.EventHandler(this.btnUrunOnay_Click);
            // 
            // tbbirimfiyat
            // 
            this.tbbirimfiyat.Location = new System.Drawing.Point(164, 81);
            this.tbbirimfiyat.Margin = new System.Windows.Forms.Padding(4);
            this.tbbirimfiyat.Name = "tbbirimfiyat";
            this.tbbirimfiyat.Size = new System.Drawing.Size(177, 22);
            this.tbbirimfiyat.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Birim Fiyat";
            // 
            // tbmiktar
            // 
            this.tbmiktar.Location = new System.Drawing.Point(164, 49);
            this.tbmiktar.Margin = new System.Windows.Forms.Padding(4);
            this.tbmiktar.Name = "tbmiktar";
            this.tbmiktar.Size = new System.Drawing.Size(177, 22);
            this.tbmiktar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Miktar";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbBxBirim);
            this.groupBox2.Controls.Add(this.btnBakiyeOnay);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtBxBakiye);
            this.groupBox2.Location = new System.Drawing.Point(16, 185);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(349, 100);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bakiye Ekle";
            // 
            // cmbBxBirim
            // 
            this.cmbBxBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBxBirim.FormattingEnabled = true;
            this.cmbBxBirim.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Sterlin",
            "Türk Lirası"});
            this.cmbBxBirim.Location = new System.Drawing.Point(225, 20);
            this.cmbBxBirim.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBxBirim.Name = "cmbBxBirim";
            this.cmbBxBirim.Size = new System.Drawing.Size(115, 24);
            this.cmbBxBirim.TabIndex = 4;
            // 
            // btnBakiyeOnay
            // 
            this.btnBakiyeOnay.Location = new System.Drawing.Point(116, 53);
            this.btnBakiyeOnay.Margin = new System.Windows.Forms.Padding(4);
            this.btnBakiyeOnay.Name = "btnBakiyeOnay";
            this.btnBakiyeOnay.Size = new System.Drawing.Size(225, 28);
            this.btnBakiyeOnay.TabIndex = 3;
            this.btnBakiyeOnay.Text = "Onaya Gönder";
            this.btnBakiyeOnay.UseVisualStyleBackColor = true;
            this.btnBakiyeOnay.Click += new System.EventHandler(this.btnBakiyeOnay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Bakiye";
            // 
            // txtBxBakiye
            // 
            this.txtBxBakiye.Location = new System.Drawing.Point(116, 21);
            this.txtBxBakiye.Margin = new System.Windows.Forms.Padding(4);
            this.txtBxBakiye.Name = "txtBxBakiye";
            this.txtBxBakiye.Size = new System.Drawing.Size(100, 22);
            this.txtBxBakiye.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Bakiyem: ";
            // 
            // bakiyelbl
            // 
            this.bakiyelbl.AutoSize = true;
            this.bakiyelbl.Location = new System.Drawing.Point(471, 15);
            this.bakiyelbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bakiyelbl.Name = "bakiyelbl";
            this.bakiyelbl.Size = new System.Drawing.Size(33, 17);
            this.bakiyelbl.TabIndex = 5;
            this.bakiyelbl.Text = "0TL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 44);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sahip Olduğum Ürünler:";
            // 
            // Urunler
            // 
            this.Urunler.FormattingEnabled = true;
            this.Urunler.ItemHeight = 16;
            this.Urunler.Location = new System.Drawing.Point(376, 78);
            this.Urunler.Margin = new System.Windows.Forms.Padding(4);
            this.Urunler.Name = "Urunler";
            this.Urunler.Size = new System.Drawing.Size(416, 100);
            this.Urunler.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 185);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Alış Taleplerim";
            // 
            // Talepler
            // 
            this.Talepler.FormattingEnabled = true;
            this.Talepler.ItemHeight = 16;
            this.Talepler.Location = new System.Drawing.Point(377, 218);
            this.Talepler.Margin = new System.Windows.Forms.Padding(4);
            this.Talepler.Name = "Talepler";
            this.Talepler.Size = new System.Drawing.Size(416, 100);
            this.Talepler.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(553, 15);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Onay Bekleyen:";
            // 
            // bakiyeonaylbl
            // 
            this.bakiyeonaylbl.AutoSize = true;
            this.bakiyeonaylbl.Location = new System.Drawing.Point(671, 15);
            this.bakiyeonaylbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bakiyeonaylbl.Name = "bakiyeonaylbl";
            this.bakiyeonaylbl.Size = new System.Drawing.Size(33, 17);
            this.bakiyeonaylbl.TabIndex = 5;
            this.bakiyeonaylbl.Text = "0TL";
            // 
            // btnRaporAl
            // 
            this.btnRaporAl.Location = new System.Drawing.Point(16, 337);
            this.btnRaporAl.Margin = new System.Windows.Forms.Padding(4);
            this.btnRaporAl.Name = "btnRaporAl";
            this.btnRaporAl.Size = new System.Drawing.Size(349, 28);
            this.btnRaporAl.TabIndex = 3;
            this.btnRaporAl.Text = "İşlemler Raporu Al";
            this.btnRaporAl.UseVisualStyleBackColor = true;
            this.btnRaporAl.Click += new System.EventHandler(this.btnRaporAl_Click);
            // 
            // dtBaslangic
            // 
            this.dtBaslangic.Location = new System.Drawing.Point(16, 305);
            this.dtBaslangic.Margin = new System.Windows.Forms.Padding(4);
            this.dtBaslangic.Name = "dtBaslangic";
            this.dtBaslangic.Size = new System.Drawing.Size(171, 22);
            this.dtBaslangic.TabIndex = 7;
            // 
            // dtBitis
            // 
            this.dtBitis.Location = new System.Drawing.Point(195, 305);
            this.dtBitis.Margin = new System.Windows.Forms.Padding(4);
            this.dtBitis.Name = "dtBitis";
            this.dtBitis.Size = new System.Drawing.Size(170, 22);
            this.dtBitis.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 288);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Başlangıç Tarihi:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(192, 288);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 8;
            this.label10.Text = "Bitiş Tarihi";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(660, 333);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(132, 36);
            this.btnCikis.TabIndex = 9;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // KullaniciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(805, 375);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtBitis);
            this.Controls.Add(this.dtBaslangic);
            this.Controls.Add(this.Talepler);
            this.Controls.Add(this.btnRaporAl);
            this.Controls.Add(this.Urunler);
            this.Controls.Add(this.bakiyeonaylbl);
            this.Controls.Add(this.bakiyelbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(400, 160);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KullaniciPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KullaniciPanel";
            this.Load += new System.EventHandler(this.KullaniciPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbbirimfiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmiktar)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbBxUrunTipi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUrunOnay;
        private System.Windows.Forms.NumericUpDown tbmiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown tbbirimfiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBakiyeOnay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBxBakiye;
        private System.Windows.Forms.Button btnAlisTalebiGonder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label bakiyelbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox Urunler;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox Talepler;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label bakiyeonaylbl;
        private System.Windows.Forms.ComboBox cmbBxBirim;
        private System.Windows.Forms.Button btnRaporAl;
        private System.Windows.Forms.DateTimePicker dtBaslangic;
        private System.Windows.Forms.DateTimePicker dtBitis;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnCikis;
    }
}