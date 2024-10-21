namespace Kutuphane;

//Kitap sınıfıyla bütün kitaplar için ortak özellikleri ve metotları burada ortak olarak tanımlıyoruz. Bu sayede yeni
//bir kitap oluşturmak istediğimizde bu sınıftan yeni bir örnek türetiyoruz.
public class Kitap
{
    //kitap sınıfında bulanabilecek özellikler. yeni bir kitap oluşturduğumuzda verileri bu properties üzerinde barındırıyoruz.
    public string KitapAdi { get; set; }
    public string YazarAdi { get; set; }
    public string YazarSoyadi { get; set; }
    public int SayfaSayisi { get; set; }
    public string YayinEvi { get; set; }
    public DateTime KayitTarihi { get; set; }

    //sınıfın default constructor'ı herhangi bir parametre almaz.
    //yeni bir kitap örneği oluşturulurken herhangi bir parametre verilmezse bu constructor çalışır ve
    //ilk değerler null kalır. değer ataması örnek üretildikten sonra yapılır
    public Kitap()
    {
        //yeni bir kitap türetildiği zaman kayıt tarihi o anki zaman olarak atanır.
        KayitTarihi = DateTime.Now; 
    }

    //parametre alan constructor. bu sınıftan yeni bir örnek üretilirken constructor içerisinde beklediği
    //parametleri girerse bu constructor çalışır. eksik parametre girilmesi durumunda hata verir.
    //değer ataması örnek üretilirken verilen parametrelerle yapılır.
    public Kitap(string kitap, string ad, string soyad, int sayfaSayisi, string yayinEvi)
    {
        //yeni bir kitap türetildiği zaman kayıt tarihi o anki zaman olarak atanır.
        KayitTarihi = DateTime.Now;
        KitapAdi = kitap;
        YazarAdi = ad;
        YazarSoyadi = soyad;
        SayfaSayisi = sayfaSayisi;
        YayinEvi = yayinEvi;
    }

    public void Yazdir()
    {
        Console.WriteLine($"\nKitap: {KitapAdi} \nYazar: {YazarAdi} {YazarSoyadi} \nSayfa: {SayfaSayisi} \nYayinEvi: {YayinEvi} \nKayıt Tarihi: {KayitTarihi}");
    }
}