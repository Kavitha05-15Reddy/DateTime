using System;

namespace DateTimes
{
    class Methods
    {
        //Diaplay:
        public void Display()
        {
            DateTime value = new DateTime(2016,6,8,11,49,0);
            Console.WriteLine("Complete date:"+value.ToString());
            Console.WriteLine("short date:"+value.ToShortDateString());
            Console.WriteLine("diaplay date using 24-hour clock format:"+value.ToString("M/d/yyyy HH:mm::ss"));
            Console.WriteLine(value.ToString("M/d/yyyy HH:mm"));
        }
        //Properties:
        public void Properties()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("date and time:" + date);
            Console.WriteLine("date:" + date.Date);
            Console.WriteLine("time:" + date.TimeOfDay);
            Console.WriteLine("year:" + date.Year);
            Console.WriteLine("Month:" + date.Month);
            Console.WriteLine("day:" + date.Day);
            Console.WriteLine("hour:" + date.Hour);
            Console.WriteLine("minute:" + date.Minute);
            Console.WriteLine("second:" + date.Second);
            Console.WriteLine("millisecond:" + date.Millisecond);
            Console.WriteLine("dayofweek:" + date.DayOfWeek);
        }
        //Day:
        public void Day()
        {
            DateTime day = new DateTime(2024,8,5);
            string dayOfweek = day.DayOfWeek.ToString();
            Console.WriteLine("The day of the week 5/8/2024:"+ dayOfweek);  
        }
        //Year:
        public void Year()
        {
            int syear = 2001;
            int eyear = 2008;
            for (int year=syear; year <= eyear; year++)
            {
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine($"12/31/{year}:day 366 of {year} (Leap year)");
                }
                else 
                {
                    Console.WriteLine($"12/31/{year}:day 365 of {year}");
                }
            }
        }
        //Format:
        public void Format()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("General format:" + date.ToString("M/d/yyyy HH:mm:ss tt"));
            Console.WriteLine("Custom format:" + date.ToString("M/d/yyyy"));
            Console.WriteLine("Long format:" + date.ToString("dddd,MMMM dd,yyyy"));
        }
        //Add days:
        public void Add()
        {
            DateTime toady = DateTime.Now;
            DateTime after = toady.AddDays(40);
            Console.WriteLine("Today:" + toady.ToString("dddd,MMMM dd,yyyy"));
            Console.WriteLine("After 40 days:"+after.ToString("dddd,MMMM dd,yyyy"));
        }
        //Compare dates:
        public void Compare()
        {
            DateTime date1 = new DateTime(2016, 8, 1);
            DateTime date2 = new DateTime(2016, 8, 1);
            int result = DateTime.Compare(date1, date2);
            if (result < 0) 
            {
                Console.WriteLine("p");
                Console.WriteLine("{0} is the earlier than {1}", date1, date2);
            }
            else if (result == 0)
            {
                Console.WriteLine("Q");
                Console.WriteLine("{0} is the same as {1}", date1, date2);
            }
            else 
            {
                Console.WriteLine("R");
                Console.WriteLine("{0} is the later than {1}", date1, date2);
            }
        }
        //Compare years:
        public void Compare1()
        {
            DateTime cuurentDate = DateTime.Now;
            DateTime oneYearBefore = cuurentDate.AddYears(-1);
            DateTime oneYearAfter = cuurentDate.AddYears(1);
            Console.WriteLine("Before one year:"+ oneYearBefore.ToString("M/d/yyyy"));
            Console.WriteLine("After one year:" + oneYearAfter.ToString("M/d/yyyy"));
            int comparison = DateTime.Compare(oneYearBefore, oneYearAfter);
            if (comparison < 0)
            {
                Console.WriteLine("earlier than:"+oneYearBefore.ToString("M/d/yyyy"));
            }
            else
            {
                Console.WriteLine("later than:"+oneYearAfter.ToString("M/d/yyyy"));
            }
        }
        //Month:
        public void Month()
        {
            int year = 2024;
            int month = 2;
            int daysInMonth = DateTime.DaysInMonth(year, month);
            Console.WriteLine(daysInMonth);
        }
        //UTC:
        public void UTC()
        {
            long fileTime = 8640000000000000;
            DateTime utcTime = DateTime.FromFileTimeUtc(fileTime);
            Console.WriteLine(utcTime.ToString("M/d/yyyy h:mm:ss tt"));
        }
        //Patterns:
        public void Patterns()
        {
            //DateTime date1 = new DateTime(2009, 7, 28);
            DateTime date = DateTime.Now;
            Console.WriteLine("short date:"+date.ToString("d"));
            Console.WriteLine("long date:" + date.ToString("D"));
            Console.WriteLine("short time:" + date.ToString("t"));
            Console.WriteLine("long time:" + date.ToString("T"));
            Console.WriteLine("full ldate and stime:" + date.ToString("f"));
            Console.WriteLine("full ldate and ltime:" + date.ToString("F"));
            Console.WriteLine("general ldate and stime:" + date.ToString("g"));
            Console.WriteLine("general ldate and ltime:" + date.ToString("G"));
            Console.WriteLine("month and day:" + date.ToString("M"));
            Console.WriteLine("year and month:" + date.ToString("Y"));
            Console.WriteLine(date.ToString("R"));
            Console.WriteLine(date.ToString("s"));
            Console.WriteLine(date.ToString("u"));
            Console.WriteLine(date.ToString("U"));
            Console.WriteLine(date.ToString("dddd,MMMM dd,yyyy"));
        }
        //Find day:
        public void Find()
        {
            Console.WriteLine("Month:");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Year:");
            int year = Convert.ToInt32(Console.ReadLine());
            int day = 7;
            DateTime date = new DateTime(year,month,day);
            Console.WriteLine("the formatted date is:"+date.ToString("d"));
            Console.WriteLine("the day for the date is:"+date.ToString("dddd"));
        }
        //Find lday fday: 
        public void Find1()
        {
            DateTime date = new DateTime(2024, 3, 16);
            Console.WriteLine("the formatted date is:" + date.ToString("d"));
            Console.WriteLine("the day for the date is:" + date.ToString("dddd"));
            //LastDayOfMonth
            int lastDayOfMonth = DateTime.DaysInMonth(2024, 3);
            DateTime lastDaydate = new DateTime(2024, 3, lastDayOfMonth);
            Console.WriteLine("the formatted date is:" + lastDaydate.ToString("d"));
            Console.WriteLine("the day for the date is:" + lastDaydate.ToString("dddd"));
            //FirstDayOfNextMonth
            DateTime firstDayOfNextMonth = date.AddMonths(1);
            firstDayOfNextMonth = new DateTime(firstDayOfNextMonth.Year, firstDayOfNextMonth.Month,1);
            Console.WriteLine("firstDayOfNextMonth:"+ firstDayOfNextMonth.ToString("d"));
            Console.WriteLine("the day for the date is:" + firstDayOfNextMonth.ToString("dddd"));
        }
    }
}
