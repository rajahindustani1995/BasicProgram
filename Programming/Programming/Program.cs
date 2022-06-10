
using Programming;

Console.WriteLine("Enter a Number for Relative Problem.\n");
Console.WriteLine("1 for Flip Coin and Print Percentage of Heads and Tails");
Console.WriteLine("2 for Leep Year");
Console.WriteLine("3 for Power of 2");


int Problem = Convert.ToInt32(Console.ReadLine());

switch (Problem)
{
    case 1:
        FlipCoin flipCoin = new FlipCoin();
        flipCoin.Coin();
        break;

    case 2:
        LeapYear leapYear = new LeapYear();
        leapYear.Leap_Year();
        break;
    case 3:
        PowerOfTwo powerOfTwo = new PowerOfTwo();
        powerOfTwo.Power();
        break;
    default:
        Console.WriteLine("Invalid Option");
        break;
}