using System;
using System.Collections.Generic;

abstract class Activity
{
    private DateTime date;
    private int duration;

    public Activity(DateTime date, int duration)
    {
        this.date = date;
        this.duration = duration;
    }

    public DateTime Date => date;
    public int Duration => duration;

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{Date:dd MMM yyyy} {this.GetType().Name} ({Duration} min): " +
               $"Distance {GetDistance():0.00} km, " +
               $"Speed {GetSpeed():0.00} kph, " +
               $"Pace {GetPace():0.00} min per km";
    }
}