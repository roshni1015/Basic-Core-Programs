using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Largestnumber
    {
        public void largenumber()
        {
            int n1, n2, n3;
            Console.WriteLine("*********Find the largest of three numbers**********");
            Console.WriteLine("Enter the 1st number n1 :");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  2nd number n2:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 3rd  number n3 :");
            n3 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2 && n1 > n3)
            {

                Console.WriteLine("n1 is the greatest among three");
            }
            else if (n2 > n1 && n2 > n3)
            {
                Console.WriteLine("n2 is the greatest among three");
            }
            else
            {
                Console.WriteLine("n3 is the greatest among three");

            }

        }
    }
}
