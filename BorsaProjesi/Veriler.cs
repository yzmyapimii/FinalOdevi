using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace BorsaProjesi
{
    //kullanıcı ve admin verileri bu sınıfla isleme aldık.
    //UyeVarmi(), KayitOl(), GirisYap(), EnUcuzNesneBul(), KullaniciTalepleri(), kullaniciBul(), TalepKontrol()
    //AlimiGerceklestir(), NesneTemizle(), DovizDonustur(), RaporAl() metodlarını olusturduk.
    //Verileri islemeye yarayan bu metodları farklı yerlerde Veriler sınıfından çağırarak kullandık.
    class Veriler
    {
        public static List<Kullanici> uyeler = new List<Kullanici>();
        public static List<Talep> AlisTalepleri = new List<Talep>();
        public static List<Islem> Islemler = new List<Islem>();
        public static Admin yonetici = new Admin("admin", "admin", "admin", "admin", "admin", "admin", "admin", "admin");
        public static DateTime dovizTarihi = DateTime.Now;
        public static bool UyeVarmi(string TC, string Kullaniciadi)
        {
            foreach (Kullanici kullanici in uyeler)
            {
                if (kullanici.TC == TC || kullanici.KullaniciAdi == Kullaniciadi)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool KayitOl(Kullanici uye)
        {
            if (UyeVarmi(uye.TC, uye.KullaniciAdi) == false && uyeler.Contains(uye) == false)
            {
                uyeler.Add(uye);
                return true;
            }
            return false;
        }
        public static Kullanici GirisYap(string kadi, string sifre)
        {
            foreach (Kullanici kullanici in uyeler)
            {
                if (kullanici.KullaniciAdi == kadi && kullanici.Sifre == sifre)
                {
                    return kullanici;
                }
            }
            return null;
        }
        public static Nesne EnUcuzNesneBul(Talep talep)
        {
            Nesne enUcuz = null;
            foreach (Kullanici kullanici in uyeler)
            {
                if (kullanici.KullaniciAdi != talep.Alici.KullaniciAdi)
                {
                    foreach (Nesne nesne in kullanici.Esyalar)
                    {
                        if (nesne.Ad == talep.Urun && nesne.Onay && nesne.Fiyat<=talep.Fiyat)
                        {
                            if (enUcuz == null)
                            {
                                enUcuz = nesne;
                            }
                            else if (nesne.Fiyat < enUcuz.Fiyat)
                            {
                                enUcuz = nesne;
                            }
                        }
                    }
                }
            }
            return enUcuz;
        }
        public static List<Talep> KullaniciTalepleri(Kullanici kullanici)
        {
            List<Talep> talepler = new List<Talep>();
            foreach (Talep talep in AlisTalepleri)
            {
                if (talep.Alici == kullanici)
                {
                    talepler.Add(talep);
                }
            }
            return talepler;
        }
        public static Kullanici kullaniciBul(string kullaniciadi)
        {
            foreach (Kullanici kullanici in uyeler)
            {
                if (kullanici.KullaniciAdi == kullaniciadi)
                {
                    return kullanici;
                }
            }
            return null;
        }
        public static void TalepKontrol()
        {
            List<Talep> tamamlananTalepler = new List<Talep>();
            foreach (Talep talep in AlisTalepleri)
            {
                Nesne alinacakNesne;
                do
                {
                    alinacakNesne = EnUcuzNesneBul(talep);
                    if (alinacakNesne != null)
                    {
                        talep.AlimiGerceklestir(alinacakNesne);
                        NesneTemizle();
                        if (talep.Tamamlandimi())
                        {
                            tamamlananTalepler.Add(talep);
                            break;
                        }
                        else if (talep.Alici.Bakiye < alinacakNesne.Fiyat || alinacakNesne.Miktar <= 0)
                        {
                            break;
                        }
                    }
                    else break;
                } while (alinacakNesne != null);
            }
            foreach (Talep talep1 in tamamlananTalepler)
            {
                AlisTalepleri.Remove(talep1);
            }
            NesneTemizle();
        }
        public static void NesneTemizle()
        {
            List<Nesne> silinecekler;
            foreach (Kullanici kullanici in uyeler)
            {
                silinecekler = new List<Nesne>();
                foreach (Nesne nesne in kullanici.Esyalar)
                {
                    if (nesne.Miktar == 0)
                    {
                        silinecekler.Add(nesne);
                    }
                }
                foreach (Nesne silinecek in silinecekler)
                {
                    kullanici.Esyalar.Remove(silinecek);
                }
            }

        }
        public static double DovizDonustur(double miktar, string doviz)
        {
            try
            {
                string gun = dovizTarihi.Day.ToString();
                string ay = dovizTarihi.Month.ToString();
                string yil = dovizTarihi.Year.ToString();
                if (gun.Length < 2)
                {
                    gun = "0" + gun;
                }
                if (ay.Length < 2)
                {
                    ay = "0" + ay;
                }
                XmlDocument veriler = new XmlDocument();
                veriler.Load("http://www.tcmb.gov.tr/kurlar/" + yil + ay + "/" + gun + ay + yil + ".xml");
                switch (doviz)
                {
                    case "Dolar":
                        miktar *=(double) Convert.ToDecimal(veriler.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "USD")).InnerText.Replace(".",",")) ;
                        break;
                    case "Euro":
                        miktar*= (double)Convert.ToDecimal(veriler.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "EUR")).InnerText.Replace(".",","));
                        break;
                    case "Sterlin":
                        miktar*= (double)Convert.ToDecimal(veriler.SelectSingleNode(string.Format("Tarih_Date/Currency[@Kod='{0}']/ForexSelling", "GBP")).InnerText.Replace(".",","));
                        break;
                    default:
                        break;
                }
                return miktar;
            }
            catch (XmlException ex)
            {
            }
            return 0;
        }
        public static void RaporAl(DateTime baslangic,DateTime bitis)
        {
            ReportViewer reportViewer = new ReportViewer();
            ReportDataSource rds = new ReportDataSource("DataSet1", Islemler.Where(x=>x.TarihSaat>=baslangic.Date && x.TarihSaat.Date<=bitis.Date).ToList());
            //ReportDataSource rds = new ReportDataSource("DataSet1", Islemler);
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.LocalReport.ReportPath =
                (Application.StartupPath + "\\Report1.rdlc");
            reportViewer.LocalReport.DataSources.Clear();
            reportViewer.LocalReport.DataSources.Add(rds);
            reportViewer.LocalReport.Refresh();
            reportViewer.RefreshReport();
            byte[] Bytes = reportViewer.LocalReport.Render(format: "PDF", deviceInfo: "");
            using (FileStream stream = new FileStream("rapor.pdf", FileMode.Create))
            {
                stream.Write(Bytes, 0, Bytes.Length);
            }
            Process.Start("rapor.pdf");
        }

    }
}
