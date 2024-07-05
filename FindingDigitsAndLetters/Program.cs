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
        while (true)
        {
            FindingLetterAndDigit findingDigitAndLetter = new FindingLetterAndDigit();
            Console.Write("Enter string :");
            string a = Console.ReadLine();
            findingDigitAndLetter.CounterLetters(a);
            findingDigitAndLetter.CounterDigits(a);
            string option;
            Console.Write("Do you want to continue   Y/N :");
            option = Console.ReadLine();
            string[] options = { "Yes", "Y", "yes", "YES", "y" };
            bool check = options.Any(o => o == option);
            if (!check) break;
        }
    }
}
