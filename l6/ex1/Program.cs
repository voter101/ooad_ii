using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1 {
    public class Program {
        static void Main(string[] args) {
            ILogger logger1 = LoggerFactory.GetLogger( LogType.File, @"C:\Users\Voter101\Desktop\foo.txt" );
            logger1.Log( "foo bar" ); // logowanie do pliku
            ILogger logger2 = LoggerFactory.GetLogger( LogType.None
            );
            logger2.Log( "qux" );
        }
    }
}
