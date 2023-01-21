using System;

class Program
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
