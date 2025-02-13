using System;
using System.ComponentModel;
using System.Linq.Expressions;
using Microsoft.Win32.SafeHandles;

class Program{
    static void Main(string[] args)
    {   
        while(true){
        Console.Write("Please enter the scripture to memorize");
        var thing = Console.ReadLine();
        switch(thing){
            case "1":
                Reference reference = new Reference("Proverbs", 3, 5, 6);
                string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
                Scripture scripture = new Scripture(reference, scriptureText);
                break;
            case "2":
                Reference reference = new Reference("Proverbs", 6, 5, 6);
                string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
                Scripture scripture = new Scripture(reference, scriptureText);
                break;
            case "3":
                return;

        }


        

        Console.Clear();
        Console . WriteLine("your chosen scripture:");
        scripture.Display();

        while (true)
        {
            Console.WriteLine("\nPress Enter to hide more words or type 'back' to return to menu:");
            string userInput = Console.ReadLine().Trim().ToLower();

            if (userInput == "back"){
                break;
            }
            scripture.HideRandomWords();
            Console.Clear();
            scripture.Display();

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden! You've completed the scripture memorization.");
                break;  
            }
        }}
    }
}