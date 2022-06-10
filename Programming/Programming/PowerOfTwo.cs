using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class PowerOfTwo
    {
        public void Power()
        {
            Console.WriteLine("Enter a Number for Power of 2 : ");
            int Number = Convert.ToInt32(Console.ReadLine());

            while (Number < 0 || Number >= 31)
            {
                Console.WriteLine("Please Enter Valid Number : ");
                Number = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
