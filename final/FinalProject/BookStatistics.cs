class BookStatistics
{
    public static void ShowStatistics(List<Book> books)
    {
        Console.WriteLine($"Total Books: {books.Count}");
        int totalPages = 0;
        foreach (var book in books)
        {
            totalPages += book.Pages;
        }
        Console.WriteLine($"Total Pages Read: {totalPages}");
    }
}