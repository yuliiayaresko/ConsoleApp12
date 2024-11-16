using System;

namespace NumberInputConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть ціле число: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine($"Ви ввели число {number}");
            }
            else
            {
                Console.WriteLine("Помилка: введене значення не є цілим числом.");
            }
        }
    }
}

