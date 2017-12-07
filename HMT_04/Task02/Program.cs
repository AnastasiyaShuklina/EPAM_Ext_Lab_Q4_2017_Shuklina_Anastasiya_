/* Написать программу, которая удваивает в первой введенной строки все символы, 
принадлежащие второй введенной строке. 
Пример:   
Введите первую строку: написать программу, которая   
Введите вторую строку: описание   
Результирующая строка: ннааппииссаать ппроограамму, коотоораая */

namespace Task02
{
    using System;
    using System.Linq;
    using System.Text;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите первую строку: ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Введите вторую строку: ");
            string str2 = Console.ReadLine();

            StringBuilder finalStr = new StringBuilder();

            foreach (char symbol in str1)
            {
                if (!str2.Contains(symbol))
                {
                    finalStr.Append(symbol);
                }
                else
                {
                    finalStr.Append(symbol, 2); 
                }
            }

            Console.WriteLine("\nРезультирующая строка: {0}", finalStr);
            Console.ReadLine();
        }
    }
}