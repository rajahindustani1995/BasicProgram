
using Programming;

Console.WriteLine("Enter a Number for Relative Problem.\n");
Console.WriteLine("1 for Flip Coin and Print Percentage of Heads and Tails");


int Problem = Convert.ToInt32(Console.ReadLine());

switch (Problem)
{
    case 1:
        FlipCoin flipCoin = new FlipCoin();
        flipCoin.Coin();
        break;
}