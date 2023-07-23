using System;

namespace YasHesaplama
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
}