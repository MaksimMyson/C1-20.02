namespace C1_20._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть шестизначне число:");
            string number = Console.ReadLine();

            if (number.Length != 6)
            {
                Console.WriteLine("Ви ввели не шестизначне число");
                return;
            }

            Console.WriteLine("Введіть номер розряда для заміни цифри:");
            string indexes = Console.ReadLine();

            if (indexes.Length == 1 || indexes.Length == 2 || indexes.Length == 3 || indexes.Length == 4 || indexes.Length == 5 || indexes.Length == 6 )
            {
                Console.WriteLine("Введіть цифру для заміни:");
                string digit = Console.ReadLine();

                if (digit.Length == 1)
                {
                    int index = int.Parse(indexes);
                    int numberInt = int.Parse(number);
                    int digitInt = int.Parse(digit);

                    if (index > 0 && index < 7)
                    {
                        int[] digits = new int[6];
                        for (int i = 0; i < 6; i++)
                        {
                            digits[i] = numberInt % 10;
                            numberInt /= 10;
                        }

                        digits[index - 1] = digitInt;

                        int result = 0;
                        for (int i = 5; i >= 0; i--)
                        {
                            result = result * 10 + digits[i];
                        }

                        Console.WriteLine($"Результат: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Ви ввели неправильний номер розряду");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Ви ввели не одну цифру");
                    return;
                }

                return;
            }
        }
    }
}
