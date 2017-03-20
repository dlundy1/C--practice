using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deon_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Deon. What year were you born?");
            var year = Console.ReadLine();
            Console.WriteLine("Your age is " + (2016 - Int32.Parse(year)));
            Console.Read();
        }
    }
}
