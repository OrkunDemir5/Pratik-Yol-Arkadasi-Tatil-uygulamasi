bool devam;
do
{
    //Lokasyon Seçimi
    Console.WriteLine("Merhaba, gitmek istediğiniz yeri seçin");

    string secim = "";
    int toplamTutar = 0;
    bool lokasyonSecim = false;
    do
    {
        Console.WriteLine("1 - Bodrum (Paket başlangıç fiyatı 4000 TL)\n" +
        "2 - Marmaris (Paket başlangıç fiyatı 3000 TL)\n3 - Çeşme (Paket başlangıç fiyatı 5000 TL)");
        secim = Console.ReadLine().ToLower();
        switch (secim)
        {
            case "bodrum":
                toplamTutar += 4000;
                lokasyonSecim = true;
                Console.WriteLine("1. Bodrum Kalesi\n2. Bodrum Çarşısı\n3. Bodrum Antik Tiyatrosu");
                break;
            case "marmaris":
                toplamTutar += 3000;
                lokasyonSecim = true;
                Console.WriteLine("1. Marmaris Kalesi ve Müzesi\n2. Turgut Şelalesi\n3. Dalaman Çayı");
                break;
            case "çeşme":
                toplamTutar += 5000;
                lokasyonSecim = true;
                Console.WriteLine("1. Alaçatı\n2. Çeşme Marina\n3. Delikli Koy");
                break;
            default:
                Console.WriteLine("Hatalı giriş! Lütfen geçerli bir lokasyon girin: Bodrum, Marmaris, Çeşme.");
                break;
        }
    } while (!lokasyonSecim);
    //Kişi sayısı
    Console.WriteLine("Kaç kişi olacaksınız ?");
    int kisiSayi = int.Parse(Console.ReadLine());

    // Ulaşım seçimi
    bool ulasimSecildi = false;
    do
    {
        Console.WriteLine("1 - Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )\n" +
        "2 - Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)\n" +
        "Lütfen yukarıdaki seçeneklerden bir tanesini seçiniz");

        string ulasimSecim = Console.ReadLine();
        if (ulasimSecim == "1")
        {
            toplamTutar += 1500;
            ulasimSecildi = true;
        }
        else if (ulasimSecim == "2")
        {
            toplamTutar += 4000;
            ulasimSecildi = true;
        }
        else
        {
            Console.WriteLine("Hatalı girdiniz! Tekrar deneyin");
        }

    } while (!ulasimSecildi);

    Console.WriteLine($"toplam fiyat: {toplamTutar * kisiSayi}");

    //Başka bir tatil planı ?
    Console.WriteLine("Başka bir tatil planı nister misin ? (Evet/Hayır)");
    string cevap = Console.ReadLine().ToLower();

    devam = (cevap == "evet");
}while (devam);

Console.WriteLine("İyi günler dileriz!");


