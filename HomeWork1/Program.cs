﻿/*
    Vladimir Raevsky
    Урок 1, задание 1 «Анкета», включая пункты а, б, в + try_catch

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Pause(string message = "\nPress any key to exit") {
            Console.Write(message);
            Console.ReadKey();
        }

        static void Print()
        {
            Console.Title = "GeekBrains homework";
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetWindowSize(50, 20);
            Console.SetBufferSize(50, 20);
            Console.OutputEncoding = Encoding.UTF8;
        }

        static void Main(string[] args)
        {
            try
            {
                Print();

                Console.WriteLine("Enter your name: ");
                string name = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter your last name: ");
                string surname = Convert.ToString(Console.ReadLine());

            
                Console.WriteLine("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter your height: ");
                double height = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter your weight: ");
                double weight = Double.Parse(Console.ReadLine());
            
            


                Console.WriteLine("\nYour name is " + name + " " + surname + "\n" + "You are " + age + " years old\n" + "Your height is " + height + " centimeters\n" + "Your weight is " + weight + " kilos");
                Console.WriteLine("\nYour name is {0} {1} \nYou are {2} years old \nYour height is {3} centimeters \nYour weight is {4} kilos", name, surname, age, height, weight);
                Console.WriteLine($"\nYour name is {name} {surname} \nYou are {age} years old \nYour height is {height} centimeters \nYour weight is {weight} kilos");

                Pause();

            } catch (Exception)
            {
                Console.WriteLine("You have entered the wrong value!");
                Pause();
            }
        }
    }
}
