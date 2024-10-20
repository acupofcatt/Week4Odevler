namespace IlkSinif;

public class Person //Person classı tanımlama
{
    private string name;
    private string surname;
    private DateTime dateOfBirth;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }   //İsim propertysini oluşturduk

    public string Surname
    {
        get
        {
            return surname;
        }
        set
        {
            surname = value;
        }
    }   //Soyad propertysini oluşturduk

    public DateTime DateOfBirth
    {
        get
        {
            return dateOfBirth;
        }
        set
        {
            dateOfBirth = value;
        }
    }   //Doğum Tarihi propertysini oluşturduk

    public void Introduce() //Tanıtma fonksiyonu
    {
        Console.WriteLine($"İsim: {name} Soyisim: {surname} Doğum Tarihi: {dateOfBirth} ");
    }
}