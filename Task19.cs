using System;

namespace HomeworkSeminar29062023
{
    /*
     * Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
     * 14212 -> нет
     * 12821 -> да
     * 23432 -> да
     * Для усложенения: модифицировать программу и сделать так, чтобы проверялись не только цифры, но и строчки.
     */
    internal class Task19
    {
        internal static void Palindrome()
        {
            bool isPalindrome(string value)
            {
                for (int i = 0; i < 2; i++)
                {
                    if (char.Equals(value[i], value[4 - i]))
                        continue;
                    return false;
                }
                return true;
            }

            string particleNo = string.Empty;

            Console.Write("Введите пятизначное число (или строку) для вывода палиндрома: ");
            string value = Console.ReadLine();
            if (value.Length != 5)
                throw new Exception($"Длина значения \"{value}\" не равен 5");
            if (!isPalindrome(value))
                particleNo = "не ";
            Console.WriteLine("Значение \"{0}\" {1}является палиндромом", value, particleNo);
            ReadingLeftToRightAndRightToLeft(value);
            
            Program.ReturnToMain();
        }

        private static void ReadingLeftToRightAndRightToLeft(string value)
        {
            var valueRightToLeft = value.ToCharArray();
            Array.Reverse(valueRightToLeft);
            Console.WriteLine("Чтение слева направо: " + value);
            Console.Write("Чтение справа налево: " + new string(valueRightToLeft));
        }
    }
}
