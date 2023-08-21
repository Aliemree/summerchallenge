using System;

namespace DuplicationCheck
{
    class Program
    {
        // Fonksiyon: Verilen metinde ikileme olup olmadığını kontrol eder.
        static bool CheckForDuplication(string text)
        {
            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length - 1; i++)
            {
                if (i + 1 < words.Length && words[i] == words[i + 1])
                {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            Console.Write("Bir cümle girin: ");
            string sentence = Console.ReadLine();

            if (CheckForDuplication(sentence))
            {
                Console.WriteLine("Cümlede ikileme bulundu.");
            }
            else
            {
                Console.WriteLine("Cümlede ikileme bulunamadı.");
            }
        }
    }
}
