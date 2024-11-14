using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace additionalTask {
    internal class Person {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }
        public Passport Passport { get; set; }
        public string PlaceResidence { get; set; }

        public Person(string lastName, string firstName, string gender, Passport passport, string placeResidence) {
            LastName = lastName;
            FirstName = firstName;
            Gender = gender;
            Passport = passport;
            PlaceResidence = placeResidence;
        }
    }
}
