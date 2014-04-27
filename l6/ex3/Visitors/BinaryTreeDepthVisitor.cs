using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3 {
    class BinaryTreeDepthVisitor {
        public int GetDepth(BinaryTree tree) {
            return getElementDepth(tree.Root);
        }

        public int getElementDepth(BinaryTreeElement element) {
            if ( element == null ) {
                return 0;
            }
            if ( element.LeftNode == null && element.RightNode == null ) {
                return 1;
            }
            return 1 + Math.Max(getElementDepth(element.LeftNode), getElementDepth(element.RightNode)) ;
        }
    }
}