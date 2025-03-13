public class SimpleGoal : Goal{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points){
        _isCompleted = false;
    }

    public override void RecordEvent(){
        if (!_isCompleted){
            _isCompleted = true;
            Console.WriteLine($"Goal {_name} completed! You've earned {_points} points.");
        }
        else{ 
            Console.WriteLine($"Goal {_name} has already been completed.");
        }
    }

    public override bool IsCompleted() => _isCompleted;

    public override string GetStringRepresentation(){
        return $"SimpleGoal: {GetGoalName()},{GetGoalDescription()},{_isCompleted}";
    }


}
