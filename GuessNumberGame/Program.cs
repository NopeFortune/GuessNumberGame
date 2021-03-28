using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int WinNumber = rnd.Next(0, 100);

            int number;
            bool flag = false;

            Console.WriteLine("Вам надо будет угадать число от 0 до 100.");

            do
            {
                Console.Write("Введите число: ");

                while (!int.TryParse(Console.ReadLine(), out number)) // Проверка на является ли числом.
                {
                    Console.Clear();
                    Console.Write("Введите число: ");
                }

                if (WinNumber > number)
                {
                    Console.Clear();
                    Console.WriteLine("Попробуйте число больше");
                }

                else if (WinNumber < number)
                {
                    Console.Clear();
                    Console.WriteLine("Попробуйте число меньше.");
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("Победа");
                    flag = true;
                }

            } while (flag == false);

            Console.ReadLine();
        }
    }
}
