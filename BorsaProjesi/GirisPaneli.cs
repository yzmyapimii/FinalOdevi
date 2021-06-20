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
    public partial class GirisPaneli : Form
    {
        public GirisPaneli()
        {
            InitializeComponent();
        }
        //Girilen kullanıcı bilgilerine göre kayıt olusturmayı sağlayan kod blogu.
        private void btnKayıtOlustur_Click(object sender, EventArgs e)
        {
            Kullanici yeniKayit = new Kullanici(txtBxKayıtKAdi.Text, txtBxKayıtSifre.Text, mskBxTC.Text, txtBxKayıtAd.Text, txtBxKayıtSoyad.Text, mskdBxTel.Text, txtBxMail.Text, txtBxAdres.Text);
            if (Veriler.KayitOl(yeniKayit))
            {
                MessageBox.Show("Kayıt başarılı.");
            }
            else
            {
                MessageBox.Show("Kayıt başarısız.");
            }

            txtBxKayıtKAdi.Text = "";
            txtBxKayıtSifre.Text = "";
            mskBxTC.Text = "";
            txtBxKayıtAd.Text = "";
            txtBxKayıtSoyad.Text = "";
            mskdBxTel.Text="";
            txtBxMail.Text="";
            txtBxAdres.Text = "";
        }
        //Girilen kullanıcı adı - sifre bilgilerinin sistemde kayıtlı bilgilerle eşleşmesi halinde
        //girilen bilgilere göre admin yada kullanıcı panellerine yönlendiren kod parcası.
        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            if (txtBxKullaniciAdi.Text=="admin"&&txtBxSifre.Text=="admin")
            {
                this.Hide();
                new YoneticiPaneli().ShowDialog();
            }
            else
            {
                Kullanici giris = Veriler.GirisYap(txtBxKullaniciAdi.Text, txtBxSifre.Text);
                if (giris != null)
                {
                    this.Hide();
                    new KullaniciPanel(giris).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı/şifre hatalı.");
                }
            }
        }

        private void chckBxGoster_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBxGoster.CheckState==CheckState.Checked)
            {
                txtBxSifre.UseSystemPasswordChar = true;
                chckBxGoster.Text = "Şifreyi Gizle";
            }
            else if (chckBxGoster.CheckState == CheckState.Unchecked)
            {
                txtBxSifre.UseSystemPasswordChar = false;
                chckBxGoster.Text = "Şifreyi Göster";
            }
        }
    }
}
