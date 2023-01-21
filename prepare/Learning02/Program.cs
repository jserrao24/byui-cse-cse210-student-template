using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        Resume myResume = new Resume();

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

       
    }
}


/*
lass Program
{
    static void Main(string[] args)
    {
        // Create a new journal
        Journal journal = new Journal();

        // Show menu to user
        int choice = ShowMenu();

        while (choice != 5)
        {
            if (choice == 1)
            {
                // Write a new entry
                journal.AddEntry(Prompts.GetRandomPrompt());
            }
            else if (choice == 2)
            {
                // Display journal
                journal.DisplayEntries();
            }
            else if (choice == 3)
            {
                // Load journal from file
                journal.LoadFromFile();
            }
            else if (choice == 4)
            {
                // Save journal to file
                journal.SaveToFile();
            }
            choice = ShowMenu();
        }
    }

    static int ShowMenu()
    {
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display journal");
        Console.WriteLine("3. Load journal from file");
        Console.WriteLine("4. Save journal to file");
        Console.WriteLine("5. Exit");
        Console.Write("Enter your choice: ");
        return int.Parse(Console.ReadLine());
    }
}


*/