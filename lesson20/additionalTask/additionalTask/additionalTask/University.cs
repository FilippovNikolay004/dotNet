using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace additionalTask {
    internal class University {
        public List<Faculty> Faculties { get; set; }

        public University() : this(null) { }
        public University(List<Faculty> faculties) {
            Faculties = faculties;
        }

    }
}
