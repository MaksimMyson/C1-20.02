using System;

namespace C1_20._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть число від 1 до 100:");
            int number = int.Parse(Console.ReadLine());

            if (number < 1 || number > 100)
            {
                Console.WriteLine("Введене число не відповідає вимогам");
                return;
            }

            if (number % 5 == 0 && number % 3 == 0) 
            {
                Console.WriteLine("Fizz\r\nBuzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Fizz");
            }
        }
    }
}
