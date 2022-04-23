using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Evenodd
    {
        public void evenodd()
        {
            int num;
            Console.WriteLine("Enter the number:");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("{0} is even", num);
            }
            else
            {
                Console.WriteLine("{0} is odd", num);
            }

        }

    }
}
