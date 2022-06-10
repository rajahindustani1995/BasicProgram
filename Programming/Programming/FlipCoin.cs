using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming
{
    internal class FlipCoin
    {
        public void Coin()
        {
            int Heads = 0;
            int Tails = 0;

            Console.Write("Enter the Number of Flips to the Coin :");
            int Flips= Convert.ToInt32(Console.ReadLine());

            while (Flips <= 0)
            {
                Console.WriteLine("Invalid Input, Please Enter Number Greater than 0. ");
                Console.Write("Please Enter Number of Flips Again :");
                Flips = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < Flips; i++)
            {
                Random coin = new Random();
                int flip = coin.Next(0, 2);

                if (flip < 0.5)
                {
                    Heads++;
                }
                else
                {
                    Tails++;  
                }

            }

            float Head_Percent = (float)Heads * 100 / Flips;
            float Tail_Percent = (float)Tails * 100 / Flips;

            Console.WriteLine("Percentage of Heads = " + Head_Percent + "%");
            Console.WriteLine("Percentage of Tails = " + Tail_Percent + "%");
        }
    }
}
