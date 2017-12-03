/* Написать программу, которая заменяет все положительные элементы 
в трёхмерном массиве на нули. Число элементов в массиве 
и их тип определяются разработчиком. */

namespace Task02
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,,] array = new int[3, 3, 3];
            Random r = new Random();
            Console.WriteLine("Начальный массив: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        array[i, j, k] = r.Next(-50, 50);
                        Console.Write(array[i, j, k] + " ");
                    }
                }
            }

            Console.WriteLine("\n" + "\nМассив с заменой положительных чисел нулями:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (array[i, j, k] < 0)
                        {
                            array[i, j, k] = 0;
                        }

                        Console.Write(array[i, j, k] + " ");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
