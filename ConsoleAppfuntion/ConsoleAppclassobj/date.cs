using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppclassobj
{
    internal class date
    {
        // by default all fields are pvt 
        private int day, month, year;

        public int GetDay()
        {
            return day;
        }

        public int Month()
        {
            return month;
        }

        public int Year()
        {
            return year;
        }

        public void SetDay(int d)
        {
            day = d;
        }

        public void SetMonth(int m)
        {
            month = m;
        }

        public void SetYear(int y)
        {
            year = y;
        }



    }
}
