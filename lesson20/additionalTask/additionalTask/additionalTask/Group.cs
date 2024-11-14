using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace additionalTask {
    internal class Group {
        public string NameGroup { get; set; }
        public List<Group> Groups { get; set; }
        public Department Department { get; set; }
        public string Elder { get; set; }

        public Group() { }
        public Group(string nameGroup, List<Group> groups, Department department, string elder) {
            NameGroup = nameGroup;
            Groups = groups;
            Department = department;
            Elder = elder;
        }
    }
}
