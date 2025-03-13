using System;

class Program
{
    private static List<Goal> _goals = new List<Goal>();
    private static int _score = 0;
    static void Main(string[] args)
    {
         Console.WriteLine("Goal Tracker Program");

        // Main menu loop
        while (true){
            Console.WriteLine($"Total score: {_score}");
            Console.Write(@"
Menu Options:
    1. Create New Goal
    2. List Goals
    3. Save Goals
    4. Load Goals
    5. Record Goal Accompishment
    6. Quit
Please select a number from the above menu: ");

            var choice = Console.ReadLine();

            switch (choice){
                case "1":
                    CreateGoal();
                    break;
                case "2":
                    ListGoals();
                    break;
                case "3":
                    SaveGoals();
                    break;
                case "4":
                    LoadGoals();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
       
    }
    private static void CreateGoal(){
        int choice = 0;
        Console.WriteLine($"\nThe type of goals are:\n 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");
        while (choice != 1 && choice != 2 && choice != 3)
        {
            Console.Write("Which type of goal would you like to create? ");
            int.TryParse(Console.ReadLine(), out choice);
        }

        Console.Write("What will you call your goal? ");
        string name = Console.ReadLine();
        Console.Write("Provide brief description of your goal: ");
        string description = Console.ReadLine();
        Console.Write("How many points do you want to assign this goal? ");
        int.TryParse(Console.ReadLine(), out int points);

        switch (choice)
        {
            case 1:
                _goals.Add(new SimpleGoal(name, description,points));
                break;
            case 2:
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case 3:
                Console.Write("Enter number of times goal must be completed: ");
                int goalCount = int.Parse(Console.ReadLine());

                Console.Write("How many bouns point will be earned unpon completion (hit enter to skip): ");
                int bonus = int.Parse(Console.ReadLine());

                _goals.Add(new ChecklistGoal(name, description, points, goalCount, bonus));
                break;
        }

    }
    private static void ListGoals(){
        if (_goals.Count > 0)
        {
            foreach(Goal goal in _goals)
            {
                Console.WriteLine($"{goal.GetDetailsString()}");
            }
        } 
        else
        {
            Console.WriteLine($"It appears you have no goals yet.");
        }
    }
    private static void SaveGoals(){
         if (_goals.Count > 0)
        {
            Console.Write("What is the name of the file you want to save in? ");
            string fileName = Console.ReadLine();

            using (StreamWriter newFile = new StreamWriter(fileName))
            {
                newFile.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    newFile.WriteLine($"{goal.GetStringRepresentation()}");   
                }
            }
        } 
        else{
            Console.WriteLine($"It appears you have no goals yet.");
        }
    }
    private static void LoadGoals(){
        

    }
    private static void RecordEvent(){

    }
}