using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework {
    internal class Director {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Director(): this(null, null) { }
        public Director(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() {
            return $"Имя: {FirstName}, фамилия: {LastName}";
        }
    }

    internal class Firm {
        public string Name { get; set; }
        public DateTime FoundingDate { get; set; }
        public string BusinessProfile {  get; set; }
        public Director Director { get; set; }
        public int QuantityEmployees { get; set; }
        public string Address {  get; set; }
        public Employee[] Employee { get; set; }

        public Firm() : this(null, DateTime.Now, null, null, 0, null, null) { }
        public Firm(string name, DateTime foundingDate, Director director, string businessProfile, int quantityEmployees, string address, Employee[] employee) {
            Name = name;
            FoundingDate = foundingDate;
            Director = director;
            BusinessProfile = businessProfile;
            QuantityEmployees = quantityEmployees;
            Address = address;
            Employee = employee;
        }

        public override string ToString() {
            return $"Название фирмы: {Name}\n" +
                $"Профиль бизнеса: {BusinessProfile}\n" +
                $"Дата основания: {FoundingDate}\n" +
                $"Директор: {Director}\n" +
                $"Кол-во сотрудников: {QuantityEmployees}\n" +
                $"Адрес: {Address}";
        }
    }
}
