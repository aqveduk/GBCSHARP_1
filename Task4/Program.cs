/*
    Vladimir Raevsky
    Урок 1 задание 4 (а)
    Обмен значений + третья переменная

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
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
            

            Console.WriteLine("Enter the first value:");
            string first = Console.ReadLine();

            Console.WriteLine("Enter the second value:");
            string second = Console.ReadLine();

            Console.WriteLine("Result: ");
            string swap = first;
            first = second;
            Console.WriteLine("Now first value is: " + first);
            second = swap;
            Console.WriteLine("And the second value is: " + second);

            Pause();

        }
    }
}
