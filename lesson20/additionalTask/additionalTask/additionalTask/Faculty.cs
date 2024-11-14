using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace additionalTask {
    internal class Faculty {
        public string NameFaculty { get; set; }
        public Department Department { get; set; }
        public List<Group> Groups { get; set; }

        public Faculty() : this(null, null, null) { }
        public Faculty(string nameFaculty, Department department, List<Group> groups) {
            NameFaculty = nameFaculty;
            Department = department;
            Groups = groups;
        }
    }
}
