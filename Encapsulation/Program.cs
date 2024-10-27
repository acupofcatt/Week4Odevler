
using Encapsulation;

class Program
{
    static void Main(string[] args)
    {
        Araba araba1 = KullaniciGirisi();
        
        araba1.Print();
        
    }

    public static Araba KullaniciGirisi()
    {
        Araba araba = new Araba();
        
        Console.WriteLine("Lütfen araba için Marka giriniz.");
        string? marka = Console.ReadLine();

        //sadece veri girişi olduğunda atama yapıp boş karakter için ramde yer tutmasını istemedim
        //tekrar giriş yaptırmadığım için uyarı da vermedim.
        
        if (!string.IsNullOrWhiteSpace(marka)) 
        {
            araba.Marka = marka;
        }
        
        Console.WriteLine("Lütfen araba için Model giriniz.");
        string? model = Console.ReadLine();
        
        if (!string.IsNullOrWhiteSpace(model))
        {
            araba.Model = model;
        }
        
        Console.WriteLine("Lütfen araba için Renk giriniz.");
        string? renk = Console.ReadLine();
        
        if (!string.IsNullOrWhiteSpace(renk))
        {
            araba.Renk = renk;
        }
        
        Console.WriteLine("Lütfen araba için Kapı sayısı giriniz.");
        string? kapiSayisiStr = Console.ReadLine();
       
        if (int.TryParse(kapiSayisiStr, out int kapiSayisi))
            {
                araba.KapiSayisi = kapiSayisi;
            }
           
        return araba;
    }
}