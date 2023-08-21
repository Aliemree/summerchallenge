using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange1
{
         namespace ArmstrongNumberCheck
    {
        class Program
        {
            // Fonksiyon: Bir sayının Armstrong sayısı olup olmadığını kontrol eder.
            static bool IsArmstrongNumber(int number)
            {
                int originalNumber = number;
                int sum = 0;
                int numberOfDigits = (int)Math.Floor(Math.Log10(number) + 1);

                while (number > 0)
                {
                    int digit = number % 10;
                    sum += (int)Math.Pow(digit, numberOfDigits);
                    number /= 10;
                }

                return sum == originalNumber;
            }

            static void Main(string[] args)
            {
                Console.Write("Bir sayı girin: ");
                int number = int.Parse(Console.ReadLine());

                if (IsArmstrongNumber(number))
                {
                    Console.WriteLine($"{number} bir Armstrong sayısıdır.");
                }
                else
                {
                    Console.WriteLine($"{number} bir Armstrong sayısı değildir.");
                }
            }
        }
    }
}
