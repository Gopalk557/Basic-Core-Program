using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LargeNumber large = new LargeNumber();
            large.Biggest();
            Console.ReadKey();

        }
    }
}
