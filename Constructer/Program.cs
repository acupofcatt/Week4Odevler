using Constructor;

class Program
{
    static void Main(string[] args)
    {
        Bebek bebek1 = new Bebek(); //default constructor çağırıldı ama veriler sonradan atandı
        
        bebek1.Ad = "Andrew";
        bebek1.Soyad = "Smith";
        
        bebek1.PrintBaby(); //bilgiler birinci bebek için yazdırıldı
        
        Bebek bebek2 = new Bebek("Arya", "Kılıç"); //parametreler doğrultusunda yeni bebek oluşturuldu
        
        bebek2.PrintBaby(); //bilgiler ikinci bebek için yazdırıldı
    }
}