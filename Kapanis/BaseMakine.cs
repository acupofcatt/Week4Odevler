namespace Kapanis;

public abstract class BaseMakine
{
    public DateTime UretimTarihi { get; set; }
    public string SeriNo { get; set; }
    public string Ad { get; set; }
    public string Aciklama { get; set; }
    public string IsletimSistemi { get; set; }

    //BaseMakine Base classından türetilen her sınıftan oluşacak nesne için o anın tarihini atar.
    public BaseMakine()
    {
        UretimTarihi = DateTime.Now;
    }

    //BilgileriYazdir metodunda ekrana yazdırmak istediğim çıktıyı bir string olarak dönen metot.
    //Bu string değeri türetilmiş sınıflarda özelleştirilmiş ekran çıktısı almak istediğimde,
    //çıktının istediğim bir bölümünde kullanabilmek adına bu metodu tanımladım.
    public string BilgiGetir()
    {
        return
            $"Ad: {Ad}, Uretim Tarihi: {UretimTarihi}, Seri No: {SeriNo}, Aciklama: {Aciklama}, Isletim Sistemi: {IsletimSistemi}";
    }

    //Alt sınıflarda hem bu bilgilerle hem de farklı bilgilerle kullanılabilmesi için virtual tanımladım
    public virtual void BilgileriYazdir()
    {
        Console.WriteLine(BilgiGetir());
    }

    //Base sınıfta bir tanımı veya işlevi yok, Alt sınıflarda sınıflara göre implement edilebilmesi için abstract tanımladım.
    public abstract void UrunAdiGetir();
}

public class Telefon : BaseMakine
{
    public bool TrLisansVar { get; set; }

    public override void BilgileriYazdir()
    {
        //Yukarıda string değer döndürdüğüm BilgiGetir() metoduyla aldığım stringi Console.Writeline içinde yazdırıyorum.
        //(TrLisansVar ? "var" : "yok") ifadesi de TrLisansVar değeri true ise var, false ise yok yazdırıyor. 
        Console.WriteLine($"Telefon {BilgiGetir()} TR Lisans durumu: {(TrLisansVar ? "var" : "yok")}");
    }

    public override void UrunAdiGetir()
    {
        Console.WriteLine($"Telefonunuzun adı ---> {Ad}");
    }
}

public class Bilgisayar : BaseMakine
{
    private int _usbPort;
    public bool BluetoothVar { get; set; }

    public int UsbPort
    {
        get { return _usbPort; }
        set
        {
            if (value == 2 || value == 4) //set ederken değer kontrolü yaptırıyorum. 2 veya 4se kabul ediyorum
            {
                _usbPort = value;
            }
            else //diğer tüm değerler için -1'e eşitliyorum
            {
                _usbPort = -1;
                Console.WriteLine("Hatalı port sayısı");
            }
        }
    }

    public override void BilgileriYazdir()
    {
        //Yukarıda string değer döndürdüğüm BilgiGetir() metoduyla aldığım stringi Console.Writeline içinde yazdırıyorum.
        //(BluetoothVar ? "var" : "yok") ifadesi de Bluetooth Var değeri true ise var, false ise yok yazdırıyor.
        //Usb Port sayısı ekleniyor
        Console.WriteLine(
            $"Bilgisayar {BilgiGetir()} Bluetooth: {(BluetoothVar ? "var" : "yok")} Usb Port Sayısı: {UsbPort}");
    }

    public override void UrunAdiGetir()
    {
        Console.WriteLine($"Bilgisayarınızın adı ---> {Ad}");
    }
}
