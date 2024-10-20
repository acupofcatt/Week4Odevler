namespace Constructor;

public class Bebek
{
    private string _name;
    private string _surname;
    private DateTime _birthday;

    public string Ad
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
    }   //Ad propertysi tanımlandı

    public string Soyad
    {
        get
        {
            return _surname;
        }
        set
        {
            _surname = value;
        }
    }   //Soyad propertysi tanımlandı

    public DateTime DogumTarihi
    {
        get
        {
            return _birthday;
        }
        set
        {
            _birthday = value;
        }
    }   //Doğum Tarihi propertysi tanımlandı

    public Bebek()  //default constructor
    {
        Ad = "Bilinmiyor";
        Soyad = "Bilinmiyor";
        DogumTarihi = DateTime.Now; //doğum tarihi o ana eşitlendi
        Console.WriteLine("Ingaaa!"); //ekrana ıngaa yazdı

    }

    public Bebek(string name, string surname) //isim soyisim parametresi alan constructor
    {
        Ad = name;
        Soyad = surname;
        DogumTarihi = DateTime.Now; //doğum tarihi o ana eşitlendi
        Console.WriteLine("Ingaaa!"); //ekrana ıngaa yazdı
    }

    public void PrintBaby() //bebeğin bilgilerini ekrana yazdıran fonksiyon
    {
        Console.WriteLine($"{Ad} {Soyad} isimli bebek {DogumTarihi} tarihinde dünyaya gelmiştir.");

    }
}