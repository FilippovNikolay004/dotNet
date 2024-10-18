using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeNamespace {
    internal class Employee {
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string contactPhoneNumber;
        private string email;
        private string post;
        private string descOfOfficialDuties;

        public void DataEntry() {
            Console.Write("Введите имя: ");
            firstName = Console.ReadLine();

            Console.Write("Введите фамилию: ");
            lastName = Console.ReadLine();

            Console.Write("Введите дату рождения: ");
            dateOfBirth = Console.ReadLine();

            Console.Write("Введите контактный номер тел.: ");
            contactPhoneNumber = Console.ReadLine();

            Console.Write("Введите свою почту: ");
            email = Console.ReadLine();

            Console.Write("Введите вашу должность: ");
            post = Console.ReadLine();

            Console.WriteLine("Опишите свои служебные обязанности: ");
            descOfOfficialDuties = Console.ReadLine();
        }

        public void DataPrint() {
            Console.WriteLine("Имя: " + firstName);
            Console.WriteLine("Фамилию: " + lastName);
            Console.WriteLine("Дата рождения: " + dateOfBirth);
            Console.WriteLine("Контактный номер тел.: " + contactPhoneNumber);
            Console.WriteLine("Почта: " + email);
            Console.WriteLine("Должность: " + post);
            Console.WriteLine("Служебные обязанности: ");
            Console.WriteLine(descOfOfficialDuties);
        }

        public void SetFirstName(string firstName) { this.firstName = firstName; }
        public void SetLastName(string lastName) { this.lastName = lastName; }
        public void SetDateOfBirth(string dateOfBirth) { this.dateOfBirth = dateOfBirth; }
        public void SetContactPhoneNumber(string contactPhoneNumber) { this.contactPhoneNumber = contactPhoneNumber; }
        public void SetEmail(string email) { this.email = email; }
        public void SetPost(string post) { this.post = post; }
        public void SetDescOfOfficialDuties(string descOfOfficialDuties) { this.descOfOfficialDuties = descOfOfficialDuties; }

        public string GetFirstName() { return this.firstName; }
        public string GetLastName() { return this.lastName; }
        public string GetDateOfBirth() { return this.dateOfBirth; }
        public string GetContactPhoneNumber() { return this.contactPhoneNumber; }
        public string GetEmail() { return this.email; }
        public string GetPost() { return this.post; }
        public string GetDescOfOfficialDuties() { return this.descOfOfficialDuties; }

    }
}
