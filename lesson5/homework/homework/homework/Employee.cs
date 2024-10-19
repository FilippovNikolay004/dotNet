using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAndAirplane {
    internal class Employee {
        private string firstName;
        private string lastName;
        private string dateOfBirth;
        private string contactPhoneNumber;
        private string email;
        private string post;
        private string descOfOfficialDuties;

        public void DataEntry() {
            bool isNext = false;

            do {
                Console.Write("Введите имя: ");
                firstName = Console.ReadLine();

                isNext = !(IsLetter(firstName));
                if (isNext) { Console.WriteLine("Нельзя вводить цифры!\n"); }
            } while (isNext);

            do {
                Console.Write("Введите фамилию: ");
                lastName = Console.ReadLine();

                isNext = !(IsLetter(lastName));
                if (isNext) { Console.WriteLine("Нельзя вводить цифры!\n"); }
            } while (isNext);

            do {
                Console.Write("Введите дату рождения: ");
                dateOfBirth = Console.ReadLine();

                isNext = !(IsFormatDate(dateOfBirth));
                if (isNext) { Console.WriteLine("Неверный формат даты.\nФормат должен быть: дд.мм.гггг\n"); }
            } while (isNext);

            do {
                Console.Write("Введите контактный номер тел.: ");
                contactPhoneNumber = Console.ReadLine();

                isNext = IsLetter(contactPhoneNumber);
                if (isNext) { Console.WriteLine("Нельзя вводить буквы!\n"); }
            } while (isNext);

            do {
                Console.Write("Введите свою почту: ");
                email = Console.ReadLine();

                isNext = !(IsFormatEmail(email));
                if (isNext) { Console.WriteLine("Вы ввели неверный формат почты!\n"); }
            } while (isNext);

            do {
                Console.Write("Введите вашу должность: ");
                post = Console.ReadLine();

                isNext = !(IsLetter(post));
                if (isNext) { Console.WriteLine("Нельзя вводить цифры!\n"); }
            } while (isNext);
            
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

        private bool IsLetter(string value) {
            for (int i = 0; i < value.Length; i++) {
                if (value[i] >= '0' && value[i] <= '9') { return false; }
            }

            return true;
        }

        private bool IsFormatEmail(string email) {
            if (email.IndexOf("@") != -1) { return true; }
            return false;
        }

        private bool IsFormatDate(string date) {
            if (date.Length > 10 || date.Length < 10) { return false; }
            if (date[2] != '.') { return false; }
            if (date[5] != '.') { return false; }

            string tempNumberOfString = "";

            tempNumberOfString = date[0].ToString();
            tempNumberOfString += date[1].ToString();
            if (int.Parse(tempNumberOfString) > 31 || 
                int.Parse(tempNumberOfString) <= 0) { return false; }

            tempNumberOfString = date[3].ToString();
            tempNumberOfString += date[4].ToString();
            if (int.Parse(tempNumberOfString) > 12 || 
                int.Parse(tempNumberOfString) <= 0) { return false; }

            return true;
        }

        public void SetFirstName(string firstName) {
            if (!(IsLetter(this.firstName))) { Console.WriteLine("Нельзя вводить цифры!\n"); return; }
            this.firstName = firstName;
        }
        public void SetLastName(string lastName) {
            if (!(IsLetter(lastName))) { Console.WriteLine("Нельзя вводить цифры!\n"); return; }
            this.lastName = lastName;
        }
        public void SetDateOfBirth(string dateOfBirth) {
            if (!(IsFormatDate(dateOfBirth))) { Console.WriteLine("Неверный формат даты.\nФормат должен быть: дд.мм.гггг\n"); return; }
            this.dateOfBirth = dateOfBirth;
        }
        public void SetContactPhoneNumber(string contactPhoneNumber) {
            if (IsLetter(contactPhoneNumber)) { Console.WriteLine("Нельзя вводить буквы!\n"); return; }
            this.contactPhoneNumber = contactPhoneNumber;
        }
        public void SetEmail(string email) {
            if (!(IsFormatEmail(email))) { Console.WriteLine("Вы ввели неверный формат почты!\n"); return; }
            this.email = email;
        }
        public void SetPost(string post) {
            if (!(IsLetter(post))) { Console.WriteLine("Нельзя вводить цифры!\n"); return; }
            this.post = post;
        }
        public void SetDescOfOfficialDuties(string descOfOfficialDuties) { this.descOfOfficialDuties = descOfOfficialDuties; }

        public string GetFirstName() { return this.firstName; }
        public string GetLastName() { return this.lastName; }
        public string GetDateOfBirth() { return this.dateOfBirth; }
        public string GetContactPhoneNumber() { return this.contactPhoneNumber; }
        public string GetEmail() { return this.email; }
        public string GetPost() { return this.post; }
        public string GetDescOfOfficialDuties() { return this.descOfOfficialDuties; }

    }

    internal class Airplane {
        private string name;
        private string manufacturer;
        private int yearOfManufacture;
        private string aircraftType;

        public Airplane() {
            name = "";
            manufacturer = "";
            yearOfManufacture = 0;
            aircraftType = "";
        }

        public Airplane(string name, string manufacturer, int yearOfManufacture, string aircraftType) {
            this.name = name;
            this.manufacturer = manufacturer;

            if (!IsFormatYear(yearOfManufacture)) {
                throw new ArgumentException("Неверный формат года!"); 
            }
            this.yearOfManufacture = yearOfManufacture;

            if (!IsLetter(aircraftType)) {
                throw new ArgumentException("Нельзя вводить цифры в тип самолёта!");
            }
            this.aircraftType = aircraftType;
        }

        public Airplane(string name, string manufacturer, int yearOfManufacture) : this(name, manufacturer, yearOfManufacture, "Неизвестно") { }

        public void DataEntry() {
            bool isNext = false;

            Console.Write("Введите название самолета: ");
            name = Console.ReadLine();

            Console.Write("Введите название производителя: ");
            manufacturer = Console.ReadLine();

            do {
                Console.Write("Введите год выпуска: ");
                yearOfManufacture = int.Parse(Console.ReadLine());

                isNext = !(IsFormatYear(yearOfManufacture));
                if (isNext) { Console.WriteLine("Неверный формат года!\n"); }
            } while (isNext);

            do {
                Console.Write("Введите тип самолёта: ");
                aircraftType = Console.ReadLine();

                isNext = !(IsLetter(aircraftType));
                if (isNext) { Console.WriteLine("Нельзя вводить цифры!\n"); }
            } while (isNext);
        }

        public void DataPrint() {
            Console.WriteLine("Название самолета: " + name);
            Console.WriteLine("Производитель: " + manufacturer);
            Console.WriteLine("Год выпуска: " + yearOfManufacture);
            Console.WriteLine("Тип самолёта: " + aircraftType);
        }

        private bool IsFormatYear(int year) {
            if (year.ToString().Length > 4) { return false; }
            if (year <= 0) { return false; }

            return true;
        }
        private bool IsLetter(string value) {
            for (int i = 0; i < value.Length; i++) {
                if (value[i] >= '0' && value[i] <= '9') { return false; }
            }

            return true;
        }
    
        public void SetName(string name) { this.name = name; }
        public void SetManufacturer(string manufacturer) { this.manufacturer = manufacturer; }
        public void SetYearOfManufacture(int yearOfManufacture) {
            if (!(IsFormatYear(yearOfManufacture))) { Console.WriteLine("Неверный формат года!\n"); return; }
            this.yearOfManufacture = yearOfManufacture;
        }
        public void SetAircraftType(string aircraftType) {
            if (!(IsLetter(aircraftType))) { Console.WriteLine("Нельзя вводить цифры!\n"); }
            this.aircraftType = aircraftType;
        }
    }
}
