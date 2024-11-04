using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework {
    internal class House {
        private string[] parts;
        public House() { parts = new string[0]; }
        
        public void Add(string part) {
            string[] patrsTemp = new string[parts.Length + 1];
            for (int i = 0; i < parts.Length; i++) { patrsTemp[i] = parts[i]; }

            patrsTemp[parts.Length] = part;
            parts = patrsTemp;
        }

        public string ListParts() {
            string str = string.Empty;

            for (int i = 0; i < parts.Length; i++) { str += parts[i] + ", "; }
            str = str.Remove(str.Length - 2); // removing last ",c"

            Console.WriteLine("       ^       ");
            Console.WriteLine("      / \\      ");
            Console.WriteLine("     /   \\     ");
            Console.WriteLine("    /     \\    ");
            Console.WriteLine("   /_______\\   ");
            Console.WriteLine("  |         |  ");
            Console.WriteLine("  |  _   _  |  ");
            Console.WriteLine("  | | | | | |  ");
            Console.WriteLine("  | | | | | |  ");
            Console.WriteLine("  | |_|_|_| |  ");
            Console.WriteLine("  |_________|  ");


            return "Product parts: " + str + "\n";
        }
    }
}
