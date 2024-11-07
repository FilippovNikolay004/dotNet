using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework {
    internal class Aquarium : IEnumerable {
        SeaInhabitants[] seaInhabitants = null;

        public Aquarium(params SeaInhabitants[] arr) {
            seaInhabitants = new SeaInhabitants[arr.Length];
            seaInhabitants = arr;
        }

        public IEnumerator GetEnumerator() {
            foreach (SeaInhabitants i in seaInhabitants) { yield return i.Name; }
        }
    }
}
