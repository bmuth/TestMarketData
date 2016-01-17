using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMarketData
{
    class Holidays
    {
        public static List<DateTime> MarketHolidays = new List<DateTime>
                                                            {
                                                                new DateTime (2014, 4, 18),
                                                                new DateTime (2014, 5, 26),
                                                                new DateTime (2014, 7, 4),
                                                                new DateTime (2014, 9, 1),
                                                                new DateTime (2014, 11, 27),
                                                                new DateTime (2014, 12, 25),
                                                                new DateTime (2015, 1, 1),
                                                                new DateTime (2015, 1, 19),
                                                                new DateTime (2015, 2, 16),
                                                                new DateTime (2015, 4, 3)
                                                            };
    }
    class Utils
    {
        public const int ibINIT_OC = 0x00010000;
        public const int ibDATA = 0x00020000;
        public const int ibPRICE = 0x00040000;

        /*******************************************************************
        * 
        * Compute Next Expiry Date
        * 
        * ****************************************************************/

        static internal DateTime ComputeNextExpiryDate (DateTime dt)
        {
            DateTime d = new DateTime (dt.Year, dt.Month, 1);
            if (d.DayOfWeek == DayOfWeek.Saturday)
            {
                d += new TimeSpan (7, 0, 0, 0);
            }
            d -= new TimeSpan ((int) d.DayOfWeek, 0, 0, 0);

            d += new TimeSpan (5 + 14, 0, 0, 0);

            if (Holidays.MarketHolidays.Contains (d))
            {
                d -= new TimeSpan (1, 0, 0, 0);
            }

            if (d < dt)
            {
                return ComputeNextExpiryDate (dt += new TimeSpan (14, 0, 0, 0));
            }
            return d;
        }

        /**************************************************************
         * 
         * Compute days to expire
         * 
         * ************************************************************/

        public static int ComputeDaysToExpire (DateTime dt, DateTime expiry)
        {
            TimeSpan full_days = expiry - dt;
            return (int) (Math.Ceiling (full_days.TotalDays)) + 1;
        }
    }
}
