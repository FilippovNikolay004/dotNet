using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDateNameSpace {
    internal class MyDate {
        int day = 0;
        int month = 0;
        int year = 0;

        public MyDate() { }
        public MyDate(int day, int month, int year) {
            if (day > 0) { this.day = day; } else { this.day = 1; }
            if (month > 0) { this.month = month; } else { this.month = 1; }
            if (year > 0) { this.year = year; } else { this.year = 2024; }
        }

        public int Day { get { return day; } set { if (value > 0) { day = value; } else { day = 1; } } }
        public int Month { get { return month; } set { if (value > 0) { month = value; } else { month = 1; } } }
        public int Year { get { return year; } set { if (value > 0) { year = value; } else { year = 2024; } } }
        public string DayOfWeek { 
            get { 
                DateTime date = new DateTime(year, month, day); 
                return date.DayOfWeek.ToString(); 
            } 
        }

        public string PrintDate() { return Day.ToString() + "." + Month.ToString() + "." + Year.ToString(); }

        public int DaysDifference() {
            int result = 0;

            return result;
        }

        public int AddDaysToDate() {
            int result = 0;

            return result;
        }
    }
}
