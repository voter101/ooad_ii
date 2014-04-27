using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2 {
    public class ConstExpression : AbstractExpression {

        private AbstractToken token;

        public ConstExpression(AbstractToken token) {
            this.token = token;
        }

        public override bool Interpret(Context context) {
            return token.Interpret(context);
        }
    }
}
