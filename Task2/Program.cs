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
            Console.WriteLine(message);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter your weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());
            double I = weight / (height * height);
            Console.WriteLine($"Your BMI is: {I:F5}");

            Pause();



        }
    }
}
