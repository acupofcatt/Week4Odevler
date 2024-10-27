using Polymorphism;

public class Program
{
    public static void Main()
    {
        Kare kare = new Kare(); 
        kare.Yukseklik = 3;
        kare.Genislik = 3;
        
        Dikdortgen dikdortgen = new Dikdortgen();
        dikdortgen.Yukseklik = 7;
        dikdortgen.Genislik = 3;
        
        DikUcgen dikUcgen = new DikUcgen();
        dikUcgen.Yukseklik = 4;
        dikUcgen.Genislik = 3;
        
        //Hesaplanan bilgilerin yazdırılması
        kare.Print();
        dikdortgen.Print();
        dikUcgen.Print();
        
    }
}