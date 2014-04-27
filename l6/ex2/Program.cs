using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z2 {
    class Program {
        static void Main(string[] args) {
            Context ctx = new Context();
            ctx.SetValue( "x", true );
            ctx.SetValue( "y", false );

            AbstractExpression left = new UnaryExpression(new ConstExpression(new ConstToken(false)), new Negation()); 
            AbstractExpression right_x = new ConstExpression(new VariableToken("x"));
            AbstractExpression right_y = new ConstExpression(new VariableToken("y"));
            AbstractExpression expr = new BinaryExpression( left, right_x, new Conjunction() );
            AbstractExpression expr2 = new BinaryExpression( left, right_y, new Conjunction() );
            AbstractExpression expr3 = new BinaryExpression( left, right_y, new Alternative() );
            
            Console.WriteLine(expr.Interpret(ctx));
            Console.WriteLine(expr2.Interpret(ctx));
            Console.WriteLine(expr3.Interpret(ctx));
            Console.ReadKey();
        }
    }
}
