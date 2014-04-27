using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3 {
    class BinaryTreeSumVisitor {

        public int GetSum(BinaryTree tree) {
            return getSumFromElement(tree.Root);
        }

        private int getSumFromElement(BinaryTreeElement element) {
            if ( element == null ) {
                return 0;
            }
            return element.Value + getSumFromElement( element.LeftNode ) + getSumFromElement( element.RightNode );
        }

    }
}
