using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        Console.Write("What is your first name? ");
        string firstName = textInfo.ToTitleCase(Console.ReadLine());

        Console.Write("What is your last name? ");
        string lastName = textInfo.ToTitleCase(Console.ReadLine());

        Console.Write($"\nYour name is {lastName}, {firstName} {lastName}.");
    }
}