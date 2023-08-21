using System;

namespace PoolFillingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            // İlk su girişi hızı: 1/10 (havuz/saat)
            // İkinci su girişi hızı: 1/15 (havuz/saat)
            // Havuzun boşalma hızı: -1/30 (havuz/saat)

            // İki su girişi aynı anda açıldığında toplam su girişi hızı:
            double totalInputRate = 1.0 / 10 + 1.0 / 15;

            // Havuzun dolma süresi hesaplanıyor (1 saat / toplam giriş hızı):
            double fillingTime = 1.0 / totalInputRate;

            Console.WriteLine($"Havuzun dolma süresi: {fillingTime:F2} saat");
        }
    }
}
