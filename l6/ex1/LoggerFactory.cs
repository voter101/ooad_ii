using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z1 {
    public class LoggerFactory {
        public static ILogger GetLogger(LogType LogType, string Parameter = null) {
            ILogger logger;
            switch ( LogType ) {
                case LogType.Console:
                    logger = new ConsoleLogger();
                    break;
                case LogType.File:
                    logger = new FileLogger( Parameter );
                    break;
                default:
                    logger = new NullLogger();
                    break;
            }
            return logger;
        }
    }
}
