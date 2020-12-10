using System;
using System.Text.Json;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ведите количество дней, которое вы прожили: ");
            var days = Console.ReadLine();
            int dayss = Convert.ToInt32(days);
            int year = dayss / 365;
            int month = (dayss % 365) / 30;
            dayss = (dayss % 365) % 30;
            Console.WriteLine($"Ваш возраст составляет {year} лет {month} месяцев и {dayss} дней");
            if (year >= 18)
            {
                Console.WriteLine($"Поздравляю! Вы совершеннолетний!");


            }
            else
                Console.WriteLine($"Вы несовершеннолетний");

            Console.ReadKey();





        }
    }
}