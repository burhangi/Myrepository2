using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maximum_of_three_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter three number");
            Console.WriteLine("Enter a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter B");
            b= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter ");
            c = int.Parse(Console.ReadLine());
            if(a>b & a>c)
            {
                Console.WriteLine("a is greate number ");
            }
             else if (b > a & b > c)
            {
                Console.WriteLine("b is greater number");
            }
            else if(c > a & c > b)
            {
                Console.WriteLine("c is greater number");
            }

        }
    }
}
