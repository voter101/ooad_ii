using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2 {
    abstract public class AbstractToken {
        public abstract bool Interpret(Context context);
    }
}
