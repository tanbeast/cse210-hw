public class EternalGoal : Goal{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent(){
        return GetGoalPoints();
    }

    public override bool IsCompleted() => false;  
    // Eternal goals can never be completed
    public override string GetStringRepresentation(){
       return $"EternalGoal: {GetGoalName()},{GetGoalDescription()}";
    }
}
 