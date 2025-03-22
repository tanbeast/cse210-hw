using System;

class Program
{
    static void Main()
    {
        BookTracker tracker = new BookTracker();
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Enter a book I have read");
            Console.WriteLine("2. Enter a book I want to read");
            Console.WriteLine("3. Show my library of read books");
            Console.WriteLine("4. Get a book suggestion");
            Console.WriteLine("5. Exit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                case "2":
                    Console.Write("Enter book title: ");
                    string title = Console.ReadLine();

                    Console.WriteLine("Choose a genre:");
                    List<string> genres = new List<string> { "Fantasy", "SelfHelp", "History", "Romance", "Folklore" };
                    for (int i = 0; i < genres.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {genres[i]}");
                    }
                    Console.Write("Enter genre number: ");
                    if (!int.TryParse(Console.ReadLine(), out int genreIndex) || genreIndex < 1 || genreIndex > genres.Count)
                    {
                        Console.WriteLine("Invalid genre choice.");
                        continue;
                    }
                    string genreChoice = genres[genreIndex - 1];

                    Console.Write("Enter number of pages: ");
                    if (!int.TryParse(Console.ReadLine(), out int pages) || pages <= 0)
                    {
                        Console.WriteLine("Invalid page number.");
                        continue;
                    }

                    if (choice == "1")
                        tracker.AddReadBook(title, genreChoice, pages);
                    else
                        tracker.AddToReadBook(title, genreChoice, pages);
                    break;
                case "3":
                    tracker.ShowLibrary();
                    break;
                case "4":
                    tracker.SuggestBook();
                    break;
                case "5":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
