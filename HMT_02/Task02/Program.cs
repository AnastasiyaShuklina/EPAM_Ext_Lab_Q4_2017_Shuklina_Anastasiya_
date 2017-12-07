/* Написать программу, которая запрашивает с клавиатуры число N и 
выводит на экран следующее «изображение», состоящее из N строк: 
*
**
***
**** */ 

namespace Task02
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
                for (int j = n - i; j < n - i; j++)
                {
                    Console.Write("*");//todo pn хардкод
                }

                for (int j = -1; j < n - i; j++)
                {
                    Console.Write("*");//todo pn хардкод
				}

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
