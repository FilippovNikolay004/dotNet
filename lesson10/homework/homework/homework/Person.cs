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
        public bool IsStudentExistsByLastName(string SurName) { return SurName == this.SurName; }
    }


    class AcademyGroup {
        protected Student[] students;
        protected int count;

        public AcademyGroup(params Student[] students) {
            this.students = new Student[students.Length];
            for (int i = 0; i < students.Length; i++) {
                this.students[i] = students[i];
            }
        }
        public AcademyGroup() {
            count = 0;
            students = new Student[10];
        }
        public AcademyGroup(int size) {
            count = 0;
            students = new Student[size];
        }

        public void Print() {
            for (int i = 0; i < students.Length;i++) { students[i].Print(); Console.WriteLine(""); }
        }
        public void Add(Student student) {
            Student[] tempStudents = new Student[this.students.Length + 1];
            for (int i = 0; i < this.students.Length; i++) {
                tempStudents[i] = this.students[i];
            }

            tempStudents[this.students.Length] = student;
            this.students = tempStudents;
        }
        public void Remove(string SurName) {
            int index = FindStudentIndexByLastName(SurName);
            if (index == -1) { Console.WriteLine("Такого студента нет!"); return; };

            Student[] tempStudents = new Student[this.students.Length - 1];
            for (int i = 0, j = 0; i < this.students.Length; i++) {
                if (index != i) { tempStudents[j++] = this.students[i]; }
            }

            this.students = tempStudents;
        }
        public void Edit(string SurName, Student newStudent) {
            int index = FindStudentIndexByLastName(SurName);
            if (index == -1) { Console.WriteLine("Такого студента нет!"); return; };

            students[index] = newStudent;
        }

        private int FindStudentIndexByLastName(string SurName) {
            int index = -1;

            for (int i = 0; i < students.Length; i++) {
                if (students[i].IsStudentExistsByLastName(SurName)) { index = i; return index; }
            }

            return index;
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
