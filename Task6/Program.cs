/*
    Vladimir Raevsky
    Урок 1 задание 6
    Использование собственных методов
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
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
            Console.SetCursorPosition(x / 3, y / 2);
        }

        static void Main(string[] args)
        {

            int posX = 40;
            int posY = 16;

            Print(posX, posY, ConsoleColor.DarkMagenta);
            SetPos(posX, posY);
            Console.WriteLine("TEST TEST TEST");
            Pause(" ");
        }
    }
}
