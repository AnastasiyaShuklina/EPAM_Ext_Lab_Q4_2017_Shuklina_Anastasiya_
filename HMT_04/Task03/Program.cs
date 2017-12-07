/* Проведите сравнительный анализ скорости работы классов 
String и StringBuilder для операции сложения строк: 
string str = ""; 
StringBuilder sb = new StringBuilder(); 
int N = 100;   
for (int i = 0; i<N; i++)   
{   
    str += "*";   
}   
for (int i = 0; i<N; i++)   
{   
    sb.Append("*");   
}   */

namespace Task03
{
    using System;
    using System.Diagnostics;
    using System.Text;

    internal class Program
    {
        private static void Main(string[] args)
        {
            string str = string.Empty;

            for (int n = 10000; n < 250001; n *= 5)
            {
                Console.WriteLine("При N = {0} ", n);

                Stopwatch stopWatch1 = new Stopwatch();
                stopWatch1.Start();
                for (int i = 0; i < n; i++)
                {
                    str += "*";
                }

                stopWatch1.Stop();

                TimeSpan ts1 = stopWatch1.Elapsed;
                string elapsedTime1 = string.Format(
                    "{0:00}:{1:00}.{2:00}",
                    ts1.Minutes,
                    ts1.Seconds,
                    ts1.Milliseconds / 10);
                Console.WriteLine("\nЗатраченное время String {0} ", elapsedTime1);

                StringBuilder sb = new StringBuilder();
                Stopwatch stopWatch2 = new Stopwatch();
                stopWatch2.Start();
                for (int i = 0; i < n; i++)
                {
                    sb.Append("*");
                }

                stopWatch2.Stop();

                TimeSpan ts2 = stopWatch2.Elapsed;
                string elapsedTime2 = string.Format(
                    "{0:00}:{1:00}.{2:00}",
                    ts2.Minutes,
                    ts2.Seconds,
                    ts2.Milliseconds / 10);
                Console.WriteLine("Затраченное время StringBuilder {0} ", elapsedTime2);

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}