namespace Abstraction;

//Ortak özellikleri içinde barındıran ve görevler doğrultusunda alt sınıflara ayrılacak Calisan sınıfı
public abstract class Calisan
{
    //Ortak olarak tüm alt sınıfların barındırdığı özellikleri propertylerle tanımladım
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public string Departman { get; set; }

    //Alt sınıflarda her bir göreve göre ayrı değer yazdıracak bir metot.
    //Her sınıfta farklı olarak değer atayabilmek için abstract olarak tanımladım.
    public abstract void Gorev();

    //Yeni bir calisan oluşturulurken değerlerin o aşamada atanması için parametre alan bir constructor tanımladım.
    public Calisan(string ad, string soyad, string departman)
    {
        Ad = ad;
        Soyad = soyad;
        Departman = departman;
    }

    //Bilgileri ekrana yazdıran bir metot
    public void BilgiYazdir()
    {
        Console.WriteLine($"Ad: {Ad} Soyad: {Soyad} Departman: {Departman}");
    }

}
//Görevler doğrultusunda ayrışan alt sınıflar tanımladım, her sınıf Gorev() metodunda kendi görevini ekrana yazdırıyor.  
public class ProjeYoneticisi : Calisan
{
    public ProjeYoneticisi(string ad, string soyad, string departman) : base(ad, soyad, departman)
    {
    }

    public override void Gorev()
    {
        Console.WriteLine("Proje Yöneticisi olarak çalışıyorum");
    }
}

public class YazilimGelistirici : Calisan
{
    public YazilimGelistirici(string ad, string soyad, string departman) : base(ad, soyad, departman)
    {
    }

    public override void Gorev()
    {
        Console.WriteLine("Yazılım Geliştirici olarak çalışıyorum");
    }
}

public class SatisTemsilcisi : Calisan
{
    public SatisTemsilcisi(string ad, string soyad, string departman) : base(ad, soyad, departman)
    {
    }

    public override void Gorev()
    {
        Console.WriteLine("Satış Temsilcisi olarak çalışıyorum");
    }
}

