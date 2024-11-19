using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice {
    internal class Student {
        public string _name { get; set; }
        public string _lastName { get; set; }
        public int _age { get; set; }
        public string _nameEducationalInstitution { get; set; }

        public Student() : this(null, null, 0, null) { }
        public Student(string name, string lastName, int age, string nameEducationalInstitution) {
            _name = name;
            _lastName = lastName;
            _age = age;
            _nameEducationalInstitution = nameEducationalInstitution;
        }

        public override string ToString() {
            return $"{_name} {_lastName}, {_age} years old, {_nameEducationalInstitution}";
        }
    }
}
