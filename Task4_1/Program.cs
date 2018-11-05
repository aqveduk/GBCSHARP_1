/*
    Vladimir Raevsky
    Урок 1 задание 4 (б)
    Обмен значений без третьей переменной

 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4_1
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
            Console.WriteLine("Enter the first value:");
            int first = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Enter the second value:");
            int second = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("\nWe need to add \'second\' variable to the first one");
            first += second;
            Console.WriteLine("Now first is equal to: " + first);
            Console.WriteLine("Than we need to substract the \'second\' variable from the \'first\' one and assign the result to the \'second\' as well");

            second = first - second;

            Console.WriteLine("\nResult:  \'second\' is equal to : " + second);

            first -= second;

            Console.WriteLine("And \'first\' is equal to : " + first);


            Pause();


        }
    }
}
