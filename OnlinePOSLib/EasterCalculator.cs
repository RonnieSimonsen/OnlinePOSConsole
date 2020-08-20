using System;
using System.Collections.Generic;

namespace OnlinePOSLib
{
    public static class EasterCalculator
    {
 
        public static DateTime NextSunday(DateTime aDate)
        {
            return aDate.AddDays(NumberOfDaysTilSunday(aDate.DayOfWeek));

            int NumberOfDaysTilSunday(DayOfWeek dayOfWeek)
            {
                switch (dayOfWeek)
                {
                    case DayOfWeek.Friday:
                        return 2;                        
                    case DayOfWeek.Monday:
                        return 6;                        
                    case DayOfWeek.Saturday:
                        return 1;                        
                    case DayOfWeek.Sunday:
                        return 0;                        
                    case DayOfWeek.Thursday:
                        return 3;                        
                    case DayOfWeek.Tuesday:
                        return 5;                        
                    case DayOfWeek.Wednesday:
                        return 4;                        
                    default:
                        //Is never reached but you avoid the compilation warning;
                        return 0;                        
                }
            }
        }

        /// <summary>
        /// Returns the 4 easter holidays Maundy Thursday, Good Friday, Easter Vigil and Easter Day
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<DateTime> EasterHolidays(string year)
        {            
            try
            {
                return EasterHolidays(int.Parse(year));
            }
            catch (Exception)
            {
                //TODO: log
                throw;
            }
        }

        /// <summary>
        /// Returns the 4 easter holidays Maundy Thursday, Good Friday, Easter Vigil and Easter Day
        /// </summary>
        /// <param name="year"></param>
        /// <returns></returns>
        public static IEnumerable<DateTime> EasterHolidays(int year)
        {
            //march 21. is defined tobe spring equinox and usually is
            DateTime march21 = new DateTime(year, 3, 21);

            //Easter sunday is the next sunday after the next fullmoon after march 21 
            DateTime easterSunday = NextSunday(MoonPhasesService.DateOfNextFullMoon(march21));
            
            //Maundy Thursday, Good Friday, Easter Vigil, Easter Day
            return new DateTime[] { easterSunday.AddDays(-3), easterSunday.AddDays(-2), easterSunday, easterSunday.AddDays(1) };


            ////Maundy Thursday
            //yield return easterSunday.AddDays(-3);
            ////Good Friday
            //yield return easterSunday.AddDays(-2);
            ////Easter Vigil
            //yield return easterSunday;
            ////Easter Day
            //yield return easterSunday.AddDays(1);
        }

    }

}
