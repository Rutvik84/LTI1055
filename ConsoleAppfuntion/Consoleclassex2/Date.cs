using System;
using System.Collections.Generic;
using System.Text;

namespace Consoleclassex2
{
    internal class Date
    {
        private int day,month, year;

        public Date(int d,int m,int y)
        {
            day = d;
            month = m;
            year = y;
        }

        public override string ToString()
        {
            return day + " " + month + "/" + year;
        }


    }
}
