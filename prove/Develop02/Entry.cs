
public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _mood;

    public Entry()
    {
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Day was {_mood}/10  - Prompt: {_promptText} \n {_entryText} \n");
    }
}