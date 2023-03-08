using System;
using System.Collections.Generic;

// Define the base class for all activities
public abstract class Activity
{
    // Fields
    private string name;
    private int pointValue;

    // Properties
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int PointValue
    {
        get { return pointValue; }
        set { pointValue = value; }
    }

    // Constructor
    public Activity(string name, int pointValue)
    {
        this.name = name;
        this.pointValue = pointValue;
    }

    // Abstract method for recording an event
    public abstract void RecordEvent();

    // Virtual method for displaying progress
    public virtual string DisplayProgress()
    {
        return $"Activity: {name}, Points: {pointValue}";
    }
}

// Define a class for simple goals
public class SimpleGoal : Activity
{
    // Fields
    private bool isCompleted;

    // Constructor
    public SimpleGoal(string name, int pointValue) : base(name, pointValue)
    {
        this.isCompleted = false;
    }

    // Method for recording an event
    public override void RecordEvent()
    {
        if (!isCompleted)
        {
            PointValue += 1000;
            isCompleted = true;
        }
    }

    // Override method for displaying progress
    public override string DisplayProgress()
    {
        string completionStatus = isCompleted ? "[x]" : "[ ]";
        return $"{completionStatus} Activity: {Name}, Points: {PointValue}";
    }
}

// Define a class for eternal goals
public class EternalGoal : Activity
{
    // Constructor
    public EternalGoal(string name, int pointValue) : base(name, pointValue) {}

    // Method for recording an event
    public override void RecordEvent()
    {
        PointValue += 100;
    }
}

// Define a class for checklist goals
public class ChecklistGoal : Activity
{
    // Fields
    private int numTimesCompleted;
    private int numTimesRequired;

    // Constructor
    public ChecklistGoal(string name, int pointValue, int numTimesRequired) : base(name, pointValue)
    {
        this.numTimesCompleted = 0;
        this.numTimesRequired = numTimesRequired;
    }

    // Method for recording an event
    public override void RecordEvent()
    {
        PointValue += 50;
        numTimesCompleted++;
        if (numTimesCompleted == numTimesRequired)
        {
            PointValue += 500;
        }
    }

    // Override method for displaying progress
    public override string DisplayProgress()
    {
        return $"Activity: {Name}, Points: {PointValue}, Completed: {numTimesCompleted}/{numTimesRequired}";
    }
}

