using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Harmonicseries
    {
        public void HarmonicSeries()
        {
            int i, s;
            int n = 0;
            Console.WriteLine("Enter value of N : ");
            s = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= s; i++)
            {
                Console.Write(" 1/{0}+", i);
                s += 1 / i;
            }
            Console.WriteLine("\nSum of Series upto {0} terms : {1} ", n, s);
        }
    }
}
