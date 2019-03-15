using MetroFramework.Controls;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

public class VeritabaniYonetimi
{
    SQLiteDataAdapter dat;
    SQLiteConnection con;
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
        SQLiteCommand com = new SQLiteCommand(sql, con);
        com.ExecuteNonQuery();
        con.Close();
    }

    public void YeniKayitEkle(Ogrenci ogrenci)
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
    }
    public void KayitlariListele()
    {
        string sql = "SELECT * FROM Ogrenciler;";
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
