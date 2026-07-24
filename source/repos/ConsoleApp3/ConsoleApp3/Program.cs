using System;
using System.Linq;

public class TaskSolutions
{
    public static int[] MakePositive(int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0)
            {
                numbers[i] = Math.Abs(numbers[i]);
            }
        }
        return numbers;
    }

    public static string Repeat(string word, int count = 1)
    {
        string result = "";
        for (int i = 0; i < count; i++)
        {
            result += word;
        }
        return result;
    }

    public static string RemoveDuplicates(string text)
    {
        string result = "";
        foreach (char c in text)
        {
            if (!result.Contains(c))
            {
                result += c;
            }
        }
        return result;
    }

    public static void PrintWords(string text)
    {
        string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }

    public static void PrintFirstFour(string text)
    {
        if (string.IsNullOrEmpty(text)) return;
        string result = text.Length >= 4 ? text.Substring(0, 4) : text;
        Console.WriteLine(result);
    }

    public static string GetDomain(string email)
    {
        int atIndex = email.IndexOf('@');
        if (atIndex != -1)
        {
            return email.Substring(atIndex + 1);
        }
        return "";
    }

    public static bool IsOnlyLetters(string text)
    {
        if (string.IsNullOrEmpty(text)) return false;
        foreach (char c in text)
        {
            if (!char.IsLetter(c))
            {
                return false;
            }
        }
        return true;
    }

    public static string FormatSentence(string text)
    {
        if (string.IsNullOrEmpty(text)) return text;
        text = text.ToLower();
        return char.ToUpper(text[0]) + text.Substring(1);
    }

    public static string[] ExtractNames(string[] fullNames)
    {
        string[] names = new string[fullNames.Length];
        for (int i = 0; i < fullNames.Length; i++)
        {
            names[i] = fullNames[i].Trim().Split(' ')[0];
        }
        return names;
    }

    static void Main()
    {
    }
}