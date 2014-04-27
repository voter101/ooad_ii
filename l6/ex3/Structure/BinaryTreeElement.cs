using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3 {
    public class BinaryTreeElement {

        public readonly int Value;
        public readonly BinaryTreeElement LeftNode;
        public readonly BinaryTreeElement RightNode;

        public BinaryTreeElement(BinaryTreeElement leftNode, BinaryTreeElement rightNode, int value) {
            this.LeftNode = leftNode;
            this.RightNode = rightNode;
            this.Value = value;
        }
    }
}
