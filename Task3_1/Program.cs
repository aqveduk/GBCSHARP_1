/*
    Vladimir Raevsky
    Урок 1 задание 3 (б)
    Расстояние между точками в виде метода
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1
{
    class Program
    {

        static void Pause(string message = "Press any key to exit")
        {
            Console.Write(message);
            Console.ReadKey();
        }

        static double Result(double x1, double x2, double y1, double y2) => Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for the FIRST point. Enter X:");
            double x1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            double y1 = Double.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter the value for the SECOND point. Enter X:");
            double x2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            double y2 = Double.Parse(Console.ReadLine());
            double r = Result(x1, x2, y1, y2);
            Console.WriteLine("The distance between two points is: {0:F2}", r);

            Pause();
        }
    }
}
