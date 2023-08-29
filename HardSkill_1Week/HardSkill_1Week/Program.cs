using System;

namespace YarismaKacSaatteYakalar
{
    class Sıralama
    {
        static void Main(string[] args)
        {
            int ilkYarismaciHizi = 15; // km/saat
            int ikinciYarismaciHizi = 20; // km/saat

            // İki yarışmacının farklı hızlarına göre hesaplamalar yapılıyor
            double hizFarki = ikinciYarismaciHizi - ilkYarismaciHizi;

            // İlk yarışmacının yakalanma zamanı hesaplanıyor
            double yakalamaZamani = 0;
            if (hizFarki > 0)
            {
                yakalamaZamani = 15 / hizFarki; // İkilik noktada saat cinsinden yakalama zamanını hesaplıyoruz
            }

            Console.WriteLine($"İkinci yarışmacı, ilk yarışmacıyı {yakalamaZamani} saat sonra yakalar.");
        }
    }
}
