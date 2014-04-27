using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2 {
    public class VariableNotSetInContextException : Exception {
        public VariableNotSetInContextException() { }
        public VariableNotSetInContextException(string message) : base(message) { }
        public VariableNotSetInContextException(string message, Exception inner) : base(message, inner) { }
    }
}
