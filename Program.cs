using System;

namespace HomeworkSeminar29062023
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                Console.WriteLine("Задача №19:");
                Task19.Palindrome();
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
    }
}