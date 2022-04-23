using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programming
{
    internal class swapingnumber
    {
        public void swap()
        {
            int a, b;
            Console.WriteLine("Enter the number a :");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number b :");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Before swaping");
            Console.WriteLine("a =" + a);
            Console.WriteLine("b =" + b);

            Console.WriteLine("After swaping");
            Console.WriteLine("a =" + b);
            Console.WriteLine("b =" + a);


        }
    }
}