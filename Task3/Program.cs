/*
    Vladimir Raevsky
    Урок 1 задание 3 (а) 
    Расстояние между точками

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Pause(string message = "\nPress any key to exit")
        {
            Console.Write(message);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value for the FIRST point. Enter X:");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\nEnter the value for the SECOND point. Enter X:");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("The distance between two points is: {0:F2}", r);

            Pause();
        }
    }
}
