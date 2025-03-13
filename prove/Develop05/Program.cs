using System;

class Program
{
    private static List<Goal> goals = new List<Goal>();
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

    }
    private static void ListGoals(){

    }
    private static void SaveGoals(){

    }
    private static void LoadGoals(){

    }
    private static void RecordEvent(){
        
    }
}