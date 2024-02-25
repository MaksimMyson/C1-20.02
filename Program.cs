namespace C1_20._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть температуру:");
            double temp = Convert.ToDouble(Console.ReadLine());

          Console.WriteLine("Введіть шкалу (C, F, K):");
            string scale = Console.ReadLine();

            switch (scale)
            {
                case "C":
                    Console.WriteLine("Температура в Фаренгейтах: " + (temp * 9 / 5 + 32));
                    Console.WriteLine("Температура в Кельвінах: " + (temp + 273.15));
                    break;
                case "F":
                    Console.WriteLine("Температура в Цельсіях: " + ((temp - 32) * 5 / 9));
                    Console.WriteLine("Температура в Кельвінах: " + ((temp - 32) * 5 / 9 + 273.15));
                    break;
                case "K":
                    Console.WriteLine("Температура в Цельсіях: " + (temp - 273.15));
                    Console.WriteLine("Температура в Фаренгейтах: " + ((temp - 273.15) * 9 / 5 + 32));
                    break;
                default:
                    Console.WriteLine("Невірна шкала");
                    break;
            }
            
        }
    }
}
