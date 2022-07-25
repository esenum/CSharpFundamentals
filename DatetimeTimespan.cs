using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    internal class DatetimeTimespan
    {
        public static void Main1()
        {
            var dateTime = new DateTime(2022, 7, 3);
            var now = DateTime.Now;
            var today = DateTime.Today;

            Console.WriteLine("Hour:{0} Minute:{1}", now.Hour,now.Minute);

            var tomorrow= now.AddDays(1);
            var yesterday = now.AddDays(-1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("yyyy-MM-dd HH:mm"));
        }

        public static void Main()
        {
            //Creating
            var timeSpan = new TimeSpan(1,2,3);
            var timeSpan1 = new TimeSpan(1,0,0);
            var timeSpan2 = TimeSpan.FromHours(1);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: "+duration);

            // Properties
            Console.WriteLine("Minutes: "+ timeSpan.Minutes);
            Console.WriteLine("Minutes: " + timeSpan.TotalMinutes);

            // Add & Subtract
            Console.WriteLine("Add example: "+timeSpan.Add(TimeSpan.FromMinutes(8)));
            Console.WriteLine("Add example: " + timeSpan.Subtract(TimeSpan.FromMinutes(2)));

            // ToString
            Console.WriteLine("ToString "+timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse: "+ TimeSpan.Parse("01:02:03"));

            

        }

    }
}


