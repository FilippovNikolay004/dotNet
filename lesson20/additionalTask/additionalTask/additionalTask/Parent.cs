using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace additionalTask {
    internal class Parent: Person {
        public List<Student> Children { get; set; } // Дети-студенты

        public Parent(string lastName, string firstName, string gender, Passport passport, string placeResidence, List<Student> сhildren) :
            base(lastName, firstName, gender, passport, placeResidence) {

            Children = сhildren;
        }
    }
}
