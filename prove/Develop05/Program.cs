using System;

// Main program
public class Program {
    static void Main() {
        List<Goal> goals = new List<Goal>();

        // Add some example goals
        goals.Add(new SimpleGoal("Run a marathon", 1000));
        goals.Add(new EternalGoal("Read scriptures", 100));
        goals.Add(new ChecklistGoal("Attend the temple", 50, 10));

        // Record progress towards goals
        goals[0].RecordEvent(); // Complete marathon
        goals[1].RecordEvent(); // Read scriptures
        goals[1].RecordEvent(); // Read scriptures again
        goals[2].RecordEvent(); // Attend the temple
        goals[2].RecordEvent();
        goals[2].RecordEvent(); // Attend the temple again
        goals[2].RecordEvent(); // Attend the temple again
        goals[2].RecordEvent(); // Attend the temple again
        goals[2].RecordEvent(); // Attend the temple again
        goals[2].RecordEvent(); // Attend the temple again
        goals[2].RecordEvent(); // Attend the temple again
        goals[2].RecordEvent(); // Attend the temple again
        goals[2].RecordEvent(); // Attend the temple again (should trigger bonus)

    // Display goal list and total score
    int totalScore = 0;
    foreach (Goal goal in goals) {
        Console.WriteLine(goal);
        totalScore += goal.PointValue * (goal is ChecklistGoal ? ((ChecklistGoal)goal).TimesCompleted >= ((ChecklistGoal)goal).TargetCount ? ((ChecklistGoal)goal).TargetCount : ((ChecklistGoal)goal).TimesCompleted : ((EternalGoal)goal).TimesCompleted + (goal is SimpleGoal && ((SimpleGoal)goal).IsComplete ? 1 : 0));
    }
    Console.WriteLine($"Total score: {totalScore}");
}
