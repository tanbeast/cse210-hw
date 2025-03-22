using System;
using System.Collections.Generic;
using System.IO;

public class BookTracker
{
    private List<Book> _readBooks = new List<Book>();
    private List<Book> _toReadBooks = new List<Book>();
    private const string FilePath = "my books.txt";
    private readonly List<string> _validGenres = new List<string> { "Fantasy", "SelfHelp", "History", "Romance", "Folklore" };

    public BookTracker(){
        LoadData();
    }

    public void AddReadBook(string title, string genre, int pages){
        if (!_validGenres.Contains(genre)){
            Console.WriteLine("Invalid genre.");
            return;
        }
        var newBook = new ReadBook(title, genre, pages);
        _readBooks.Add(newBook);
        SaveData();
        Console.WriteLine($"Added '{title}' to read books.");
    }

    public void AddToReadBook(string title, string genre, int pages){
        if (!_validGenres.Contains(genre)){
            Console.WriteLine("Invalid genre.");
            return;
        }
        var newBook = new ToReadBook(title, genre, pages);
        _toReadBooks.Add(newBook);
        SaveData();
        Console.WriteLine($"Added '{title}' to books to read.");
    }

    public void ShowLibrary(){
        if (_readBooks.Count == 0){
            Console.WriteLine("No books read yet.");
            return;
        }
        Console.WriteLine("Books I Have Read:");
        foreach (var book in _readBooks){
            book.DisplayInfo();
        }
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

    private void SaveData(){
        List<string> lines = new List<string>();

        foreach (var book in _readBooks){
            lines.Add($"ReadBook,{book.Title},{book.Genre},{book.Pages}");
        }
        foreach (var book in _toReadBooks){
            lines.Add($"ToReadBook,{book.Title},{book.Genre},{book.Pages}");
        }

        File.WriteAllLines(FilePath, lines);
    }

    private void LoadData(){
        if (File.Exists(FilePath)){
            var lines = File.ReadAllLines(FilePath);

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
