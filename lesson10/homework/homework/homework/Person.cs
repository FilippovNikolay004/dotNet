using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework {
    internal class Person {
        protected string Name { get; set; }
        protected string SurName { get; set; }
        protected int Age { get; set; }
        protected string Phone { get; set; }

        public Person():this(null, null, 0, null) { }

        public Person(string name, string surName, int age, string phone) {
            Name = name;
            SurName = surName;
            Age = age;
            Phone = phone;
        }

        public void Print() {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Sur Name: {SurName}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Phone: {Phone}");
        }
    }

    internal class Student : Person {
        protected double Average { get; set; }
        protected int NumberOfGroup { get; set; }
        public Student():this(null, null, 0, null, 0, 0) { }
        public Student(string name, string surName, int age, string phone, 
            double average, int numberOfGroup) :
                base(name, surName, age, phone) {
            Average = average;
            NumberOfGroup = numberOfGroup;
        }
        new public void Print() {
            base.Print();
            Console.WriteLine($"Average: {Average}");
            Console.WriteLine($"Number Of Group: {NumberOfGroup}");
        }
    }


    class AcademyGroup {
        protected Student[] students;
        protected int count;

        public AcademyGroup() {
            count = 0;
            students = new Student[10];
        }

        public void Print() {

        }
        public void Add(Student student) {

        }
        public void Remove(string SurName) {

        }
        public void Edit(string SurName) {

        }

        // Работа с файлами
        public void Save() {

        }
        public void Load() {

        }
        public void Search() {

        }
    }

    class MainClass : AcademyGroup {

    }
}
