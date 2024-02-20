namespace C1_20._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            double[] numbers = new double[5];

            // Зчитування чисел з клавіатури
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Введіть число {i + 1}: ");
                string input = Console.ReadLine();
                if (input != null)
                {
                    numbers[i] = double.Parse(input);
                }
                else
                {
                    Console.WriteLine("Введення завершено.");
                    break;
                }
            }

            // Знаходження суми, максимуму, мінімуму і добутку
            double sum = 0;
            double max = numbers[0];
            double min = numbers[0];
            double product = 1;

            foreach (double num in numbers)
            {
                sum += num;
                if (num > max)
                    max = num;
                if (num < min)
                    min = num;
                product *= num;
            }

            // Виведення результатів на екран
            Console.WriteLine($"Сума чисел: {sum}");
            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Мінімум: {min}");
            Console.WriteLine($"Добуток чисел: {product}");

            Console.ReadLine(); // Затримка консолі
        }
    }
}
