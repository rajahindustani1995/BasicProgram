﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class EvenOrOdd
    {
        public void Check()
        {
            Console.Write("Enter a number to find if it's Even or Odd : ");
            int number = Convert.ToInt32(Console.ReadLine());

            //Even number logic
            if (number % 2 == 0)
            {
                Console.WriteLine("The number " + number + " is even");
            }

            //Otherwise the number is odd
            else
            {
                Console.WriteLine("The number " + number + " is odd");
            }

        }
    }
}
