public class SimpleGoal : Goal{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points){
        _isCompleted = false;
    }

    public override int RecordEvent(){
        if (!_isCompleted){
            _isCompleted = true;
            return GetGoalPoints();
        }
        else{ 
            Console.WriteLine($"Goal {_name} has already been completed.");
            return 0;
        }
    }

    public override bool IsCompleted() => _isCompleted;

    public override string GetStringRepresentation(){
        return $"SimpleGoal: {GetGoalName()},{GetGoalDescription()},{_isCompleted}";
    }


}
