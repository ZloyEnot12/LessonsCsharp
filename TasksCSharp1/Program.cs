using System;

namespace TasksCSharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int year = 365;
            const int month = 30;

            // Вводим количество дней
            Console.WriteLine("Write days: ");
            int Day = int.Parse(Console.ReadLine());

            // Вычислим и выведем количество лет, сохранив остаток
            Console.WriteLine("Лет: " + Day / year);
            Day = Day % year;

            Console.WriteLine("Месяцев: " + Day / month);
            Day = Day % month;

            Console.WriteLine("Дней: " + Day);

            Console.ReadKey();
        }
    }
}
