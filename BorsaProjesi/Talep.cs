using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BorsaProjesi
{
    //alış talebi olusturmak icin gerekli bilgileri alan ve islemleri yapan sınıf.
    //talep sınıfı icinde kullanıcının isteklerine göre belli bilgileri aldık ve gerekli atamaları yaptık.
    //AlimiGerceklestir metonu ile kullanıcının almak istedigi ürün cins ve miktarları tanımlandı ve alıcıdan 
    //kesilmesi gereken muhasebe ücretleri hesaplanarak toplam fiyata yansıtıldı.
    class Talep
    {
        private Kullanici alici;
        private string urun;
        private int miktar;
        private double fiyat;

        public Talep(Kullanici alici, string urun, int miktar,double fiyat)
        {
            Alici = alici;
            Urun = urun;
            Miktar = miktar;
            this.fiyat = fiyat;
        }
        public void AlimiGerceklestir(Nesne urun)
        {
            Islem islem;
            double baslangicBakiye = alici.Bakiye;
            int gecicimiktar = miktar;
            double toplamTutar = miktar * urun.Fiyat;
            if (alici.Bakiye>0 && this.fiyat>=urun.Fiyat)
            {
                if (urun.Miktar >= miktar && alici.Bakiye >= toplamTutar)
                {
                    urun.Miktar -= miktar;
                    alici.Bakiye -= toplamTutar;
                    alici.Bakiye -= (toplamTutar * 0.01);
                    urun.Sahibi.Bakiye += toplamTutar;
                    Nesne yeniUrun = new Nesne(urun.Ad, miktar, urun.Fiyat, alici);
                    yeniUrun.Onay = true;
                    alici.NesneEkle(yeniUrun);
                    miktar = 0;
                }
                else if (urun.Miktar >= miktar && alici.Bakiye <= toplamTutar)
                {
                    int alinabilecekMiktar = (int)(alici.Bakiye / urun.Fiyat);
                    if (alinabilecekMiktar > 0)
                    {
                        toplamTutar = alinabilecekMiktar * urun.Fiyat;
                        urun.Miktar -= alinabilecekMiktar;
                        miktar -= alinabilecekMiktar;
                        alici.Bakiye -= toplamTutar;
                        alici.Bakiye -= (toplamTutar * 0.01);
                        urun.Sahibi.Bakiye += toplamTutar;
                        Nesne yeniUrun = new Nesne(urun.Ad, alinabilecekMiktar, urun.Fiyat, alici);
                        yeniUrun.Onay = true;
                        alici.NesneEkle(yeniUrun);
                    }
                }
                else
                {
                    int alinabilecekMiktar = urun.Miktar;
                    toplamTutar = alinabilecekMiktar * urun.Fiyat;
                    if (alici.Bakiye >= toplamTutar)
                    {
                        alici.Bakiye -= toplamTutar;
                        alici.Bakiye -= (toplamTutar * 0.01);
                        urun.Sahibi.Bakiye += toplamTutar;
                        miktar -= alinabilecekMiktar;
                        urun.Miktar -= alinabilecekMiktar;
                        Nesne yeniUrun = new Nesne(urun.Ad, alinabilecekMiktar, urun.Fiyat, alici);
                        yeniUrun.Onay = true;
                        alici.NesneEkle(yeniUrun);
                    }
                }
                //Bu kısımda eger bakiye durumları uygunsa, alısverisin gerceklesmesi ve elde edilen yeni bilgilerin
                //rapor ekranına yansıtılmasını sağladık.
                if (baslangicBakiye != alici.Bakiye)
                {
                    islem = new Islem(alici.Ad + " " + gecicimiktar + " kilo " + urun.Ad + " alım isteği için birim başına " + urun.Fiyat + " tl + %1 muhasebe ücreti tahsil edilerek alım işlemi gerçekleşti",
                    alici.Ad + " " + urun.Sahibi.Ad + "'in hesabına " + toplamTutar + " TL gönderdi.", alici.Ad + " " + alici.Bakiye + " tl parası kaldı",
                    urun.Fiyat + " tl");
                    Veriler.Islemler.Add(islem);
                }
            }
        }
        public bool Tamamlandimi()
        {
            return miktar == 0;
        }
        public Kullanici Alici { get => alici; set => alici = value; }
        public string Urun { get => urun; set => urun = value; }
        public int Miktar { get => miktar; set => miktar = value; }
        public double Fiyat { get => fiyat; set => fiyat = value; }
    }
}
