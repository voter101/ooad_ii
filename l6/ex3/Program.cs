using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z3 {
    class Program {
        static void Main(string[] args) {
            BinaryTreeElement elem_left = new BinaryTreeElement( 
                null, 
                new BinaryTreeElement(
                    null, 
                    new BinaryTreeElement(
                        null, 
                        new BinaryTreeElement(
                            new BinaryTreeElement(
                                null, 
                                null, 
                                8), 
                            null, 
                            22), 
                        33), 
                    18 ), 
                1);
            BinaryTreeElement elem_right = new BinaryTreeElement( null, null, 9);
            BinaryTreeElement elem_root = new BinaryTreeElement( elem_left, elem_right, 1);

            BinaryTree tree = new BinaryTree( elem_root );

            BinaryTreeSumVisitor sum = new BinaryTreeSumVisitor();
            BinaryTreeDepthVisitor depth = new BinaryTreeDepthVisitor();

            Console.WriteLine( sum.GetSum( tree ) );
            Console.WriteLine( depth.GetDepth( tree ) );
            Console.ReadKey();
        }
    }
}
