using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace even_or_odd_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            if (n%2== 0)
            {

                Console.WriteLine(n + " =is even number");
            }
            else
            {
                Console.WriteLine(n + "=  is odd numeber");
            }
        }
    }
}
