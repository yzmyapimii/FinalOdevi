using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaProjesi
{
    public partial class KullaniciPanel : Form
    {
        Kullanici kullanici;
        public KullaniciPanel(Kullanici kullanici)
        {
            this.kullanici = kullanici;
            InitializeComponent();
        }
        //Formun yüklenmesi sırasında sistem meydana gelen değişiklikleri ve gerekli bilgileri panele yansıtan kısım.
        private void KullaniciPanel_Load(object sender, EventArgs e)
        {
            cmbBxBirim.SelectedIndex = 0;
            Text = "Hoşgeldiniz " + kullanici.Ad + " " + kullanici.Soyad + DateTime.Now.ToShortDateString();
            Veriler.TalepKontrol();
            PanelGuncelle();
        }
        //Panelde meydana gelen değişiklikleri panele yansıtmak için kullandığımız kısım.
        void PanelGuncelle()
        {
            Urunler.Items.Clear();
            foreach (Nesne nesne in kullanici.Esyalar)
            {
                Urunler.Items.Add("Ad :" + nesne.Ad + " Fiyat: " + nesne.Fiyat + " Miktar: " + nesne.Miktar);
            }
            Talepler.Items.Clear();
            List<Talep> talepler = Veriler.KullaniciTalepleri(kullanici);
            foreach (Talep talep in talepler)
            {
                Talepler.Items.Add("Ad: " + talep.Urun + " Miktar: " + talep.Miktar);
            }
            bakiyelbl.Text = kullanici.Bakiye.ToString() + " TL";
            bakiyeonaylbl.Text = kullanici.BakiyeOnay.ToString() + " TL";
        }
        //Kullanıcının talepleri doğrultusunda, sisteme girilmesi talep edilen ürünleri admin onayına gönderen metod.
        private void btnUrunOnay_Click(object sender, EventArgs e)
        {
            if (cmbBxUrunTipi.SelectedIndex >= 0)
            {
                Nesne yeni = new Nesne(cmbBxUrunTipi.Text, int.Parse(tbmiktar.Value.ToString()), double.Parse(tbbirimfiyat.Value.ToString()), kullanici);
                kullanici.NesneEkle(yeni);
                PanelGuncelle();
                MessageBox.Show("Eşya onaya gönderildi.");
            }
            else MessageBox.Show("Seçim yapınız.");
        }
        //Kullanıcının talepleri doğrultusunda, bakiye değişikliklerini admin onayına gönderen metod.
        private void btnBakiyeOnay_Click(object sender, EventArgs e)
        {
            while (true)
            {
                try
                {
                    if (cmbBxBirim.SelectedItem.ToString() == "Türk Lirası")
                    {
                        kullanici.BakiyeOnay += double.Parse(txtBxBakiye.Text);
                    }
                    else
                    {
                        kullanici.BakiyeOnay += Veriler.DovizDonustur(double.Parse(txtBxBakiye.Text), cmbBxBirim.SelectedItem.ToString());
                    }
                    PanelGuncelle();
                    MessageBox.Show("Bakiye onaya gönderildi.");
                    break;
                }
                catch (Exception ex)
                {
                    Veriler.dovizTarihi = Veriler.dovizTarihi.AddDays(-1);
                }
            }
        }
        //Kullanıcının talepleri doğrultusunda, ürün alış taleplerini sisteme kaydeden ve alış talebi oluşturan metod.
        private void btnAlisTalebiGonder_Click(object sender, EventArgs e)
        {
            if (cmbBxUrunTipi.SelectedIndex >= 0)
            {
                Talep talep = new Talep(kullanici, cmbBxUrunTipi.Text, int.Parse(tbmiktar.Value.ToString()), double.Parse(tbbirimfiyat.Value.ToString()));
                Veriler.AlisTalepleri.Add(talep);
                Veriler.TalepKontrol();
                Veriler.TalepKontrol();
                PanelGuncelle();
                MessageBox.Show("Alış talebiniz oluşturuldu.");
            }
        }
        //Belirli tarih aralıklarında meydana gelen işlemlerin raporunu almayı sağlayan metod.
        private void btnRaporAl_Click(object sender, EventArgs e)
        {
            Veriler.RaporAl(dtBaslangic.Value, dtBitis.Value);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            GirisPaneli giris1 = new GirisPaneli();
            giris1.Show();
        }
    }
}
