using System.Globalization;

namespace C1_20._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Введіть дату у форматі dd.MM.yyyy: ");
            string date = Console.ReadLine();

            if (DateTime.TryParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                Console.WriteLine($"День тижня: {parsedDate.ToString("dddd", new CultureInfo("uk-UA"))}");
                Console.WriteLine($"Пора року: {GetSeason(parsedDate.Month)}");
            }
            else
            {
                Console.WriteLine("Неправильний формат дати.");
            }
        }

        static string GetSeason(int month)
        {
            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    return "Зима";
                case 3:
                case 4:
                case 5:
                    return "Весна";
                case 6:
                case 7:
                case 8:
                    return "Літо";
                case 9:
                case 10:
                case 11:
                    return "Осінь";
                default:
                    return "";
            }
        }
    }
}
