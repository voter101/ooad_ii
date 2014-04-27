using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2 {
    abstract public class AbstractExpression {
        public abstract bool Interpret(Context context);
    }
}
