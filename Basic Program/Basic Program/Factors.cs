using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Factors
    {
        public void factors()
        {
            int n, i;
            Console.WriteLine("Enter the Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factors:", a);
            for (i = 1; i <= a; i++)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
