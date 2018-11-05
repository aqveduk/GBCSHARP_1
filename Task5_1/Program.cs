/*
    Vladimir Raevsky
    Урок 1 задание 5 (б, в)
    Программа выводит на экран имя, фамилию и город проживания.
    Вывод в центре экрана, плюс, методы Pause и Print
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5_1
{
    class Program
    {

        static void Pause(string message = "\nPress any key to exit")
        {
            Console.WriteLine(message);
            Console.ReadKey();
        }

        static void Print(int x, int y, ConsoleColor color)
        {
            Console.Title = "GeekBrains homework";
            Console.BackgroundColor = color;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetWindowSize(x, y);
            Console.SetBufferSize(x, y);
        }

        static void SetPos(int x, int y)
        {
            Console.SetCursorPosition(x / 5, y / 3);
        }

        static void Main(string[] args) {

            int posX = 40;
            int posY = 16;

            Print(posX, posY, ConsoleColor.DarkGreen);

            string name = "Vladimir";

            string surname = "Raevsky";

            string city = "Stupino";

            SetPos(posX, posY);
            Console.WriteLine($"I am living in {city}");

            SetPos(posX, posY+5);
            Console.WriteLine($"My name is {name} {surname}");
            
            Pause(" ");
        }

            

    }
}

