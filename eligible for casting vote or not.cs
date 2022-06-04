using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace person_eligble_for_casting_vote
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            Console.WriteLine("Enter your age");
            age = int.Parse(Console.ReadLine());
            if(age>=18)
            {
                Console.WriteLine("This person is eligble for casting vote");
            }
            else
            {
                Console.WriteLine(" this pesrson is not eligible for casting vote");
            }
        }
    }
}
