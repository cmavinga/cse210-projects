using System;

class ChecklistGoal : Goal
{
    private int _numberCompleted;
    private int _targetCount;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonus)
        : base(name, description, points)
    {
        _numberCompleted = 0;
        _targetCount = targetCount;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _numberCompleted++;
    }

    public override bool IsCompleted() => _numberCompleted >= _targetCount;

    public override string GetDetailsString()
    {
        return $"{_name} ({_description}) - {_points} points each, " +
               $"Completed {_numberCompleted}/{_targetCount}, Bonus {_bonus}";
    }

    public override string GetStringRepresentation()
    {
        return $"{_name},{_description},{_points},{_numberCompleted},{_targetCount},{_bonus}";
    }
    public int GetBonus() => _bonus;
}