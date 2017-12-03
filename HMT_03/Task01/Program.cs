/* Написать программу, которая генерирует случайным образом элементы массива 
(число элементов в массиве и их тип определяются разработчиком), 
определяет для него максимальное и минимальное значения, 
сортирует массив и выводит полученный результат на экран. 
Примечание: LINQ запросы и готовые функции языка (Sort, Max и т.д.) 
использовать в данном задании запрещается. */

namespace Task01
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] array = new int[10];
            Random r = new Random();
            Console.WriteLine("Начальный массив: ");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(100);
                Console.Write(array[i] + " ");
            }

            int max = 0;
            int min = 11;

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] > max)
                {
                    max = array[j];
                }

                if (array[j] < min)
                {
                    min = array[j];
                }
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int k = array[i];
                        array[i] = array[j];
                        array[j] = k;
                    }
                }
            }

            Console.WriteLine("\n" + "\nМаксимальный элемент массива = " + max);
            Console.WriteLine("\nМинимальный элемент массива = " + min);
            Console.WriteLine("\nОтсортированный массив: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }

            Console.ReadLine();
        }
    }
}
