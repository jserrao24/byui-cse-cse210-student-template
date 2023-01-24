using System;
using System.Collections.Generic;
using System.IO;



class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Enter a selection: ");
            string selection = Console.ReadLine();
              if (selection == "1")
        {
            string prompt = PromptGenerator.GetRandomPrompt();
            Console.Write("Enter your response: ");
            string response = Console.ReadLine();
            Entry entry = new Entry(prompt, response);
            journal.AddEntry(entry);
        }
        else if (selection == "2")
        {
            journal.DisplayEntries();
        }
        else if (selection == "3")
        {
            Console.Write("Enter a file name: ");
            string filename = Console.ReadLine();
            journal.SaveToFile(filename);
        }
        else if (selection == "4")
        {
            Console.Write("Enter a file name: ");
            string filename = Console.ReadLine();
            journal.LoadFromFile(filename);
        }
        else if (selection == "5")
        {
            break;
        }
        else
        {
            Console.WriteLine("Invalid selection. Please try again.");
        }
    }
}
}

// Class has own file Journal
//Journal
//Entry
//PromptGenerator
//Name of file should match class name First file name capitlized as are the classses
//_ in vairable name, Indivudal functon with class, Differnetiate between functions and classes. Attribute= member variable
// 
