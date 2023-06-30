using System;

namespace HomeworkSeminar29062023
{
    /*
     * Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
     * 3 -> 1, 8, 27
     * 5 -> 1, 8, 27, 64, 125
     */
    internal class Task23
    {
        internal static void TableCubanNumbers()
        {
            Console.Write("Введите целое положительное число N для вывода таблицы кубов чисел от 1 до N: ");
            if (!Int32.TryParse(Console.ReadLine(), out var number))
                throw new Exception("Введено не целое число");
            if (number < 1)
                throw new Exception("Введено отрицательное число или 0");
            Console.WriteLine("Таблица кубов чисел от 1 до " +  number);
            for (int i = 1; i <= number; i++)
            {
                Console.Write(Math.Pow(i, 3));
                if (i < number)
                    Console.Write(", ");
            }

            Program.ReturnToMain();
        }
    }
}
