public abstract class Book
{

    private string _title;
    private string _genre;
    private int _pages;

    public string Title{
        get { return _title; }
        set { _title = value; }  
    }
    public string Genre{
        get { return _genre; }
        set { _genre = value; }  
    }
    public int Pages{
        get { return _pages; }
        set { _pages = value; }
    }

    public Book(string _title, string _genre, int _pages){
        Title = _title;
        Genre = _genre;
        Pages = _pages;
    }

    public abstract void DisplayInfo();
}
