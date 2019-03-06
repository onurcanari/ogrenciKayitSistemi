using System;

public class VeritabaniYonetimi
{
    
	public VeritabaniYonetimi()
	{
	}
    public void VeritabaniOlustur()
    {
        SQLiteConnection.CreateFile("db/veritabani.sqlite");
        SQLiteConnection con = new SQLiteConnection("Data Source=db/veritabani.sqlite;Version=3;");
    }
}
