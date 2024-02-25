using System;

namespace C1_20._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Перше ціле число:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Друге ціле число:");
            int B = Convert.ToInt32(Console.ReadLine());

            while (A >= B) 
            {
                Console.WriteLine("Перше число повинно бути менше за друге");
                Console.WriteLine("Перше ціле число:");
                A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Друге ціле число:");
                B = Convert.ToInt32(Console.ReadLine());
            }

            PrintNumbersWithRepeats(A, B); 
        }

        static void PrintNumbersWithRepeats(int A, int B)
        {
            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
