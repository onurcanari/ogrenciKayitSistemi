using MetroFramework.Controls;
using System.Data;
using System.Data.SQLite;
using System.IO;
public class VeritabaniYonetimi
{
    SQLiteDataAdapter dat;
    SQLiteConnection con;
    SQLiteCommand com;
    DataSet dataSet;
    MetroGrid arananOgrenciListesi;
    MetroGrid ogrenciListesi;

    public VeritabaniYonetimi(MetroGrid ogrenciListesi, MetroGrid arananOgrenciListesi)
    {
        this.ogrenciListesi = ogrenciListesi;
        this.arananOgrenciListesi = arananOgrenciListesi;
        // Veritabani dosyamız yoksa oluşturuyor. Ardından içinde tablo oluşturuyor.
        if (!File.Exists("veritabani.sqlite"))
            VeritabaniOlustur();
        con = new SQLiteConnection("Data Source=veritabani.sqlite;Version=3;");
    }
    public void VeritabaniOlustur()
    {
        SQLiteConnection.CreateFile("veritabani.sqlite");
        string sql = @"CREATE TABLE Ogrenciler(
                       ID INTEGER PRIMARY KEY AUTOINCREMENT,
                       TCKimlikNo       TEXT        NOT NULL,
                       Ad               TEXT        NOT NULL,
                       Soyad            TEXT        NOT NULL,
                       OgrenciNo        TEXT        NOT NULL
                       );";
        con.Open();
        com = new SQLiteCommand(sql, con);
        com.ExecuteNonQuery();
        con.Close();
    }

    public void YeniKayitEkle(Ogrenci ogrenci)
    {
        string sql = "INSERT into Ogrenciler(TCKimlikNo,Ad,Soyad,OgrenciNo) " +
            "VALUES('" + ogrenci.tcKimlikNo + "','" + ogrenci.ad + "','" + ogrenci.soyad + "','" + ogrenci.ogrenciNo + "')";
        com = new SQLiteCommand(sql, con);
        con.Open();
        com.ExecuteNonQuery();
        con.Close();
    }
    public void KayitlariListele()
    {
        string sql = "SELECT TCKimlikNo,Ad,Soyad,OgrenciNo From Ogrenciler;";
        con.Open();
        dat = new SQLiteDataAdapter(sql, con);
        dataSet = new DataSet();
        dat.Fill(dataSet, "Ogrenciler");
        ogrenciListesi.DataSource = dataSet.Tables["Ogrenciler"];
        con.Close();
    }

    public void KayitAra(string neyeGore, string ara)
    {
        con.Open();
        string sql = "SELECT TCKimlikNo,Ad,Soyad,OgrenciNo FROM Ogrenciler WHERE " + neyeGore + "='" + ara + "'";
        dat = new SQLiteDataAdapter(sql, con);
        dataSet = new DataSet();
        dat.Fill(dataSet, "Ogrenciler");
        arananOgrenciListesi.DataSource = dataSet.Tables["Ogrenciler"];
        con.Close();
    }

}
