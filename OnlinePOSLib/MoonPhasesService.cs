using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePOSLib
{
    public static class MoonPhasesService
    {
        public static int MyProperty { get; }

        /// <summary>
        /// Returns the next full moon given a date
        /// </summary>
        /// <param name="aDate"></param>
        /// <returns></returns>
        public static DateTime DateOfNextFullMoon(DateTime aDate)
        {
            //TODO: implement

            //The first fullmoon after march 21 in 2020 was april 8
            return new DateTime(2020, 4, 8);
        }
    }
}
