using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    
        public struct HiringDate
        {
           

            public HiringDate(int _day, int _month, int _year)
            {
                day = _day;
                month = _month;
                year = _year;
            }


        private int day;

        public int Day
        {
            get { return day; }
            set { day = value; }
        }
        private int month;

        public int Month
        {
            get { return month; }
            set { month = value; }
        }
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }




        public string printHiringDay()
            {
                //Console.WriteLine($"HiringDate is {Day}/{Month}/{Year}");
                return ($"HiringDate is {day}/{month}/{year}");
            }



        }

    
}
