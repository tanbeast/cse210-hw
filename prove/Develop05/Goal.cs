using System;

public abstract class Goal{
    public string _name { get; set; }
    public string _description { get; set; }
    public int _points { get; set; }
    public Goal(string name, string description, int points){
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();
    public abstract bool IsCompleted();
    public abstract string GetStringRepresentation();
    public virtual string GetDetailsString(){
        if (IsCompleted()){
            return $"[X] {_name} ({_description})";
        }
        return $"[ ] {_name} ({_description})";
    }
    public string GetGoalName(){
        return _name;
    }
    public string GetGoalDescription(){
        return _description;
    }

}
