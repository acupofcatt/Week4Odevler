namespace Polymorphism;

//Base class tek başına kullanılamayacğı için abstract olarak tanımladım
public abstract class BaseGeometrikSekil 
{
    public int Genislik { get; set; }
    public int Yukseklik { get; set; }
    
    public string Sekil { get; set; }

    //Bilgileri yazdıran metot
    public void Print()
    {
        Console.WriteLine($"Genişliği: {Genislik} Yüksekliği {Yukseklik} olan {Sekil} Alanı: {AlanHesapla()}");
    }

    //Alan hesabı geometrik şekle göre değişebileceğinden farklı sınıflarda
    //override edebilmek için virtual olarak tanımladım.
    public virtual double AlanHesapla()
    {
        return Genislik * Yukseklik;
    }
}

//base classtaki AlanHesapla metodu alt classlarda da aynı şekilde geçerli olacağı için
//Kare ve Dikdörtgen classlarında ayrıca tanımlama yapmadım
public class Kare : BaseGeometrikSekil
{
    public Kare()
    {
        Sekil = "Kare";
    }
} 

public class Dikdortgen : BaseGeometrikSekil
{
    public Dikdortgen()
    {
        Sekil = "Dikdortgen";
    }
}

public class DikUcgen : BaseGeometrikSekil
{
    public DikUcgen()
    {
        Sekil = "DikUcgen";
    }
    //Dik üçgen için alan hesaplama dikdörtgen ve kareden farklı olduğu için
    //AlanHesapla metodunu override ederek işlemi güncelledim.
    public override double AlanHesapla()
    {
        return base.AlanHesapla()/2;
    }
}