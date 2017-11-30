/* Написать программу, которая запрашивает с клавиатуры число N 
и выводит на экран следующее «изображение», состоящее из N треугольников:  
     *
     *
    ***
     *
    ***
   ***** */

namespace Task04
{
    using System;

    internal class Program
    {
        private static void Main(string[] args) /* не доделана */
        {
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int n1 = i + 1;
                for (int j = 0; j < n1; j++)
                {
                    int n2 = j + 1;
                    for (int q = 0; q < n2; q++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
} 
