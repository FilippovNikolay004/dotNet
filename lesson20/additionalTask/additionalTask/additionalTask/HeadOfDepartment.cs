using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace additionalTask {
    internal class HeadOfDepartment: Person {
        public HeadOfDepartment() : this(null, null, null, null, null) { }
        public HeadOfDepartment(string lastName, string firstName, string gender, Passport passport, string placeResidence) :
            base(lastName, firstName, gender, passport, placeResidence) {
        }
    }
}
