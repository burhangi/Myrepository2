using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positive_or_negative_number
{
    internal class Program
    {
        static void Main( string[] args)
        {
            int n;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
             if(n > 0)
            {

                Console.WriteLine(n+" =is positive");
            }
            else
            {
                Console.WriteLine(n+"=  is negative");
            }
        }
    }
}
