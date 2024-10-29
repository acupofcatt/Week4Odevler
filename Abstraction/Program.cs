using Abstraction;

class Program
{
    public static void Main(string[] args)
    {
        ProjeYoneticisi calisan1 = new ProjeYoneticisi("Hasan", "Çıldırmış", "Yönetim");
        
        calisan1.BilgiYazdir();
        calisan1.Gorev();

        SatisTemsilcisi calisan2 = new SatisTemsilcisi("Hülya", "Bozkurt", "Satış");
        
        calisan2.BilgiYazdir();
        calisan2.Gorev();
        
        YazilimGelistirici calisan3 = new YazilimGelistirici("Leman", "Saki", "Yazilim");
        
        calisan3.BilgiYazdir();
        calisan3.Gorev();
        
    }
}