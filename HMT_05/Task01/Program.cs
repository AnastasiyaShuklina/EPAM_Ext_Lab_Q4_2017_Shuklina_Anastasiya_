/*Написать класс Round, задающий круг с указанными координатами центра, радиусом, 
а также свойствами, позволяющими узнать длину описанной окружности и площадь круга. 
Обеспечить нахождение объекта в заведомо корректном состоянии. 
Написать программу, демонстрирующую использование данного круга. */
 
namespace Task01
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите радиус окружности");
            var round = new Round();
            round.r = Convert.ToInt32(Console.ReadLine());

            while (round.r <= 0)
            {
                Console.WriteLine("Ошибка! Попробуйте снова: ");
                round.r = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Введите координату Х центра круга");
            round.x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату У центра круга");
            round.y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Длина окружности = {0:0.000}", round.GetLenght);
            Console.WriteLine("Площадь круга = {0:0.000}", round.GetArea);

            Console.ReadLine();
        }
    }

    internal class Circle
    {
        internal int x, y, r;

        internal double GetLenght
        {
            get
            {
                int r1 = this.r;
                return 2 * Math.PI * r1;
            }
        }
    }

    internal class Round : Circle
    {
        internal double GetArea
        {
            get
            {
                int r1 = r;
                return Math.PI * Math.Pow(r1, 2);
            }
        }
    }
}
