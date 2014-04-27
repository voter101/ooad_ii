using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2 {
    class UnaryExpression : AbstractExpression {

        private AbstractExpression expression;
        private AbstractUnaryOperator unaryOperator;

        public UnaryExpression(AbstractExpression expression, AbstractUnaryOperator unaryOperator) {
            this.expression = expression;
            this.unaryOperator = unaryOperator;
        }

        public override bool Interpret(Context context) {
            return unaryOperator.Interpret( context, expression );
        }
    }
}
