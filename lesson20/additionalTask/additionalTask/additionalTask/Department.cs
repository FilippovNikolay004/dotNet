using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace additionalTask {
    internal class Department {
        public string NameDepartments { get; set; }
        public HeadOfDepartment HeadOfDepartment { get; set; }
        public bool isProfiling { get; set; }

        public Department() : this(null, null, false) { }
        public Department(string nameDepartments, HeadOfDepartment headOfDepartment, bool isProfiling) {
            NameDepartments = nameDepartments;
            HeadOfDepartment = headOfDepartment;
            this.isProfiling = isProfiling;
        }
    }
}
