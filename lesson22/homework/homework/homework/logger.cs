using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework {
    internal class Logger: IDisposable {
        FileStream fs;
        
        public Logger(string nameFile, string msg) {
            fs = new FileStream(nameFile, FileMode.Append, FileAccess.Write);

            log(msg);
        }
        public Logger(string nameFile, string msg, string nameUser) {
            fs = new FileStream(nameFile, FileMode.Append, FileAccess.Write);
            Name = nameUser;

            log(msg);
        }

        public void Dispose() { fs.Close(); }

        public string Name { get; set; }

        public void log(string message) {
            StreamWriter writer = new StreamWriter(fs);

            writer.WriteLine($"[{DateTime.Now}] - {message}");
            writer.Close();
        }
    }
}