//1- Konsol ekranından kullanıcıya telefon üretmek için 1 bilgisayar üretmek için 2'ye basması gerektiğini söyleyiniz.
// 
// 2- Kullanıcının seçimine göre ilgili classtan nesne üreterek özelliklerini konsol ekranından yani kullanıcıdan alınız.
// 
// 3- Bütün bilgiler girildiğinde ürünün başarıyla üretildiğini bir mesaj ile bildirip başka bir ürün üretmek isteyip istemediğini sorunuz.
// 
// 4- Kullanıcı evet cevabını verirse 1. aşamaya geri dönünüz, hayır cevabını verirse iyi günler dileyerek uygulamayı sonlandırınız.


using Kapanis;

class Program
{
    //ana metotta sadece kullanıcının 
    public static void Main(string[] args)
    {
        bool devam;
        do
        {
            devam = false;
            Uretim();

            Console.WriteLine("Başka bir ürün üretmek ister misiniz? Evet veya hayır yazınız.");
            string? input = Console.ReadLine()?.ToLower();

            if (input == "evet")
            {
               devam = true; 
            }
            else
            {
                Console.WriteLine("Uygulama sonlanıyor, iyi günler.");
            }
 
        } while (devam);
        
    }

    //Kullanıcının seçim değerini kontrol ederek doğru seçim yapmadığı sürece tekrar girdi almak için Uretim metodu
    //oluşturup üretim seçimini burada yaptırdım.
    public static void Uretim()
    {
        int secim;
       
        do
        {
            Console.WriteLine("Telefon üretmek için 1, Bilgisayar üretmek için 2 seçiniz.");
            string? secimStr = Console.ReadLine();

            if (int.TryParse(secimStr, out secim))
            {
                //Kullanıcı 1 girdiğinde Base Class üzerinden tanımladığım KullaniciGirisi metodunu çağırıp ayrıca
                //telefonun ekstra özelliği olan lisans durumunu aldım ve bu bilgileri kullanarak üretim yaptım.

                if (secim == 1)
                {
                    Telefon telefon = new Telefon();
                    KullaniciGirisi(telefon);

                    Console.WriteLine("Telefonun lisansı varsa 'evet' giriniz.");
                    string? lisans = Console.ReadLine()?.ToLower();

                    if (lisans == "evet")
                    {
                        telefon.TrLisansVar = true;
                    }
                    else
                    {
                        telefon.TrLisansVar = false;
                    }

                    telefon.BilgileriYazdir();
                    Console.WriteLine("Telefon başarıyla üretildi.");
                }
                //Kullanıcı 2 girdiğinde Base Class üzerinden tanımladığım KullaniciGirisi metodunu çağırıp ayrıca
                //bilgisayarın ekstra özellikleri olan bluetooth ve usb port sayısını aldım,
                //bu bilgileri kullanarak üretim yaptım ve ekrana yazdırdım.

                if (secim == 2)
                {
                    Bilgisayar bilgisayar = new Bilgisayar();
                    KullaniciGirisi(bilgisayar);

                    Console.WriteLine("Bilgisayarın bluetooth özelliği varsa 'evet' giriniz.");
                    string? bluetooth = Console.ReadLine()?.ToLower();

                    if (bluetooth == "evet")
                    {
                        bilgisayar.BluetoothVar = true;
                    }
                    else
                    {
                        bilgisayar.BluetoothVar = false;
                    }

                    Console.WriteLine("Bilgisayarın USB Port sayısını giriniz.");
                    string? usb = Console.ReadLine();

                    if (int.TryParse(usb, out int portSayisi))
                    {
                        bilgisayar.UsbPort = portSayisi;
                    }

                    bilgisayar.BilgileriYazdir();
                    Console.WriteLine("Bilgisayar başarıyla üretildi.");
                }
            }
            
            //seçim 1 veya 2 olmadığı takdirde uyarı verdim.
            else
            {
                Console.WriteLine("Geçersiz Giriş.");
            }

            //seçim 1 veya 2 olmadığı sürece de döngüyü devam ettirdim.  
        }while (!(secim == 1 || secim == 2)) ;
    }


//kullanıcı girişi metoduyla BaseMakine classından üretilmiş herhangi bir classı ürün parametresi olarak alıyoruz.
//Kullanıcı telefon seçerse ürünümüz telefon türünde olacak, bilgisayar seçerse bilgisayar türünde
//ve Base classta tanımlanan ortak özelllikler üzerinden işlem yapılacak.
        public static void KullaniciGirisi(BaseMakine urun)
        {
            Console.WriteLine("Lütfen ürün için Ad giriniz.");
            string? ad = Console.ReadLine();

            //sadece veri girişi olduğunda atama yapıp boş karakter için ramde yer tutmasını istemedim
            //tekrar giriş yaptırmadığım için uyarı da vermedim.

            if (!string.IsNullOrWhiteSpace(ad))
            {
                urun.Ad = ad;
            }

            Console.WriteLine("Lütfen ürün için Seri No giriniz.");
            string? seriNo = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(seriNo))
            {
                urun.SeriNo = seriNo;
            }

            Console.WriteLine("Lütfen ürün için Aciklama giriniz.");
            string? aciklama = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(aciklama))
            {
                urun.Aciklama = aciklama;
            }

            Console.WriteLine("Lütfen ürün için İşletim Sistemi giriniz.");
            string? isletimSistemi = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(isletimSistemi))
            {
                urun.IsletimSistemi = isletimSistemi;
            }
        }
    }