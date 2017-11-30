namespace Task01
{
    using System;

    internal class AreaOfRectangle
    {
        /*<summary>
        Метод FindAreaOfRectangle предназначен для расчета площади прямоугольника.
        Входные данные - стороны а и b прямоугольника,
        выходной параметр - вычесленная площадь прямоугольника.
        </summary>*/
        public void FindAreaOfRectangle(double a, double b)
        {
            var s = a * b;
            Console.WriteLine("Area of a rectangle = " + s);
            Console.ReadKey();
        }
    }
}
