public class GoalManager
{
    private  List<Goal> _goals = new List<Goal>();
    private  int _score = 0;
    private int  _level = 1;
    private int _goalsCompleted = 0;
    double  _levelup = 5;

    public void Start()
    {
         Console.WriteLine("Goal Tracker Program");

        // Main menu loop
        while (true){
            LevelCheckUpgrade();
            Console.WriteLine($"\nYou are in level {_level} with {_score} points.");
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
                    Console.Clear();
                    CreateGoal();
                    break;
                case "2":
                    Console.Clear();
                    ListGoals();
                    break;
                case "3":
                    Console.Clear();
                    SaveGoals();
                    break;
                case "4":
                    Console.Clear();
                    LoadGoals();
                    break;
                case "5":
                    Console.Clear();
                    RecordEvent();
                    break;
                case "6":
                    Console.WriteLine("Exiting program...");
                    return;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
       
    }
    public  void CreateGoal(){
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
    public  void ListGoals(){
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
    public  void SaveGoals(){
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
    public void LoadGoals(){
        Console.Write("Name of the file you want to load? ");
        string fileName = Console.ReadLine();
        if (!File.Exists(fileName))
        {
            Console.WriteLine("No such file name");
            return;
        }

        using (StreamReader reader = new StreamReader(fileName))
        {
            _score = int.Parse(reader.ReadLine());
            string line;
            while ((line = reader.ReadLine()) != null)
            {   
                string[] lineArray = line.Split(':');
                string goalType = lineArray[0].Trim();

                string[] goalDetails = lineArray[1].Split(',');
                string name = goalDetails[0].Trim();
                string description = goalDetails[1].Trim();
                int.TryParse(goalDetails[2], out int points);

                switch (goalType)
                {
                    case "SimpleGoal":
                        SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                        if (goalDetails[2].Trim() == "True")
                        {
                            simpleGoal.IsCompleted();
                        }
                        _goals.Add(simpleGoal);
                        break;
                    case "EternalGoal":
                        EternalGoal eternalGoal = new EternalGoal(name, description, points);
                        _goals.Add(eternalGoal);
                        break;
                    case "ChecklistGoal":
                        // int.TryParse(goalDetails[3], out int bonus);
                        int.TryParse(goalDetails[2], out int target);
                        int.TryParse(goalDetails[3], out int amountCompleted);

                        ChecklistGoal checklistGoal = new ChecklistGoal(name, description,points, target);
                        checklistGoal.SetAmountCompleted(amountCompleted);
                        _goals.Add(checklistGoal);
                        break;
                }
            }
        }

    }
    public  void ListGoalNames()
    {
        Console.WriteLine("\nThe goals are:");
        int index = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{index}. {goal.GetGoalName()}");
            index++;
        }
    }
    public void RecordEvent(){
        if (_goals.Count > 0)
        {
            ListGoalNames();
            Console.Write("Which goal did you accomplish? ");
            int.TryParse(Console.ReadLine(), out int index);

            Goal goal = _goals[index-1];
            int earned = goal.RecordEvent();
            _score = _score + earned;
            Console.WriteLine($"\nCongratulations! You have earned {earned} points!");
            
            Console.WriteLine($"You now have {_score} points!");

            int levelBefore = _level;
            LevelCheckUpgrade();
            if (_level > levelBefore)
            {
                _score += 20;
                Console.WriteLine($"\nCongratulations, you have entered a NEW LEVEL and received 20 bonus points");
                
            }
        } 
        else
        {
            Console.WriteLine($"It appears you have no goals yet.");
        }
    }
    public void LevelCheckUpgrade()
    {
        while (_goalsCompleted > _levelup)
        {
            for (int i=1; i<=_level; i++)
            {
                _levelup *= 1.5;
            }
            _level++;
        }
    }
    
}