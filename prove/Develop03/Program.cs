using System;

class Program{
    static void Main(string[] args)
    {
        while(true){
            Console.WriteLine("Choose a scripture to memorize:");
            Console.WriteLine("1. Proverbs 3:5-6");
            Console.WriteLine("2. Philippians 4:13");
            Console.WriteLine("3. D&C  121:34");
            Console.WriteLine("4. Quit");
            

            Console.Write("\nEnter the number of your choice: ");
            string input = Console.ReadLine();
            Reference reference;
            string scriptureText;

            switch (input)
            {
                case "1":
                    reference = new Reference("Proverbs", 3, 5, 6);
                    scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding.";
                    break;
                case "2":
                    reference = new Reference("Philippians", 4, 13);
                    scriptureText = "I can do all things through Christ which strengtheneth me.";
                    break;
                case "3":
                    reference = new Reference("D&C", 121, 34);
                    scriptureText = "Behold, there are many called, but few are chosen. And why are they not chosen?.";
                    break;
                default:
                    Console.WriteLine("Invalid choice. Exiting program.");
                    return;
            }

            Scripture scripture = new Scripture(reference, scriptureText);
            Console.Clear();
            Console.WriteLine("your chosen scripture:");
            scripture.Display();

            while (true)
            {
                Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
                string userInput = Console.ReadLine().Trim().ToLower();

                if (userInput == "quit"){
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
            }
        }
    }
}