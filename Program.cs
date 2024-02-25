namespace C1_20._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть число:");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Введіть відсоток:");
            int percent = int.Parse(Console.ReadLine());

           if (number > 0 && percent > 0)
            {
                Console.WriteLine($"Відсоток від числа {number} = {number * percent / 100}");
            }
            else
            {
                Console.WriteLine("Введіть додатні числа");
            }
            Console.WriteLine();
        }

        

    }
}
