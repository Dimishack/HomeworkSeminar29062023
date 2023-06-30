using System;

namespace HomeworkSeminar29062023
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Добро пожаловать в программу \"Домашнее задание с семинара 29.06.2023 года\"");
                do
                {
                    Console.WriteLine("1) Задача 19 (с усложнением): напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом." +
                                            " Также нужно модифицировать программу и сделать так, чтобы проверялись не только цифры, но и строчки." +
                                            "\n2) Задача 21: напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве." +
                                            "\n3) Задача 23: напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");
                    Console.Write("\nНажмите на определенную цифру для выполнение задания или любую другую клавишу для выхода из программы: ");
                    ConsoleKey key = Console.ReadKey().Key;
                    Console.WriteLine('\n' + new string('-', 30));
                    if (key == ConsoleKey.D1 || key == ConsoleKey.NumPad1)
                        Task19.Palindrome();
                    else if (key == ConsoleKey.D2 || key == ConsoleKey.NumPad2)
                        Task21.DistanceTwoPoints();
                    else if (key == ConsoleKey.D3 || key == ConsoleKey.NumPad3)
                        Task23.TableCubanNumbers();
                    else break;
                    Console.Clear();
                } while (true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("\nНажмите на любую клавишу для выхода из программы...");
                Console.ReadKey(true);
            }
        }

        internal static void ReturnToMain()
        {
            Console.Write("\nНажмите на любую клавишу, чтобы вернуться в меню...");
            Console.ReadKey(true);
        }
    }
}