public class SimpleGoal : Goal{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points){
        _isCompleted = false;
    }

    public override int RecordEvent(){
        if (!_isCompleted){
            _isCompleted = true;
            Console.WriteLine($"Goal {_name} completed! You've earned {_points} points.");
            return GetGoalPoints();
        }
        else{ 
            Console.WriteLine($"Goal {_name} has already been completed.");
            return GetGoalPoints();
        }
    }

    public override bool IsCompleted() => _isCompleted;

    public override string GetStringRepresentation(){
        return $"SimpleGoal: {GetGoalName()},{GetGoalDescription()},{_isCompleted}";
    }


}
