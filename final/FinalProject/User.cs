class User
{
    public string Name { get; private set; }
    public string FilePath => $"{Name}_books.json";

    public User(string name){
        Name = name;
    }
}