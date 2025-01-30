using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool exit = false;

        Console.WriteLine("Welcome to your daily Journal.");
        while (!exit)
        {
            Console.Write("PLease select one of the following choices:\n1. Write \n2. Display \n3. Load \n4.Save \n5.Quit \n\n");
            Console.Write("Your choice number: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice) 
            {
                case 1:
                    journal.AddEntry();
                    break;
                case 2:
                    journal.DisplayAll();
                    break;
                case 3:
                    journal.LoadFromFile();
                    break;
                case 4:
                    journal.SaveToFile();
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Sorry, invalid choice. Please try again.");
                    break;
            }
        }

        Console.WriteLine("\nCheers, catch-up later! \n");
    }
}