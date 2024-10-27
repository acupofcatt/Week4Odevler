namespace Inheritance;

public class BaseKisi
{
    public string Ad { get; set; }
    public string Soyad { get; set; }

    public void BilgiYazdir() //yalnızca isim soyisim yazdıran bir metot
    {
        Console.Write($"Ad: {Ad} Soyad: {Soyad}");
    }
    
    //Metot içinde ek bir parametre girildiğinde yalnızca isim soyisim yazdıran metotu çağırıp
    //ayrıca girilen parametreyi de yazdırır.
    public void BilgiYazdir(string additionalData)
    {
        Console.Write($"Ad: {Ad}, Soyad: {Soyad}, {additionalData}");
    }
}

public class Ogrenci : BaseKisi //BaseKisi sınıfını miras alan Ogrenci sınıfı
{
    public int OgrenciNumarasi { get; set; } //ogrenci sınıfına ait property

    public void OgrenciBilgi() //Ogretmen sınıfına ait metot
    {
        BilgiYazdir($"Öğrenci Numarası: {OgrenciNumarasi}");
    }
}

public class Ogretmen : BaseKisi //BaseKisi sınıfını miras alan Ogretmen sınıfı
{
    public int Maas { get; set; } //Ogretmen sınıfına ait property

    public void OgretmenBilgi() //Ogretmen sınıfına ait metot
    {
        BilgiYazdir($"Maaş: {Maas}");
    }
}