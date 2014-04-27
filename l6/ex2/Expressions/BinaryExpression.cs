using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2 {
    public class BinaryExpression : AbstractExpression {

        private AbstractExpression leftExpression;
        private AbstractExpression rightExpression;
        private AbstractBinaryOperator binaryOperator;

        public BinaryExpression(AbstractExpression left, AbstractExpression right, AbstractBinaryOperator binaryOperator) {
            leftExpression = left;
            rightExpression = right;
            this.binaryOperator = binaryOperator;
        }

        public override bool Interpret(Context context) {
            return binaryOperator.Interpret( context, leftExpression, rightExpression );
        }
    }
}
