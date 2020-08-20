using System;
using OnlinePOSLib;

namespace OnlinePOSConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            var holidays = EasterCalculator.EasterHolidays("2020");
            foreach (var holiday in holidays)
            {
                Console.WriteLine(holiday.ToLongDateString());
            }

            Console.ReadLine();
        }
    }
}
