/* Написать программу, которая определяет сумму неотрицательных элементов 
в одномерном массиве. Число элементов в массиве и их тип определяются разработчиком. */

namespace Task03
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] array = new int[10];
            Random r = new Random();
            int sum = 0;
            Console.WriteLine("Начальный массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-50, 50);//todo pn хардкод
				Console.Write(array[i] + " ");
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                }
            }

            Console.WriteLine("\n" + "\nСумма неотрицательных элементов массива = " + sum);
            Console.ReadLine();
        }
    }
}
