using System;
using System.Collections.Generic;

// Base class for all goals
public abstract class Goal {
    public string Name { get; set; }
    public int PointValue { get; set; }

    // Constructor
    public Goal(string name, int pointValue) {
        Name = name;
        PointValue = pointValue;
    }

    // Abstract method to record progress towards goal
    public abstract void RecordEvent();

    // Override ToString() to display the goal's name and point value
    public override string ToString() {
        return $"{Name} ({PointValue} points)";
    }
}

// Simple goal class
public class SimpleGoal : Goal {
    public bool IsComplete { get; set; }

    // Constructor
    public SimpleGoal(string name, int pointValue) : base(name, pointValue) {
        IsComplete = false;
    }

    // Record that the goal has been completed
    public override void RecordEvent() {
        IsComplete = true;
        Console.WriteLine($"Completed {Name}! You earned {PointValue} points.");
    }

    // Override ToString() to indicate completion status
    public override string ToString() {
        return $"{Name} ({PointValue} points) [{(IsComplete ? "X" : " ")}]";
    }
}

// Eternal goal class
public class EternalGoal : Goal {
    public int TimesCompleted { get; set; }

    // Constructor
    public EternalGoal(string name, int pointValue) : base(name, pointValue) {
        TimesCompleted = 0;
    }

    // Record that the goal has been completed
    public override void RecordEvent() {
        TimesCompleted++;
        Console.WriteLine($"Recorded progress for {Name}! You earned {PointValue} points.");
    }

    // Override ToString() to show number of times completed
    public override string ToString() {
        return $"{Name} ({PointValue} points) [Completed {TimesCompleted} times]";
    }
}

// Checklist goal class
public class ChecklistGoal : Goal {
    public int TargetCount { get; set; }
    public int TimesCompleted { get; set; }

    // Constructor
    public ChecklistGoal(string name, int pointValue, int targetCount) : base(name, pointValue) {
        TargetCount = targetCount;
        TimesCompleted = 0;
    }

    // Record that the goal has been completed
    public override void RecordEvent() {
        TimesCompleted++;
        Console.WriteLine($"Recorded progress for {Name}! You earned {PointValue} points.");
        if (TimesCompleted == TargetCount) {
            Console.WriteLine($"Congratulations! You completed {Name} and earned a bonus of {PointValue * TargetCount} points.");
        }
    }

    // Override ToString() to show completion status and times completed
    public override string ToString() {
        return $"{Name} ({PointValue} points) [{TimesCompleted}/{TargetCount} completed]";
    }
}
