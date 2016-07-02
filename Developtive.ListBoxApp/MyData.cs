using System;
using System.Collections.Generic;

namespace Developtive.ListBoxApp
{
    internal class MyData
    {
        public string Color { get; set; }
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public string Description { get; set; }

        internal static List<MyData> SampleData()
        {
            var source = new List<MyData>();
            source.Add(new MyData { Color = "#ba987a", Name = "Visual Studio", Time = DateTime.Now, Description = description_a });
            source.Add(new MyData { Color = "#49c291", Name = "DateTime", Time = DateTime.Now, Description = description_b });
            source.Add(new MyData { Color = "#2b6ec5", Name = "string", Time = DateTime.Now, Description = description_c });
            return source;
        }

        static string description_a = @"The T:System.DateTime value type represents dates and times with values ranging from 00:00:00 (midnight), January 1, 0001 Anno 
            Domini (Common Era) through 11:59:59 P.M., December 31, 9999 A.D. (C.E.) in the Gregorian calendar.";
        static string description_b = @"Time values are measured in 100-nanosecond units called ticks, and a particular date is the number of ticks since 12:00 midnight, 
            January 1, 0001 A.D. (C.E.) in the T:System.Globalization.GregorianCalendar calendar(excluding ticks that would be added by leap seconds).";
        static string description_c = @"For example, a ticks value of 31241376000000000L represents the date, Friday, January 01, 0100 12:00:00 midnight.A T:System.DateTime value 
            is always expressed in the context of an explicit or default calendar.";
    }
}