using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace homework {
    internal class Money {
        private int _units;
        private int _cents;
        private Logger _logger;

        public Money() : this(0, 0) { }
        public Money(int units, int cents) {
            Units = units; Cents = cents;

            using (_logger = new Logger("logger.txt", "Create obj")) { }
        }

        public int Units {
            get { return _units; }
            set {
                if (value < 0) { throw new Exception("Банкрот"); }
                _units = value;
            }
        }
        public int Cents {
            get { return _cents; }
            set {
                if (value < 0) {
                    int tempValue = Math.Abs(value); 

                    for (; tempValue >= 100; tempValue -= 100) { _units -= 1; }

                    if (tempValue != 0) {
                        _units -= 1;
                        _cents = (100 - tempValue);
                    }

                    return;
                }

                for (; value >= 100; value -= 100) { _units += 1; }
                _cents = value;
            }
        }

        public void Display() {
            using (_logger = new Logger("logger.txt", "Сalled the method: Display")) { }
            Console.WriteLine($"{Units},{Cents} грн."); 
        }
        public override string ToString() { return $"{Units},{Cents} грн."; }


        // Перегрузка операторов
        public static Money operator +(Money a, Money b) {
            using (Logger _logger = new Logger("logger.txt", "Сalled the operator: +")) { }

            return new Money(a.Units + b.Units, a.Cents + b.Cents);
        }
        public static Money operator -(Money a, Money b) {
            using (Logger _logger = new Logger("logger.txt", "Сalled the operator: -")) { }

            return new Money(a.Units - b.Units, a.Cents - b.Cents);
        }
        public static Money operator *(Money a, Money b) {
            using (Logger _logger = new Logger("logger.txt", "Сalled the operator: *")) { }

            return new Money(a.Units * b.Units, a.Cents * b.Cents);
        }
        public static Money operator /(Money a, Money b) {
            using (Logger _logger = new Logger("logger.txt", "Сalled the operator: /")) { }

            return new Money(a.Units / b.Units, a.Cents / b.Cents);
        }

        public static Money operator ++(Money a) {
            using (Logger _logger = new Logger("logger.txt", "Сalled the operator: ++")) { }

            a.Cents++;
            return a;
        }
        public static Money operator --(Money a) {
            using (Logger _logger = new Logger("logger.txt", "Сalled the operator: --")) { }

            a.Cents--;
            return a;
        }

        public static bool operator <(Money a, Money b) {
            using (Logger _logger = new Logger("logger.txt", "Сalled the bool operator: <")) { }

            if (a.Units < b.Units) return true;
            else if (a.Units == b.Units && a.Cents < b.Cents) return true;
            return false;
        }
        public static bool operator >(Money a, Money b) {
            using (Logger _logger = new Logger("logger.txt", "Сalled the bool operator: >")) { }

            if (a.Units > b.Units) return true;
            else if (a.Units == b.Units && a.Cents > b.Cents) return true;
            return false;
        }
        public static bool operator ==(Money a, Money b) {
            using (Logger _logger = new Logger("logger.txt", "Сalled the bool operator: ==")) { }

            return a.Units == b.Units && a.Cents == b.Cents;
        }
        public static bool operator !=(Money a, Money b) {
            using (Logger _logger = new Logger("logger.txt", "Сalled the bool operator: !=")) { }

            return !(a == b);
        }
    }
}
