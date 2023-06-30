using System;

namespace HomeworkSeminar29062023
{
    internal class Program
    {
        static void Main()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Нажмите на любую клавишу для выхода из программы...");
                Console.ReadKey(true);
            }
        }
    }
}