﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Enter 1. to  print String Replace \n");
            bool flag = true;
            while (flag)
            {
                int check = Convert.ToInt32(Console.ReadLine());
                switch (check)
                {
                    case 1:
                        StringReplace sr = new StringReplace();
                        sr.Replace("Gopal");
                        break;
                }
            }

        }
    }
}
