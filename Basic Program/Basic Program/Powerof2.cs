using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Program
{
    internal class Powerof2
    {
        public void powerof2()
        {
            Console.WriteLine("Power of Two");
            Console.WriteLine("Enter the value of N : ");
            int N = Convert.ToInt16(Console.ReadLine());
            for (int j = 0; j < N; j++)
            {
                int n;
                n = (int)Math.Pow(2, j);
                Console.WriteLine("2 power of {0} is {1} ", j, n);
            }
        }
    }
}

