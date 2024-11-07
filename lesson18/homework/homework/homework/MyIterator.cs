using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework {
    class MyIterator<T> where T : IEnumerable {
        readonly T collection = default;

        public MyIterator(T collection) { this.collection = collection; }
        public void Print() {
            foreach (object obj in collection) { Console.Write(obj + " "); }
        }
    }
}
