﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    public class LargeNumber
    {
        public void Biggest()
        {
            int a = 70;
            int b = 290;
            int c = 125;

            Console.WriteLine("The numbers is  a = {0}, b = {1}, c = {2}", a, b, c);
            if ((a > b) && (a > c))
                Console.WriteLine("a = {0} is the biggest number", a);

            if (b > c)
                Console.WriteLine("b = {0} is the biggest number", b);

            else
                Console.WriteLine("c = {0} is the biggest number", c);
            Console.ReadLine();
        }
    }
}
