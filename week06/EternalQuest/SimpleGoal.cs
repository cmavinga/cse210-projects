using System;

class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)
    {
        _isCompleted = false;
    }

    public override void RecordEvent()
    {
        _isCompleted = true;
    }

    public override bool IsCompleted() => _isCompleted;

    public override string GetStringRepresentation()
    {
        return $"{_name},{_description},{_points},{_isCompleted}";
    }
}