using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAsk2
{
    class Prog
    {
        public static void Main()
        {
            DateTime a = new DateTime(2000,03,10);
            DateTime b = new DateTime(2000, 03, 30);
            Console.WriteLine(Date.DifDate(a, b));
        }
    }
}
