using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2 {
    public class Negation : AbstractUnaryOperator {
        public override bool Interpret(Context context, AbstractExpression expression) {
            return !expression.Interpret( context );
        }
    }
}
