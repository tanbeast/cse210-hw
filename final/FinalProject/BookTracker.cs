using System;
using System.Collections.Generic;

class BookTracker{
    private List<Book> _readBooks = new List<Book>();
    private List<Book> _toReadBooks = new List<Book>();
    private User user;


    public BookTracker(User user){
        this.user = user;
        LoadData();
    }

    public void AddReadBook(string title, string genre, int pages){
        if (!GenreValidator.IsValidGenre(genre)){
            Console.WriteLine("Invalid genre.");
            return;
        }

        _readBooks.Add(new ReadBook(title, genre, pages));
        SaveData("ReadBook", title, genre, pages);
        Console.WriteLine($"Added '{title}' to read books.");
    }

    public void AddToReadBook(string title, string genre, int pages){
        if (!GenreValidator.IsValidGenre(genre)){
            Console.WriteLine("Invalid genre.");
            return;
        }

        _toReadBooks.Add(new ToReadBook(title, genre, pages));
        SaveData("ToReadBook", title, genre, pages);
        Console.WriteLine($"Added '{title}' to books to read.");
    }

    public void ShowLibrary(){
        if (_readBooks.Count == 0){
            Console.WriteLine("No books read yet.");
            return;
        }
        Console.WriteLine("Books Read:");
        foreach (var book in _readBooks){
            book.DisplayInfo();
        }
        BookStatistics.ShowStatistics(_readBooks);
    }

    public void SuggestBook(){
        if (_toReadBooks.Count == 0){
            Console.WriteLine("No books in the 'to read' list.");
            return;
        }
        Random random = new Random();
        Book suggestion = _toReadBooks[random.Next(_toReadBooks.Count)];
        Console.WriteLine("You should read:");
        suggestion.DisplayInfo();
    }

    private void SaveData(string type, string title, string genre, int pages){
        using (StreamWriter writer = new StreamWriter(user.FilePath, true)){
            writer.WriteLine($"{type}|{title}|{genre}|{pages}");
        }
    }

    private void LoadData(){
        if (File.Exists(user.FilePath)){
            var lines = File.ReadAllLines(user.FilePath);

            foreach (var line in lines){
                var parts = line.Split('|');

                if (parts.Length != 4) continue; 

                string type = parts[0];
                string title = parts[1];
                string genre = parts[2];
                int pages = int.Parse(parts[3]);

                if (type == "ReadBook"){
                    _readBooks.Add(new ReadBook(title, genre, pages));
                }
                else if (type == "ToReadBook"){
                    _toReadBooks.Add(new ToReadBook(title, genre, pages));
                }
            }
        }
    }
}
