/* Написать программу, которая определяет среднюю длину слова 
во введенной текстовой строке. 
Учесть, что символы пунктуации на длину слов влиять не должны. 
Регулярные выражения не использовать. И не пытайтесь прописать все ручками. 
Используйте стандартные методы класса String.  */

namespace Task01
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();

            string[] words = str.Split(new[] { ' ', '!', '?', ',', '.', '-', ':', ';', '"' }, StringSplitOptions.RemoveEmptyEntries);

            int lenght = words.Aggregate(0, (count, nextWord) => count += nextWord.Length) / words.Length;

            foreach (string i in words)
            {
                Console.Write("{0}", i.Length);
            }

            Console.WriteLine("\nСредняя длина строки: {0}", lenght);
            Console.ReadLine();
        }
    }
}
