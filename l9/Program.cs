using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_l9 {
    class Program {
        static void Main(string[] args) {
            SimpleContainer container = new SimpleContainer();
            container.RegisterType<Testing>( false );
            Testing t1 = container.Resolve<Testing>();
            t1.foo();
            TestingSingleton t2, t3;
            container.RegisterType<TestingSingleton>( true );
            t2 = container.Resolve<TestingSingleton>();
            t3 = container.Resolve<TestingSingleton>();
            Console.WriteLine( t2 == t3 );
            IFoo t4, t5;
            container.RegisterType<IFoo, TestingWithInterface>( false );
            t4 = container.Resolve<IFoo>();
            t4.foo();
            container.RegisterType<IFoo, TestingWithInterface2>( false );
            t5 = container.Resolve<IFoo>();
            t5.foo();
            Console.ReadKey();
        }
    }
}
