public class EternalGoal : Goal{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent(){
        Console.WriteLine($"Goal {_name} completed! You've earned {_points} points.");
        return GetGoalPoints();
    }

    public override bool IsCompleted() => false;  
    // Eternal goals can never be completed
    public override string GetStringRepresentation(){
       return $"EternalGoal: {GetGoalName()},{GetGoalDescription()}";
    }
}
 