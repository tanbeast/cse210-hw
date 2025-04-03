class GenreValidator
{
    private static readonly List<string> validGenres = new List<string> { "Fantasy", "SelfHelp", "History", "Romance", "Folklore" };
    
    public static bool IsValidGenre(string genre)
    {
        return validGenres.Contains(genre);
    }

    public static List<string> GetGenres()
    {
        return validGenres;
    }
}