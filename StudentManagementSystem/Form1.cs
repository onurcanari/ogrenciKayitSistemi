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
                lbildirim.ForeColor = Color.DarkRed;
                lbildirim.Text = "!Boş alan bırakılmamalı!";
                bildirimPaneli.Visible = true;
                return;
            }
            ogrenci = new Ogrenci(tbTcKimlikNo.Text, tbAd.Text, tbSoyad.Text, tbOgrenciNo.Text);
            
            yonet.YeniKayitEkle(ogrenci);
            gridOgrenciListesi.DataSource =  yonet.KayitlariListele();
            tbTcKimlikNo.Text = tbAd.Text = tbSoyad.Text = tbOgrenciNo.Text = "";

            lbildirim.ForeColor = Color.ForestGreen;
            lbildirim.Text = "!Yeni Öğrenci Başarıyla Eklendi!";
            bildirimPaneli.Visible = true;
        }

        private void BtnOgrenciAra_Click(object sender, EventArgs e)
        {
            string aranacakMetin = tbAranacakMetin.Text.ToString();
            if (string.IsNullOrWhiteSpace(aranacakMetin))
            {
                lAramaBilgi.ForeColor = Color.DarkRed;
                lAramaBilgi.Text = "!Aranacak metin boş olamaz.";
                aramaBilgiPaneli.Visible = true;
                return;
            }
            string[] aramaCesidi = { "TCKimlikNo", "Ad", "Soyad", "OgrenciNo" };
            gridArananOgrenciler.DataSource = yonet.KayitAra("Ad", "Burak");
            //gridArananOgrenciler.DataSource = yonet.KayitAra(aramaCesidi[cbNeyeGore.SelectedIndex], aranacakMetin).Tables["Ogrenciler"];
        }

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
    }
}
