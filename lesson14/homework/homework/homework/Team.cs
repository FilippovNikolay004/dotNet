using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework {
    internal class Team : IPart {
        private House house = new House();

        public void Basement() {
            house.Add("Фундамент");
        }
        public void Walls() {
            house.Add("Стены");
        }
        public void Door() {
            house.Add("Дверь");
        }
        public void Window() {
            house.Add("Окно");
        }
        public void Roof() {
            house.Add("Крыша");
        }

        public House GetHouse() { return house; }
    }
}
