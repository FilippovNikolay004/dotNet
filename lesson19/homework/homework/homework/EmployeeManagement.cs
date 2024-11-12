using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework {
    internal class EmployeeManagement {
        Dictionary<string, string> employees;

        public EmployeeManagement() : this (new Dictionary<string, string>()) { }
        public EmployeeManagement(params Dictionary<string, string>[] employees) {
            this.employees = new Dictionary<string, string>();

            for (int i = 0; i < employees.Length; i++) {
                foreach (KeyValuePair<string, string> item in employees[i]) {
                    this.employees.Add(item.Key, item.Value);
                }
            }
        }

        public void AddLogin(string login, string password) { employees.Add(login, password); }
        public void RemoveLogin(string login) {
            if (!employees.ContainsKey(login)) { Console.WriteLine("Сотрудник с таким логином не найден."); return; }

            employees.Remove(login); 
        }
        public void UpdateLogin(string oldLogin, string newLogin, string newPassword) {
            if (!employees.ContainsKey(oldLogin)) { Console.WriteLine("Сотрудник с таким логином не найден."); return; }

            employees.Remove(oldLogin);
            employees.Add(newLogin, newPassword);
        }
        public string GetPassword(string login) {
            if (!employees.ContainsKey(login)) { Console.WriteLine("Сотрудник с таким логином не найден."); return ""; }

            return employees[login];
        }

        public void PrintDate() {
            Console.WriteLine("База данных содержит: ");
            foreach (KeyValuePair<string, string> item in employees)
                Console.WriteLine("Login = {0}\nPassword = {1}\n", item.Key, item.Value);
        }
    }
}
