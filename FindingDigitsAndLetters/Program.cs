using FindingDigitsAndLetters.Services;

namespace FindingDigitsAndLetters;

public class Program
{
    static void Main(string[] args)
    {
        StartProgram();
    }
     static void StartProgram()
    {
        FindingLetterAndDigit findingDigitAndLetter = new FindingLetterAndDigit();
        Console.Write("Enter string :");
        string a = Console.ReadLine();
        findingDigitAndLetter.CounterLetters(a);
        findingDigitAndLetter.CounterDigits(a);
    }

}
