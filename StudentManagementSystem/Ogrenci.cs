using System;

public class Ogrenci
{
    public string tcKimlikNo { get; set; }
    public string ad { get; set; }
    public string soyad { get; set; }
    public string ogrenciNo { get; set; }


    public Ogrenci(string tcKimlikNo,string ad,string soyad,string ogrenciNo)
	{
        this.tcKimlikNo = tcKimlikNo;
        this.ad = ad;
        this.soyad = soyad;
        this.ogrenciNo = ogrenciNo;
	}
    
}
