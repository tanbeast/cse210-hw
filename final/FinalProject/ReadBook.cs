public class ReadBook : Book
{
    public ReadBook(string title, string genre, int pages) : base(title, genre, pages) { }

    public override void DisplayInfo(){
        Console.WriteLine($"Read Book - Title: {Title}| Genre: {Genre}| Pages: {Pages}");
    }
}
