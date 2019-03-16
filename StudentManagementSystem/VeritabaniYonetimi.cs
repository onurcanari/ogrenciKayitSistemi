using MetroFramework.Controls;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

public class VeritabaniYonetimi
{
    SQLiteDataAdapter dat;
    SQLiteConnection con;

    //Dosyamızın varlığından emin olur. Ardından bağlantıyı kurar.
    public VeritabaniYonetimi()
    {
       
        if (!File.Exists("veritabani.sqlite"))
            VeritabaniOlustur();
        con = new SQLiteConnection("Data Source=veritabani.sqlite;Version=3;");
    }

    // Veritabani dosyamız yoksa oluşturuyor. Ardından içinde tablo oluşturuyor.
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
        SQLiteCommand com = new SQLiteCommand(sql, con);
        com.ExecuteNonQuery();
        con.Close();
    }

    //Veritabanına yeni kayıt ekler.
    public bool YeniKayitEkle(Ogrenci ogrenci)
    {
        con.Open();
        string sqlSelect = "SELECT TCKimlikNo,Ad,Soyad,OgrenciNo FROM Ogrenciler WHERE TCKimlikNo=@TCKimlikNo OR OgrenciNo=@OgrenciNo";
        SQLiteCommand selectCommand = new SQLiteCommand(sqlSelect, con);
        selectCommand.Parameters.AddWithValue("@TCKimlikNo", ogrenci.tcKimlikNo);
        selectCommand.Parameters.AddWithValue("@OgrenciNo", ogrenci.ogrenciNo);
        SQLiteDataReader dataReader = selectCommand.ExecuteReader();
        bool studentExist = dataReader.Read();
        // Girilen tckimlikno ile öğrenci no yu kontrol et eğer bir kayda ulaşırsan ekleme
        if (studentExist)
        {
            con.Close();
            return false;
        }else 
        {
            using (SQLiteTransaction liteTransaction = con.BeginTransaction())
            {
                using (SQLiteCommand com = new SQLiteCommand(con))
                {
                    string sqlInsert = "INSERT INTO Ogrenciler(TCKimlikNo,Ad,Soyad,OgrenciNo) VALUES(@TCKimlikNo, @Ad, @Soyad, @OgrenciNo)";
                    com.CommandText = sqlInsert;
                    com.Parameters.AddWithValue("@TCKimlikNo", ogrenci.tcKimlikNo);
                    com.Parameters.AddWithValue("@Ad", ogrenci.ad);
                    com.Parameters.AddWithValue("@Soyad", ogrenci.soyad);
                    com.Parameters.AddWithValue("@OgrenciNo", ogrenci.ogrenciNo);
                    com.ExecuteNonQuery();
                }
                liteTransaction.Commit();
            }
        }
        con.Close();
        return true;
    }

    // Veritabanından kayıtları çekip bunları  DataTable aracılığıyla döndürür.
    public DataTable KayitlariListele()
    {
        DataSet dataSet = new DataSet();
        string sql = "SELECT * FROM Ogrenciler;";
        con.Open();
        dat = new SQLiteDataAdapter(sql,con);
        dat.Fill(dataSet, "Ogrenciler");
        con.Close();
        return dataSet.Tables["Ogrenciler"];
    }

    // Veritabanındaki kayıtları istenen özellikler için tarar. Bulduğu kayıtları DataTable aracılığıyla döndürür.
    public DataTable KayitAra(string neyeGore, string ara)
    {
        DataSet dataSet = new DataSet();
        con.Open();
        using(SQLiteCommand com = new SQLiteCommand(con))
        {
            com.CommandText = string.Format(com.CommandText = "SELECT TCKimlikNo,Ad,Soyad,OgrenciNo FROM Ogrenciler WHERE lower({0}) ='{1}'", neyeGore, ara);
            //com.CommandText = "SELECT TCKimlikNo,Ad,Soyad,OgrenciNo FROM Ogrenciler WHERE Ad ='@Ara'";
            //com.Parameters.AddWithValue("@NeyeGore", neyeGore);
            //com.Parameters.AddWithValue("@Ara", ara);
            dat = new SQLiteDataAdapter(com);
            dat.Fill(dataSet, "Ogrenciler");
        }
        con.Close();
        return dataSet.Tables["Ogrenciler"];
    }

}
