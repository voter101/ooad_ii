using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1 {
    public class ConsoleLogger : ILogger {

        public void Log(string Message) {
            System.Console.WriteLine( Message );
        }
    }
}
