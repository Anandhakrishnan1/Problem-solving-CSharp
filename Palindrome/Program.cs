using System;

public class Program
{
    public static void Main()
    {
        var isPalindrome = false;
        string orginalText = Console.ReadLine().ToLower();
        var length = orginalText.Length;
        for (var i = 0; i < orginalText.Length; i++)
        {
            if (orginalText[i] != orginalText[length - 1])
            {
                break;
            }
            length--;
            isPalindrome = true;
        }
        if (isPalindrome) { Console.WriteLine(orginalText + " is palindrome"); }
        else { Console.WriteLine(orginalText + " is not palindrome"); }
    }
}