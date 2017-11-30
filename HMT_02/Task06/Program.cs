/* Для выделения текстовой надписи можно использовать выделение жирным, 
курсивом и подчёркиванием.
Предложите способ хранения информации о выделении надписи и напишите программу, 
которая позволяет назначать и удалять текстовой надписи выделение:
Параметры надписи: None
ВВведите:
1: bold
2: italic
3: underline */

namespace Task06
{
    using System;

    internal class Program
    {
        public enum TextSelection
        {
            bold = 1,
            italic = 2,
            underline = 3,
        }

        private static void Main(string[] args) /* не доделана */
        {
            TextSelection selection1 = TextSelection.bold;
            TextSelection selection2 = TextSelection.italic;
            TextSelection selection3 = TextSelection.underline;

            string[] parameters = { "None", "Bold", "Italic", "Underline" };
            string parameter = parameters[0];

            do
            {
                Console.WriteLine("Параметры надписи: " + parameter);
                Console.WriteLine("Введите: ");
                Console.WriteLine("       " + (int)selection1 + ": " + selection1);
                Console.WriteLine("       " + (int)selection2 + ": " + selection2);
                Console.WriteLine("       " + (int)selection3 + ": " + selection3);

                int index = int.Parse(Console.ReadLine());

                switch (index)
                {
                    case 1:
                        parameters[1] = "Bold";
                        break;
                    case 2:
                        parameters[2] = "Italic";
                        break;
                    case 3:
                        parameters[3] = "Underline";
                        break;
                }
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
            Console.ReadLine();
        }
    }
}