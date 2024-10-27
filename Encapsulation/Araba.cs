namespace Encapsulation;

public class Araba
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }

    private int _kapiSayisi; //girilen kapı sayısı özelinde kontrol yapacağımız için direkt property olarak tanımlamadım

    public int KapiSayisi 
    {
        get
        {
            return _kapiSayisi;
        }
        set
        {
            if (value == 2 || value == 4) //set ederken değer kontrolü yaptırıyorum. 2 veya 4se kabul ediyorum
            {
                _kapiSayisi = value;
            }
            else //diğer tüm değerler için -1'e eşitliyorum
            {
                _kapiSayisi = -1;
                Console.WriteLine("Geçersiz kapı sayısı.");
            }
        }
    }

    public void Print()
    {
        Console.WriteLine($"Marka: {Marka} \nModel: {Model} \nRenk: {Renk} \nKapiSayisi: {KapiSayisi}");
    }
}