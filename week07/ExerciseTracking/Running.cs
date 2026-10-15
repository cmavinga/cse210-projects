using System;
using System.Collections.Generic;
class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int duration, double distance)
        : base(date, duration)
    {
        this._distance = distance;
    }

    public override double GetDistance() => _distance;
    public override double GetSpeed() => (_distance / Duration) * 60;
    public override double GetPace() => Duration / _distance;
}