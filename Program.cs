
namespace C1_20._02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть початок діапазону:");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть кінець діапазону:");
            int end = int.Parse(Console.ReadLine());

            if (start < 0 || end < 0 || start > end)
            {
                Console.WriteLine("Введені некоректні дані");
            }

            Console.WriteLine($"Числа Фібоначчі в діапазоні від {start} до {end}:");
            DisplayFibonacciNumbersInRange(start, end);
        }

        static void DisplayFibonacciNumbersInRange(int start, int end)
        {
            int a = 0;
            int b = 1;
            

            while (a <= end)
            {
                if (a >= start)
                {
                    Console.WriteLine($"{a}, ");
                }

                int temp = a + b;
                a = b;
                b = temp;
            }

            
        }   
















        
    }
}
