namespace C1_20._02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть перше число:");
            int number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть друге число:");
            int number2 = int.Parse(Console.ReadLine());

            // Нормалізація меж діапазону
            int start = Math.Min(number1, number2);
            int end = Math.Max(number1, number2);

            Console.WriteLine($"Парні числа у діапазоні від {start} до {end}:");
            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
