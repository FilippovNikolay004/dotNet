using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework {
    internal class Participant {
        public string Name { set;  get; }
        public string LastName { set; get; }
        public int Age { set; get; }
    }
    internal class FootballTeam :IEnumerable {
        Participant[] participant;
        public FootballTeam(params Participant[] arr) {
            participant = new Participant[arr.Length];
            participant = arr;
        }
        public IEnumerator GetEnumerator() {
            foreach (Participant i in participant) { yield return i.Name; }
        }
    }
}
