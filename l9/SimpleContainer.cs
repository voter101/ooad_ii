using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace POO_l9 {
    class SimpleContainer {

        HashSet<Tuple<Type, bool>> registeredTypes = new HashSet<Tuple<Type, bool>>();
        HashSet<Tuple<Type, Type, bool>> registeredInterfaceTypes = new HashSet<Tuple<Type, Type, bool>>();

        public void RegisterType<T>(bool Singleton) where T : class {
            registeredTypes.Add( new Tuple<Type, bool>(typeof(T), Singleton) ); 
        }

        public void RegisterType<From, To>(bool Singleton) where To : From {
            registeredInterfaceTypes.RemoveWhere( item => item.Item1 == typeof( From ) );
            registeredInterfaceTypes.Add(new Tuple<Type, Type, bool>(typeof(From),typeof(To), Singleton));
        }

        public T Resolve<T>() {
            Type type = typeof( T );
            bool singleton = false;
            if ( typeof( T ).IsInterface ) {
                if ( registeredInterfaceTypes.Count > 0 ) {
                    Tuple<Type, Type, bool> tuple = registeredInterfaceTypes.Where( item => item.Item1 == typeof( T ) ).First();
                    if ( tuple == null ) {
                        throw new Exception( "No interface registered" );
                    }
                    type = tuple.Item2;
                    singleton = tuple.Item3;
                } else {
                    throw new Exception( "No interface registered" );
                }
            } else {
                if ( registeredTypes.Count > 0 ) {
                    Tuple<Type, bool> tuple = registeredTypes.Where( item => item.Item1 == typeof( T ) ).First();
                    if ( tuple == null ) {
                        throw new Exception( "This class isn't registered" );
                    }
                    singleton = tuple.Item2;
                } else {
                    throw new Exception( "This class isn't registered" );
                }
            }

            if ( singleton ) {
                return InvokeSingleton<T>();
            }
            return (T) Activator.CreateInstance( type );
        }

        private T InvokeSingleton<T>() {
            T returnInstance = (T) typeof( T ).GetProperty( "Instance" ).GetValue( null );
            return returnInstance;
        }
    }
}
