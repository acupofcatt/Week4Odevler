using IlkSinif;

class Program
{
    static void Main(string[] args)
    {
        Person ogrenci1 = new Person(); //yeni kişi tanımlama
        ogrenci1.Name = "Ahmet";
        ogrenci1.Surname = "Mısra";
        ogrenci1.DateOfBirth = new DateTime(2009, 09, 08);

        ogrenci1.Introduce();   //tanımlanan kişiyi tanıtma

        Person ogrenci2 = new Person();
        ogrenci2.Name = "Murat";
        ogrenci2.Surname = "Kozan";
        ogrenci2.DateOfBirth = new DateTime(2009, 3, 15);

        ogrenci2.Introduce();

        Person ogrenci3 = new Person();
        ogrenci3.Name = "Kader";
        ogrenci3.Surname = "Demir";
        ogrenci3.DateOfBirth = new DateTime(2009, 5, 20);

        ogrenci3.Introduce();


        Person ogretmen1 = new Person();
        ogretmen1.Name = "Tuba";
        ogretmen1.Surname = "Osmanoğlu";
        ogretmen1.DateOfBirth = new DateTime(1993, 4, 12);

        ogretmen1.Introduce();


        Person ogretmen2 = new Person();
        ogretmen2.Name = "Meltem";
        ogretmen2.Surname = "Yılmaz";
        ogretmen2.DateOfBirth = new DateTime(1990, 12, 10);

        ogretmen2.Introduce();


        Person ogretmen3 = new Person();
        ogretmen3.Name = "Karl";
        ogretmen3.Surname = "Johnson";
        ogretmen3.DateOfBirth = new DateTime(1989, 12, 31);

        ogretmen3.Introduce();
    }
}