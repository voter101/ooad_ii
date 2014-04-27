using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2 {
    public class Context {

        private Dictionary<String, bool> dict = new Dictionary<String, bool>();

        public bool GetValue(string VariableName) {
            try {
                return dict[VariableName];
            } catch ( KeyNotFoundException e ) {
                throw new VariableNotSetInContextException(null, e);
            }
        }

        public void SetValue(string VariableName, bool Value) {
            dict[VariableName] = Value;
        }

    }
}
