using System.Data.SqlTypes;
using System.Diagnostics.Tracing;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Three_programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            int MenuUI;
            do
            {
                Console.WriteLine("1. Угадай число");
                Console.WriteLine("2. Таблица умножения");
                Console.WriteLine("3. Вывод делителей числа");
                Console.WriteLine("4. Выход из погаммы");
                MenuUI = Convert.ToInt32(Console.ReadLine());
                if (MenuUI == 1)
                {
                    Console.WriteLine("==========================");
                    FindTheNumber();
                    Console.WriteLine("==========================");
                }
                else if (MenuUI == 2)
                {
                    Console.WriteLine("==========================");
                    MultipleTablet();
                    Console.WriteLine("==========================");
                }
                else if (MenuUI == 3)
                {
                    Console.WriteLine("==========================");
                    NumberDivision();
                    Console.WriteLine("==========================");
                }
                Console.WriteLine("Введите любой символ для очистки консоли");
                Console.ReadKey();
                Console.Clear();
            } while (MenuUI != 4);
        }
        static void FindTheNumber()
        {
            Random rnd = new Random();
            Console.WriteLine("Угадай число от 0 до 100");
            int number = rnd.Next(0, 100);
            int YourNumber;
            do
            {
                YourNumber = Convert.ToInt32(Console.ReadLine());
                if (YourNumber < number)
                {
                    Console.WriteLine("Больше");
                }
                else if (YourNumber > number)
                {
                    Console.WriteLine("Меньше");
                }
            } while (YourNumber != number);
            Console.WriteLine($"Да, это было число {YourNumber}");
        }
        static void MultipleTablet()
        {
            int[,] table = new int[9, 9];

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = (i + 1) * (j + 1);
                    Console.Write(table[i, j] + "\t");
                }
                Console.Write("\n");
            }
        }
        static void NumberDivision()
        {
            int YourNumber;
            do
            {
                Console.WriteLine("Введите число");
                Console.WriteLine("Если 0 - выход из прогаммы");
                YourNumber = Convert.ToInt32(Console.ReadLine());
                List<int> divisions = new List<int>();
                for (int i = 1; i < YourNumber + 1; i++)
                {
                    if ((YourNumber % i) == 0)
                    {
                        divisions.Add(i);
                    }
                }
                for (int i = 0; i < divisions.Count; i++)
                {
                    Console.Write(divisions[i] + "\t");
                }
                Console.WriteLine("");
            } while (YourNumber != 0);
        }
    }
}