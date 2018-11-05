/*
    Vladimir Raevsky
    Урок 1 задание 5 (а)
    Программа выводит на экран имя, фамилию и город проживания.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
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

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            string surname = Console.ReadLine();

            Console.WriteLine("Enter your city: ");
            string city = Console.ReadLine();

            Console.WriteLine($"You are living in {city}. Your name is {name} {surname}");

            Pause();


        }
    }
}
