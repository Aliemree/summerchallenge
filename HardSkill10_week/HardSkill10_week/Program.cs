using System;

namespace DivisorSumCalculator
{
    class Program
    {
        // Fonksiyon: Bir sayının tam bölenlerinin toplamını hesaplar.
        static int CalculateDivisorSum(int number)
        {
            int divisorSum = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    divisorSum += i;
                }
            }

            return divisorSum;
        }

        static void Main(string[] args)
        {
            Console.Write("Bir sayı girin: ");
            int number = int.Parse(Console.ReadLine());

            int sumOfDivisors = CalculateDivisorSum(number);

            Console.WriteLine($"{number} sayısının tam bölenlerinin toplamı: {sumOfDivisors}");
        }
    }
}
