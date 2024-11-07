using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework {
    internal class Employee {
        public string Name { set; get; }
        public string LastName { set; get; }
        public int Age { set; get; }
        public string JobTitle { set; get; }
    }
    internal class CoffeeShop :IEnumerable {
        Employee[] employees;

        public CoffeeShop(params Employee[] arr) {
            employees = new Employee[arr.Length];
            employees = arr;
        }
        public IEnumerator GetEnumerator() {
            foreach (Employee i in employees) { yield return i.Name; }
        }
    }
}
