using System;
using System.Collections.Generic;
using System.IO;

// Journal class to store entries and handle file operations
class Journal
{
    private List<Entry> entries;
    public Journal()
    {
        entries = new List<Entry>();
    }

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        using (StreamReader reader = new StreamReader(filename))
        {
            entries.Clear();
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Entry entry = Entry.FromString(line);
                entries.Add(entry);
            }
        }
    }
}

// Entry class to store a single entry's data
class Entry
{
    private string prompt;
    private string response;
    private DateTime date;

    public Entry(string prompt, string response)
    {
        this.prompt = prompt;
        this.response = response;
        date = DateTime.Now;
    }

    public void Display()
    {
        Console.WriteLine("Prompt: " + prompt);
        Console.WriteLine("Response: " + response);
        Console.WriteLine("Date: " + date);
    }

    public override string ToString()
    {
        return prompt + "," + response + "," + date;
    }

    public static Entry FromString(string line)
    {
        string[] parts = line.Split(',');
        return new Entry(parts[0], parts[1]);
    }
}

// PromptGenerator class to generate prompts
class PromptGenerator
{
    private static List<string> prompts = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public static string GetRandomPrompt()
    {
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}