using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class QuotientRemainder
    {
        public void quotientRemainder()
        {
            int dividend = 60, divisor = 5;
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Execution of Program :\n1]QuotientRemainder\n ");
            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
