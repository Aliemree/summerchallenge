using System;

namespace CountOccurrencesInSortedArray
{
    class Program
    {
        // Fonksiyon: Sıralı bir dizide hedef sayının kaç kez tekrar ettiğini bulur.
        static int CountOccurrences(int[] sortedArray, int target)
        {
            int count = 0;
            foreach (int num in sortedArray)
            {
                if (num == target)
                {
                    count++;
                }
                // Çünkü dizi sıralı olduğu varsayıldı, hedef sayıyı geçerse döngüden çıkabiliriz.
                if (num > target)
                {
                    break;
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            int[] sortedArray = { 2, 3, 3, 5, 5, 5, 7, 8, 8, 8, 8, 10 };

            Console.Write("Hedef sayıyı girin: ");
            int target = int.Parse(Console.ReadLine());

            int occurrences = CountOccurrences(sortedArray, target);

            Console.WriteLine($"{target} sayısı dizide {occurrences} kez tekrar ediyor.");
        }
    }
}
