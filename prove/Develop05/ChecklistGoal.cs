public class ChecklistGoal : Goal{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int goalCount)
        : base(name, description, points){
        _target = goalCount;
        _bonus = 0;
        _timesCompleted = 0;
    }
 
    public ChecklistGoal(string name, string description, int points, int goalCount, int bonus)
        : base(name, description, points){
        _target = goalCount;
        _bonus = bonus;
        _timesCompleted = 0;
    }

    public override void RecordEvent(){
        if (_timesCompleted < _target){
            _timesCompleted++;
            Console.WriteLine($"Goal {_name} recorded! You've earned {_points} points.");

            // If goal is completed, add bonus
            if (_timesCompleted == _target){
                Console.WriteLine($"Congratulations! You've completed the goal. Bonus of {_bonus} points awarded.");
            }
        }
        else{
            Console.WriteLine($"Goal {_name} is already completed.");
        }
    }

    public override bool IsCompleted() => _timesCompleted >= _target;

    public override string GetDetailsString(){
       string completionStatus = _timesCompleted >= _target ? "[X]" : "[ ]";
        return $"{completionStatus} {_name}: {_description} - Completed {_timesCompleted}/{_target} times";
    }
    public override string GetStringRepresentation(){
        return $"ChecklistGoal: {GetGoalName()},{GetGoalDescription()},{_target},{_timesCompleted}";
    }
    public void SetAmountCompleted(int amount){
        _timesCompleted = amount;
    }
}
