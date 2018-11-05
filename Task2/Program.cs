/*
    Vladimir Raevsky
    Урок 1, задание 2 «ИМТ»
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
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
            Console.WriteLine("Enter your height: ");
            double height = Double.Parse(Console.ReadLine());

            Console.WriteLine("Enter your weight: ");
            double weight = Double.Parse(Console.ReadLine());
            double I = weight / (height * height);
            Console.WriteLine($"Your BMI is: {I:F5}");

            Pause();



        }
    }
}
