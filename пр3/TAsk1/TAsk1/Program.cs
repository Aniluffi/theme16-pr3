using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ConsoleApp18

{

    class Program

    {

        static void Main(string[] args)

        {

            int years = int.Parse(Console.ReadLine());

            int month = int.Parse(Console.ReadLine());

            int day = int.Parse(Console.ReadLine());



            DateClass f = new DateClass(years, month, day);



            f.PrintDate();

            Console.WriteLine($"До конца месяца осталось - {f.DaysEndMonth()}");

            Console.ReadKey();

        }
    }
}