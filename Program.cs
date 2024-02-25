using System;

namespace C1_20._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            Console.WriteLine("Введіть довжину лінії:");
            int length = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть символ заповнювач:");
            char fillSymbol = Console.ReadLine()[0];

            Console.WriteLine("Виберіть напрямок лінії (г - горизонтальна, в - вертикальна):");
            char direction = Console.ReadLine()[0];

            if (direction == 'г')
            {
                DrawHorizontalLine(length, fillSymbol);
            }
            else if (direction == 'в')
            {
                DrawVerticalLine(length, fillSymbol);
            }
            else
            {
                Console.WriteLine("Невідомий напрямок лінії.");
            }
        }

        static void DrawHorizontalLine(int length, char fillSymbol)
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write(fillSymbol);
            }
            Console.WriteLine();
        }

        static void DrawVerticalLine(int length, char fillSymbol)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(fillSymbol);
            }
        }
    }
}
