using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
namespace StudentManagementSystem
{
    public partial class anaForm : MetroFramework.Forms.MetroForm
    {
        Ogrenci ogrenci;
        VeritabaniYonetimi yonet;

        public anaForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            yonet = new VeritabaniYonetimi();
            gridOgrenciListesi.DataSource = yonet.KayitlariListele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            // eğer boş text varsa bildirim gönder
            if(String.IsNullOrWhiteSpace(tbTcKimlikNo.Text) || String.IsNullOrWhiteSpace(tbAd.Text)
                || String.IsNullOrWhiteSpace(tbSoyad.Text) || String.IsNullOrWhiteSpace(tbOgrenciNo.Text))
            {
                BildirimGoster(3, true);
                return;
            }
            ogrenci = new Ogrenci(tbTcKimlikNo.Text, tbAd.Text, tbSoyad.Text, tbOgrenciNo.Text);

            if (yonet.YeniKayitEkle(ogrenci))
            {
                tbTcKimlikNo.Text = tbAd.Text = tbSoyad.Text = tbOgrenciNo.Text = "";
                BildirimGoster(2, false);
                gridOgrenciListesi.DataSource = yonet.KayitlariListele();
            }
            else
            {
                BildirimGoster(1, true);
            }
        }

        private void AramaYap(object sender, EventArgs e)
        {
            if (cbNeyeGore.SelectedIndex < 0 || cbNeyeGore.SelectedIndex > 3)
            {
                AramaBilgiGoster(1, true);
                return;
            }
            string aranacakMetin = tbAranacakMetin.Text.ToString();
            if (string.IsNullOrWhiteSpace(aranacakMetin))
            {
                AramaBilgiGoster(2,true);
                return;
            }
            string[] aramaCesidi = { "TCKimlikNo", "Ad", "Soyad", "OgrenciNo" };
            gridArananOgrenciler.DataSource = yonet.KayitAra(aramaCesidi[cbNeyeGore.SelectedIndex], aranacakMetin);
        }

        /* 
            Bildirim Panelleri için zamanlayıcılar ve hazır tanımlı metinler
             */
        private void  AramaBilgiPaneli_VisibleChanged(object sender, EventArgs e)
        {
            aramaBilgiYoket.Start();
        }
        private void AramaBilgiYoket_Tick(object sender, EventArgs e)
        {
            aramaBilgiPaneli.Visible = false;
            aramaBilgiYoket.Stop();
        }
        private void BildirimPaneli_VisibleChanged(object sender, EventArgs e)
        {
            bildirimYoket.Start();
        }
        private void BildirimYoket_Tick(object sender, EventArgs e)
        {
            bildirimPaneli.Visible = false;
            bildirimYoket.Stop();
        }
        private void AramaBilgiGoster(int bilgi,bool uyari)
        {
            if (uyari)
                lAramaBilgi.ForeColor = Color.DarkRed;
            else
                lAramaBilgi.ForeColor = Color.ForestGreen;

            switch (bilgi)
            {
                case 1:
                    lAramaBilgi.Text = "Seçim yapmalısınız!";
                    break;
                case 2:
                    lAramaBilgi.Text = "Aranacak metin boş olamaz!";
                    break;
                default:
                    lAramaBilgi.Text = "Bilinmeyen HATA!";
                    break;
            }
            aramaBilgiPaneli.Visible = true;
        }
        private void BildirimGoster(int bilgi, bool uyari)
        {
            
            if (uyari)
                lbildirim.ForeColor = Color.DarkRed;
            else
                lbildirim.ForeColor = Color.ForestGreen;

            switch (bilgi)
            {
                case 1:
                    lbildirim.Text = "Aynı TC Kimlik No'ya sahip öğrenci bulunmaktadır.";
                    break;
                case 2:
                    lbildirim.Text = "Yeni Öğrenci Başarıyla Eklendi!";
                    break;
                case 3:
                    lbildirim.Text = "Boş alan olamaz!";
                    break;
                default:
                    lbildirim.Text = "Bilinmeyen HATA!";
                    break;
            }
            bildirimPaneli.Visible = true;
        }

        // TCkimlikno ve öğrenci no için sadece sayıya izin veriyor
        private void SadeceSayiyaIzinVer(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // ad ve soyad için sadece digit girdisine izin verir.
        private void SadeceMetineIzinVer(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsUpper(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
