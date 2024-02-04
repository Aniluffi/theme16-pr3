using System;
using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace ConsoleApp18

{

    class DateClass

    {

        DateTime data;



        public DateClass()

        {



        }



        public DateClass(int year, int month, int day)

        {

            this.data = new DateTime(year, month, day);

        }



        public DateTime Data { get => data; set => data = value; }



        public void PrintDate()

        {

            Console.WriteLine($"Год: {data.Year} \n" +

                $"Месяц: {data.Month}\n" +

                $"День: {data.Day}\n" +

                $"{data.ToString("d")}");

        }



        public void NextDay()

        {

            Console.WriteLine($"Следующий день: {data.AddDays(1)}");

        }



        public void PreviousDay()

        {

            Console.WriteLine($"Предыдущий день: {data.AddDays(-1)}");

        }



        public int DaysEndMonth()

        {

            return DateTime.DaysInMonth(data.Year, data.Month) - data.Day;

        }

    }





}
