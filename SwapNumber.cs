using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    public class EvenOdd
    {
        public static void EvenOddNum()
        {
            Console.WriteLine("Enter the Number ");
            int Num = Convert.ToInt32(Console.ReadLine());

            if (Num % 2 == 0)
            {
                Console.WriteLine("Even number \n", Num);
            }
            else
            {
                Console.WriteLine("Odd Number \n ", Num);
            }
        }
    }
}
