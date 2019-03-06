using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using MetroFramework.Controls;
public class VeritabaniYonetimi
{
    SQLiteDataAdapter dat;
    SQLiteConnection con;
    SQLiteCommand com;
    DataSet dataSet;
    MetroGrid metroGrid;

    public VeritabaniYonetimi(MetroGrid metro)
	{
        metroGrid = metro;
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
    
    public void yeniKayitEkle(string tcKimlikNo,string ad,string soyad,string ogrenciNo)
    {
        com = new SQLiteCommand();
        con.Open();
        com.Connection = con;
        com.CommandText = "INSERT into Ogrenciler(TCKimlikNo,Ad,Soyad,ogrenciNo) " +
            "VALUES('"+tcKimlikNo+"','"+ad+"','"+soyad+"','"+ogrenciNo+"')";
        com.ExecuteNonQuery();
        con.Close();
    }
    public void listele()
    {
        con.Open();
        dat = new SQLiteDataAdapter("SELECT TCKimlikNo,Ad,Soyad,OgrenciNo From Ogrenciler;",con);
        dataSet = new DataSet();
        dat.Fill(dataSet, "Ogrenciler");
        metroGrid.DataSource = dataSet.Tables["Ogrenciler"];
        con.Close();

    }

}
