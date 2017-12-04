/*Написать программу, которая определяет площадь прямоугольника 
со сторонами a и b.Если пользователь вводит некорректные значения 
(отрицательные, или 0), должно выдаваться сообщение об ошибке.
Возможность ввода пользователем строки вида «абвгд», или нецелых 
чисел игнорировать.*/

namespace Task01
{
    using System;

    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Enter a : ");
            double a = double.Parse(Console.ReadLine());//todo pn возможна исключительная ситуация
			while (a <= 0)
            {
                Console.WriteLine("Error! Try again: ");
                a = double.Parse(Console.ReadLine());//todo pn возможна исключительная ситуация
			}

            Console.Write("Enter b: ");
            double b = double.Parse(Console.ReadLine());//todo pn возможна исключительная ситуация
			while (b <= 0)
            {
                Console.WriteLine("Error! Try again: ");
                b = double.Parse(Console.ReadLine());//todo pn возможна исключительная ситуация
			}

            AreaOfRectangle area = new AreaOfRectangle();
            area.FindAreaOfRectangle(a, b);
        }
    }
}
