using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2 {
    public class ConstToken : AbstractToken {

        private bool value;

        public ConstToken(bool value) {
            this.value = value;
        }

        public override bool Interpret(Context context) {
            return value;
        }
    }
}
