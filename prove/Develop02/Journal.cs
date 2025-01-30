
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public string _fileName;

    public Journal()
    {
    }

    public void AddEntry()
    {
        Entry entry = new Entry();
        
        PromptGenerator prompts = new PromptGenerator();
        entry._promptText = prompts.GetRandomPrompt();

        Console.WriteLine($"{entry._promptText}");
        Console.Write("> ");
        entry._entryText = Console.ReadLine();

        Console.WriteLine("\non a scale of 1-10 how was your day?");
        Console.Write("> ");
        entry._mood = Console.ReadLine();

        DateTime currentTime = DateTime.Now;
        entry._date = currentTime.ToShortDateString();

        _entries.Add(entry);

        Console.WriteLine("Entry added successfully. \n");

    }
    public void DisplayAll()
    {
        if (_entries.Count != 0) 
        {
           foreach (Entry entry in _entries) 
           {
            entry.Display();
           }
        } else
        {
            Console.WriteLine("No entries to show. Add a new entry or load from file.");
        }

    }
    public void SaveToFile()
    {
        if (_entries.Count != 0) 
        {
            Console.Write("Enter journal name: ");
            _fileName = Console.ReadLine()+".csv";
            using (StreamWriter newFile = new StreamWriter(_fileName))
            {
                foreach (Entry entry in _entries) 
                {
                    newFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText},{entry._mood}");
                }
            }
            Console.WriteLine("Journal saved successfully! \n");

        } else
        {
            Console.WriteLine("No entries to save. Add a new entry before saving.");
        }
    }
    public void LoadFromFile()
    {
        Console.WriteLine("Enter journal name to load");
        Console.Write("Name: ");
        _fileName = Console.ReadLine()+".csv";

        if (!File.Exists(_fileName))
        {
            Console.WriteLine("Journal not found");
            return;
        }

        else using (StreamReader reader = new StreamReader(_fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string [] parts = line.Split(',');
                if (parts.Length == 4)
                {
                    Entry entry = new Entry();
                    entry._date = parts[0];
                    entry._promptText = parts[1];
                    entry._entryText = parts[2];
                    entry._mood = parts[3];
                    _entries.Add(entry);
                }
            }
        }
        Console.WriteLine("Journal loaded successfully");

    }
}