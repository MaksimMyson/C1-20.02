using System;

namespace C1_20._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.Write("Введіть шестизначне число:");
            string input = Console.ReadLine();

            if (input.Length != 6 || !IsNumeric(input))
            {
                Console.WriteLine("Ви ввели не шестизначне число.");
                return;
            }

            string reversedNumber = ReverseNumber(input);
            Console.WriteLine($"Число навпаки: {reversedNumber}");
        }

        private static string ReverseNumber(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        static bool IsNumeric(string str)
        {
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                    return false;
            }
            return true;
        }
    }
}
