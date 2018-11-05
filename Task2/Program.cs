/*
    Vladimir Raevsky
    Урок 1, задание 2 «ИМТ» + try_catch и throw new exception
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
            try
            {

                Console.WriteLine("Enter your height: ");
                double height = Double.Parse(Console.ReadLine());

                if (height == 0)
                    throw new DivideByZeroException();  //Выбрасывает ошибку в catch, если height == 0

                Console.WriteLine("Enter your weight: ");
                double weight = Double.Parse(Console.ReadLine());
                double I = weight / (height * height);
                Console.WriteLine($"Your BMI is: {I:F5}");

                Pause();

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divided by zero!");
                Pause();
            }
            catch (Exception)
            {
                Console.WriteLine("You have entered the wrong value!");
                Pause();
            }


        }
    }
}
