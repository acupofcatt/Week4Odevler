using Kutuphane;

public class Program
{
    public static void Main(string[] args)
    {
        //oluşturduğumuz sınıftan yeni bir örnek türetmek için new anahtar kelimesini kullanırız.
        //Üretilen örneğin değişken türü ve değişken ismi = new anahtar kelimesi ve Sınıfın adı 
        Kitap kitap1 = new Kitap();

        kitap1.KitapAdi = "Yalnızız";
        kitap1.YazarAdi = "Peyami";
        kitap1.YazarSoyadi = "Safa";
        kitap1.SayfaSayisi = 416;
        kitap1.YayinEvi = "Ötüken";
        
        kitap1.Yazdir();
        
        Kitap kitap2 = new Kitap();
        
        kitap2.KitapAdi = "Kendine Ait Bir Oda";
        kitap2.YazarAdi = "Virginia";
        kitap2.YazarSoyadi = "Woolf";
        kitap2.SayfaSayisi = 128;
        kitap2.YayinEvi = "Kırmızı Kedi";

        kitap2.Yazdir();
        
        Kitap kitap3 = new Kitap("Bizim Büyük Çaresizliğimiz","Barış","Bıçakçı", 167, "İletişim");
        kitap3.Yazdir();
        
        Kitap kitap4 = new Kitap("Otomatik Portakal","Anthony","Burgess", 176, "Türkiye İş");
        kitap4.Yazdir();
    }
}