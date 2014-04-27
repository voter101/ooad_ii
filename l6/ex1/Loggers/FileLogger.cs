using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace z1 {
    public class FileLogger : ILogger {

        private FileInfo loggingFile;

        public FileLogger(string FilePath) {
            loggingFile = new FileInfo( FilePath );
            if ( !loggingFile.Exists ) {
                using ( FileStream fs = File.Create( FilePath ) ) {
                }
            }
        }

        public void Log(string Message) {
            using ( StreamWriter sw = loggingFile.AppendText() ) {
                sw.WriteLine( Message );
            }
        }
    }
}