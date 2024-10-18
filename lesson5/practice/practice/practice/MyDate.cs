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

        public static int DaysDifference(MyDate dateOld, MyDate dateNew) {
            //(29, 09, 2023);
            //(18, 10, 2024);

            if (dateOld.Day > dateNew.day || dateOld.Month > dateNew.Month || dateOld.Year > dateNew.Year) {
                MyDate temp = dateNew;
                dateNew = dateOld;
                dateOld = temp;
            }

            int day = dateOld.Day;
            int month = dateOld.Month;
            int year = dateOld.Year;
            
            bool isFullMonth = false;
            int valueDay = 0;

            while (day != dateNew.Day || month != dateNew.Month || year != dateNew.Year) {
                day++;
                valueDay++;

                if (day > (isFullMonth ? 30 : 31)) {
                    day = 1;
                    month++;

                    if (month > 12) {
                        isFullMonth = true;
                        month = 1;
                        year++;
                    }
                }
            }

            return valueDay;
        }

        public void AddDaysToDate(int valueDay) {
            bool isFullMonth = false;

            for (int i = 0; i < valueDay; i++) {
                this.Day++;

                if (this.Day > (isFullMonth ? 30 : 31)) {
                    this.Day = 1;
                    this.Month++;

                    if (this.Month > 12) {
                        isFullMonth = true;
                        this.Month = 1;
                        this.Year++;
                    }
                }
            }
        }
    }
}
