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
            gridOgrenciListesi.BackgroundColor = Color.Honeydew;

            ogrenci = new Ogrenci();
            yonet = new VeritabaniYonetimi(gridOgrenciListesi);
            yonet.listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            
            yonet.yeniKayitEkle(tbTcKimlikNo.Text,tbAd.Text,tbSoyad.Text,tbOgrenciNo.Text);
            //yonet.listele();
        }

        private void GridOgrenciListesi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //yonet.listele();
        }

        private void GridOgrenciListesi_DataSourceChanged(object sender, EventArgs e)
        {
            
        }
    }
}
