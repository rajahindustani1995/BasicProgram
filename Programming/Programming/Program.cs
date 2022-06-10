using Programming;

Console.WriteLine("Enter a Number for Relative Problem.\n");
Console.WriteLine("1 for Flip Coin and Print Percentage of Heads and Tails");
Console.WriteLine("2 for Leep Year");
Console.WriteLine("3 for Power of 2");
Console.WriteLine("4 for Harmonic Number");
Console.WriteLine("5 for Factors");
Console.WriteLine("6 for Compute Quotient and Remainder");
Console.WriteLine("7 for Swap Two Numbers");
Console.WriteLine("8 for Check Whether a Number is Even or Odd");
Console.WriteLine("9 for Check Whether an Alphabet is Vowel or Consonant");

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
    case 4:
        HarmonicNumber harmonicNumber = new HarmonicNumber();
        harmonicNumber.Harmonic_Number();   
        break;
    case 5:
        Factors factors = new Factors(); 
        factors.PrimeFactors();
        break;
    case 6:
        QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
        quotientAndRemainder.QuotientRemainder();
        break;
    case 7:
        SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();   
        swapTwoNumbers.SwapNumb();
        break;
    case 8:
        EvenOrOdd evenOrOdd = new EvenOrOdd();
        evenOrOdd.Check();
        break;
    case 9:
        VowelOrConsonant vowelOrConsonant = new VowelOrConsonant();
        vowelOrConsonant.Vowel_Consonant();
        break;
    default:
        Console.WriteLine("Invalid Option");
        break;
}