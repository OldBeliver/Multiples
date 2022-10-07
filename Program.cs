using System;

namespace Multiples
{
    class Program
    {
        static void Main(string[] args)
        {
            int minRandomValue = 1;
            int maxRandomValue = 27;
            int randomValue;
            int minNumber = 100;
            int maxNumber = 999;
            int countNumber = 0;

            Random random = new Random();
            randomValue = random.Next(minRandomValue, maxRandomValue + 1);
            
            Console.WriteLine($"Ряд 3х значных чисел, кратных {randomValue}:");

            for (int i = 0; i <= maxNumber; i+=randomValue)
            {
                if (i >= minNumber)
                {
                    Console.Write($"{i} ");
                    countNumber++;
                }
            }

            Console.WriteLine($"\nКоличество 3х значных чисел {countNumber}");
        }
    }
}
