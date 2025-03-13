using System;

public abstract class Goal{
    public string Name { get; set; }
    public string Description { get; set; }
    public int Points { get; set; }
    public Goal(string name, string description, int points){
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsCompleted();
    public abstract void DisplayGoalStatus();

}
