using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace additionalTask {
    internal class Student: Person {
        public List<Parent> Parents { get; set; } // Родители

        public Student():this(null, null, null, null, null, new List<Parent>()) { }
        public Student(string lastName, string firstName, string gender, Passport passport, string placeResidence, List<Parent> parents) :
            base(lastName, firstName, gender, passport, placeResidence) {

            Parents = parents;
        }
    }
}
