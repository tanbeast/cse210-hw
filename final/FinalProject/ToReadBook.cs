class ToReadBook : Book{
    public ToReadBook(string title, string genre, int pages) : base(title, genre ) { }

    public override void DisplayInfo(){
        Console.WriteLine($"To Read Book - Title: {Title}, Genre: {Genre}");
    }
}
