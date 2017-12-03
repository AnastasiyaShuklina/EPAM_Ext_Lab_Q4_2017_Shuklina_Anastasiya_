/* Элемент двумерного массива считается стоящим на чётной позиции, 
если сумма номеров его позиций по обеим размерностям является чётным числом
(например, [1,1] – чётная позиция, а[1, 2] - нет).  
Определить сумму элементов массива, стоящих на чётных позициях. */

namespace Task04
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[,] array = new int[3, 3];
            int sum = 0;
            Random r = new Random();
            Console.WriteLine("Начальный массив: ");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    array[i, j] = r.Next(50);
                    Console.Write(array[i, j] + " ");
                }
            }

            Console.WriteLine("\n" + "\nЭлементы, стоящие на четных позициях: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        Console.Write(array[i, j] + " ");
                        sum += array[i, j];
                    }
                }
            }

            Console.WriteLine("\n" + "\nСумма элементов, стоящих на четных позициях, = " + sum);
            Console.ReadLine();
        }
    }
}
