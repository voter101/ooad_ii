using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2 {
    public class VariableToken : AbstractToken {

        private string variableName;

        public VariableToken(string variableName) {
            this.variableName = variableName; 
        }

        public override bool Interpret(Context context) {
            return context.GetValue( variableName );
        }
    }
}
