namespace C1_20._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            int[] digits = new int[4];

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Введіть " + (i + 1) + " число: ");
                digits[i] = Convert.ToInt32(Console.ReadLine());
            }

            int number = digits[0] * 1000 + digits[1] * 100 + digits[2] * 10 + digits[3];

            Console.WriteLine("Число: " + number);


        }
    }
}
