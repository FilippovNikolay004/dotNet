using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    class Employee {
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public string Post {  get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int Salary { get; set; }

        public Employee() : this(null, null, null, null, null, 0) { }
        public Employee(string firstName, string lastName, string post, string phoneNumber, string email, int salary) {
            FirstName = firstName;
            LastName = lastName;
            Post = post;
            PhoneNumber = phoneNumber;
            Email = email;
            Salary = salary;
        }

        public override string ToString() {
            return $"Имя: {FirstName}\n" +
                $"Фамилия: {LastName}\n" +
                $"Должность: {Post}\n" +
                $"Номер телефона: {PhoneNumber}\n" +
                $"Почта: {Email}\n" +
                $"Зарплата: {Salary}";
        }
    }
}
