using System;

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) { }

    public override void RecordEvent()
    {
        // Eternal goal still award points, even though they never complete!
    }

    public override bool IsCompleted() => false;

    public override string GetStringRepresentation()
    {
        return $"{_name},{_description},{_points},Eternal";
    }
}