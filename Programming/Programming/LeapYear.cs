using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class LeapYear
    {
        public void Leap_Year()
        {
            Console.WriteLine("Enter The Year : ");
            int Year = Convert.ToInt32(Console.ReadLine()); 

            while(Year < 1000 || Year > 9999)
            {
                Console.WriteLine("Please Enter Four Digit Year : ");
                Year= Convert.ToInt32(Console.ReadLine());  
            }

            if (((Year % 4 == 0)&&(Year % 100 != 0)) || (Year % 400 == 0))
            {
                Console.WriteLine(Year + " is a Leap Year");
            }
            else
            {
                Console.WriteLine(Year + "is not a Leap Year");
            }
        }
    }
}
