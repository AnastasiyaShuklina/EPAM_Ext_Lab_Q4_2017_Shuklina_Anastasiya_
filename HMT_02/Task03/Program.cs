/* Написать программу, которая запрашивает с клавиатуры число N 
и выводит на экран следующее «изображение», состоящее из N строк: 
    *
   ***
  ***** */ 

namespace Task03
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i > 0; i--)
            {
                for (int j = n - i; j < n; j++)
                {
                    Console.Write(" ");
                }

                for (int j = -1; j < n - i; j++)
                {
                    Console.Write("*");
                }

                for (int j = 0; j < n - i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
