using System;

namespace SummerChallange
    
{
    class YasHesaplama
{
    static void Main(string[] args)
    {
        Console.WriteLine("Doğum tarihinizi (yyyy-aa-gg formatında) giriniz:");
        string dogumTarihiStr = Console.ReadLine();

        // Doğum tarihini 'yyyy-aa-gg' formatından DateTime nesnesine dönüştür
        DateTime dogumTarihi = DateTime.ParseExact(dogumTarihiStr, "yyyy-MM-dd", null);

        // Şu anki tarihi al
        DateTime suAn = DateTime.Now;

        // Yaşı hesapla
        int yas = suAn.Year - dogumTarihi.Year;

        // Doğum günü henüz gelmemişse bir yaş düşür
        if (suAn.Month < dogumTarihi.Month || (suAn.Month == dogumTarihi.Month && suAn.Day < dogumTarihi.Day))
        {
            yas--;
        }

        Console.WriteLine("Yaşınız: " + yas);
        }
    }


    class CostAndPrice
    {

        static void Main(string[] args)
        {
            // Birim maliyet ve birim satış fiyatı değişkenlerini tanımla
            double cost = 100;
            double price = 150;

            // Birim maliyetin birim satış fiyatından düşük olduğunu kontrol et
            if (cost >= price)
            {
                Console.WriteLine("Hata: Birim maliyet birim satış fiyatından düşük olmalıdır!");
            }
            else
            {
                // Kâr edilmeye başlamak için gereken adet sayısını hesapla
                int adet = (int)Math.Ceiling(cost / (price - cost));

                Console.WriteLine($"Birim Maliyet: {cost} TL");
                Console.WriteLine($"Birim Satış Fiyatı: {price} TL");
                Console.WriteLine($"Kâr Edilmeye Başlanacak Adet: {adet}");
            }
        }
    }
}
