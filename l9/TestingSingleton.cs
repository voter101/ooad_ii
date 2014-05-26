using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_l9 {
    public class TestingSingleton {

        private static TestingSingleton instance;
        private static object lockObj = new object();

        public static TestingSingleton Instance {
            get {
                if ( instance == null ) {
                    lock ( lockObj ) {
                        if ( instance == null ) {
                            instance = new TestingSingleton();
                        }
                    }
                }
                return instance;
            }
        }

        private TestingSingleton() { }

    }
}
