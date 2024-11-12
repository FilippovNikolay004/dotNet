using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace homework {
    internal class CoffeeHouse {
        Queue<(int priority, string value)> queue;
        readonly int numberTables;
        int numberAvailableTables;

        public CoffeeHouse():this(10) { }
        public CoffeeHouse(int capacity) {
            numberTables = numberAvailableTables = 2;
            queue = new Queue<(int priority, string value)>(capacity);
        }

        public void AddVisitor(int priority, string name) {
            queue.Enqueue((priority, name));
        }

        public void SeatCustomer() {
            if (numberAvailableTables != 0) {
                (int priority, string value) highestPriorityItem = queue.OrderBy(item => item.priority).First();
                queue = new Queue<(int, string)>(queue.Where(item => item != highestPriorityItem));

                Console.WriteLine($"{highestPriorityItem.value} садится за столик");
                
                numberAvailableTables--;
                
                return;
            }

            Console.WriteLine("Все места заняты!");
        }

        public void FreeTable() {
            if (numberAvailableTables < numberTables) {
                Console.WriteLine("Столик освободился!");
                numberAvailableTables++;
            }
        }
    }
}
