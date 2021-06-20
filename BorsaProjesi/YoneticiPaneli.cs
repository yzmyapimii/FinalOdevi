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
    public partial class YoneticiPaneli : Form
    {
        public YoneticiPaneli()
        {
            InitializeComponent();
        }
        //Belirli tarih aralığında borsa sisteminde gerçekleşen alım-satım işlemlerinin raporunu görmemizi sağlayan kısım.
        private void btnİslemler_Click(object sender, EventArgs e)
        {
            new Islemler().ShowDialog();
        }
        //Panelde meydana gelen değişiklikleri panele yansıtmak için kullandığımız kısım.
        void PanelGuncelle()
        {
            foreach (Kullanici kullanici in Veriler.uyeler)
            {
                Kullanicilar.Items.Add(kullanici.KullaniciAdi + " - " + kullanici.Ad + " " + kullanici.Soyad + " Bakiye: " + kullanici.Bakiye);
            }
        }
        //İlgili kullanıcıya tıkladığımızda kullanıcının taleplerini güncel olarak yansıtan metod.
        void TalepleriGuncelle()
        {
            if (Kullanicilar.SelectedIndex>=0)
            {
                string kadi = Kullanicilar.SelectedItem.ToString().Split('-')[0].Trim();
                Kullanici secilen = Veriler.kullaniciBul(kadi);
                UrunTalepleri.Items.Clear();
                lbltalep.Text = secilen.BakiyeOnay.ToString()+" TL";
                foreach (Nesne urun in secilen.Esyalar )
                {
                    if (urun.Onay==false)
                    {
                        UrunTalepleri.Items.Add("Ad :" + urun.Ad + " Miktar: " + urun.Miktar + " Fiyat: " + urun.Fiyat+" TL");
                    }
                }
            }
        }
        //Yönetici panelinin yüklenmesi sırasında panelde meydana gelen değişiklikleri güncelliyor ve mevcut kullanıcı taleplerini kontrol ediyoruz.
        private void YoneticiPaneli_Load(object sender, EventArgs e)
        {
            Veriler.TalepKontrol();
            PanelGuncelle();
        }

        private void Kullanicilar_SelectedIndexChanged(object sender, EventArgs e)
        {
            TalepleriGuncelle();
        }
        //Kullanıcı taleplerine onay vermemizi ve gerçekleşen değişikliklerin sisteme kaydedilmesini sağlayan kod blogu.
        private void btnTalepOnay_Click(object sender, EventArgs e)
        {
            if (Kullanicilar.SelectedIndex>=0)
            {
                string kadi = Kullanicilar.SelectedItem.ToString().Split('-')[0].Trim();
                Kullanici secilen = Veriler.kullaniciBul(kadi);
                foreach (Nesne urun in secilen.Esyalar)
                {
                    if (urun.Onay==false)
                    {
                        urun.Onay = true;
                    }
                }
            }
            TalepleriGuncelle();
            Veriler.TalepKontrol();
        }
        //Kullanıcının talepleri doğrultusunda admin onayına gönderilen bakiye değişikliklerini onaylamayı sağlayan kod bloğu.
        private void btnBakiyeOnayla_Click(object sender, EventArgs e)
        {
            if (Kullanicilar.SelectedIndex >= 0)
            {
                string kadi = Kullanicilar.SelectedItem.ToString().Split('-')[0].Trim();
                Kullanici secilen = Veriler.kullaniciBul(kadi);
                secilen.Bakiye += secilen.BakiyeOnay;
                secilen.BakiyeOnay = 0;
            }
            TalepleriGuncelle();
        }

        private void YoneticiPaneli_FormClosing(object sender, FormClosingEventArgs e)
        {
            Veriler.TalepKontrol();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        //Girilen tarih aralığına göre döviz kurlarını güncelleyen kod blogu.
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Veriler.dovizTarihi = dteTmePckrYonetici.Value;
            MessageBox.Show("Güncelleme başarılı");
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
            GirisPaneli giris1 = new GirisPaneli();
            giris1.Show();
        }
    }
}
