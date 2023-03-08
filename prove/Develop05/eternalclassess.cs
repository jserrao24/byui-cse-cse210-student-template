// Define the main program class
public class Program
{
    // Fields
    private List<Activity> activities;
    private int score;

    // Constructor
    public Program()
    {
        this.activities = new List<Activity>();
        this.score = 0;
    }

    // Method for creating a new goal
    public void CreateNewGoal()
    {
        Console.Write("Enter the goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the point value: ");
        int pointValue = int.Parse(Console.ReadLine());
        Console.WriteLine("Choose the goal type:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                activities.Add(new SimpleGoal(name, pointValue));
                break;
            case 2:
                activities.Add(new EternalGoal(name, pointValue));
                break;
            case 3:
                Console.Write("Enter the number of times required: ");
                int numTimesRequired = int.Parse(Console.ReadLine());
                activities.Add(new ChecklistGoal(name, pointValue, numTimesRequired));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;

    }
}

// Method for recording an event
public void RecordEvent()
{
    Console.WriteLine("Choose the activity:");
    for (int i = 0; i < activities.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {activities[i].Name}");
    }
    int choice = int.Parse(Console.ReadLine()) - 1;
    activities[choice].RecordEvent();
    score += activities[choice].PointValue;
}

// Method for displaying progress
public void DisplayProgress()
{
    Console.WriteLine($"Current score: {score}");
    for (int i = 0; i < activities.Count; i++)
    {
        Console.WriteLine(activities[i].DisplayProgress());
    }
}

// Method for saving goals and score to a file
public void SaveToFile()
{
    // Create a file stream and a stream writer to write to the file
    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "goals.txt");
    using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
    using (StreamWriter streamWriter = new StreamWriter(fileStream))
    {
        // Write the total score to the first line of the file
        streamWriter.WriteLine(score);

        // Write each goal to the file in CSV format
        foreach (Activity activity in activities)
        {
            string goalType;
            if (activity is SimpleGoal)
            {
                goalType = "Simple";
            }
            else if (activity is EternalGoal)
            {
                goalType = "Eternal";
            }
            else if (activity is ChecklistGoal)
            {
                goalType = "Checklist";
                int numTimesRequired = ((ChecklistGoal)activity).NumTimesRequired;
                string line = $"{activity.Name},{activity.PointValue},{goalType},{numTimesRequired}";
                streamWriter.WriteLine(line);
            }
            else
            {
                goalType = "Unknown";
            }

            if (goalType != "Checklist")
            {
                string line = $"{activity.Name},{activity.PointValue},{goalType}";
                streamWriter.WriteLine(line);
            }
        }
    }

    Console.WriteLine("Goals and score saved to file.");
}

// Method for loading goals and score from a file
public void LoadFromFile()
{
    // Create a file stream and a stream reader to read from the file
    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "goals.txt");
    using (FileStream fileStream = new FileStream(filePath, FileMode.Open))
    using (StreamReader streamReader = new StreamReader(fileStream))
    {
        // Read the first line of the file to get the total score
        string totalScoreStr = streamReader.ReadLine();
        int.TryParse(totalScoreStr, out score);

        // Read each line of the file to create the corresponding goal objects
        string line;
        while ((line = streamReader.ReadLine()) != null)
        {
            string[] parts = line.Split(',');

            string name = parts[0];
            int pointValue;
            int.TryParse(parts[1], out pointValue);

            if (parts[2] == "Simple")
            {
                SimpleGoal goal = new SimpleGoal(name, pointValue);
                activities.Add(goal);
            }
            else if (parts[2] == "Eternal")
            {
                EternalGoal goal = new EternalGoal(name, pointValue);
                activities.Add(goal);
            }
            else if (parts[2] == "Checklist")
            {
                int numTimesRequired;
                int.TryParse(parts[3], out numTimesRequired);

                ChecklistGoal goal = new ChecklistGoal(name, pointValue, numTimesRequired);
                activities.Add(goal);
            }
        }
    }

    Console.WriteLine("Goals and score loaded from file.");
}

// Main method
public static void Main()
{
    Program program = new Program();
    bool done = false;
    while (!done)
    {
        Console.WriteLine("Choose an option:");
        Console.WriteLine("1. Create new goal");
        Console.WriteLine("2. Record event");
        Console.WriteLine("3. Display progress");
        Console.WriteLine("4. Save to file");
        Console.WriteLine("5. Load from file");
        Console.WriteLine("6. Quit");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                program.CreateNewGoal();
                break;
            case 2:
                program.RecordEvent();
                break;
            case 3:
                program.DisplayProgress();
                break;
            case 4:
                program.SaveToFile();
                break;
            case 5:
                program.LoadFromFile();
                break;
            case 6:
                done = true;
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}

}