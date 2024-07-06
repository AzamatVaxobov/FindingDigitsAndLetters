namespace FindingDigitsAndLetters.Services;

public class FindingLetterAndDigitService
{
    int counterLetters;
    int counterDigits;

    public int CounterLetters(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (char.IsLetter(ch))
            {
                ++counterLetters;
            }
        }
        Console.WriteLine($"Number of Letters : {counterLetters}");
        return counterLetters;
    }
    public int CounterDigits(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            char ch = str[i];
            if (char.IsDigit(ch))
            {
                ++counterDigits;
            }
        }
        Console.WriteLine($"Number of Digits : { counterDigits}");
        return counterDigits;
    }
}
