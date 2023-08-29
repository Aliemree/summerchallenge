using System;

namespace Skiil3

{
    class Hesaplama
    {
        // Faktoriyel hesaplama fonksiyonu
        static int Faktoriyel(int n)
        {
            if (n <= 1)
                return 1;
            return n * Faktoriyel(n - 1);
        }

        // Kombinasyon hesaplama fonksiyonu
        static int Kombinasyon(int n, int r)
        {
            return Faktoriyel(n) / (Faktoriyel(r) * Faktoriyel(n - r));
        }

        static void Main(string[] args)
        {
            int n = 30; // Toplam öğrenci sayısı
            int r = 4;  // Seçilecek öğrenci sayısı

            int farkliSekiller = Kombinasyon(n, r);
            Console.WriteLine($"{n} öğrenci arasından {r} farklı kişi seçme şekilleri: {farkliSekiller}");
        }
    }
}
