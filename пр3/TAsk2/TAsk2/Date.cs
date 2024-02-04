using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAsk2
{

    class Date
    {

        public static int DifDate(DateTime a,DateTime b)
        {
            int difDay = 0;
            int i = a.Year;
            do
            {
                if (DateTime.IsLeapYear(i) == true & i != b.Year) difDay += 366;
                else if (DateTime.IsLeapYear(i) == false & i != b.Year) difDay += 365;
                if (i == b.Year - 1 & i != b.Year) difDay = difDay - a.DayOfYear + b.DayOfYear;
                if (i == b.Year) difDay += b.DayOfYear - a.DayOfYear;
                i++;
            } while (i < b.Year);
            return difDay;
        }
    }
}
