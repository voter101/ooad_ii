using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2 {
    public class Alternative : AbstractBinaryOperator {
        public override bool Interpret(Context context, AbstractExpression left, AbstractExpression right) {
            return left.Interpret(context) || right.Interpret(context);
        }
    }
}
