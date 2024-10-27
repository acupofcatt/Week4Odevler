

using Inheritance;

public class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogrenci = new Ogrenci();

        ogrenci.Ad = "Mete";
        ogrenci.Soyad = "Teoman";
        ogrenci.OgrenciNumarasi = 123456;
        
        ogrenci.OgrenciBilgi();

        Ogretmen ogretmen = new Ogretmen();
        
        ogretmen.Ad = "Hilal";
        ogretmen.Soyad = "Yaman";
        ogretmen.Maas = 23000;
        
        ogretmen.OgretmenBilgi();
        
    }
    
}