 using System;
 using System.Collections.Generic;


public class Journal



{
    public List<Entry> entries = new List<Entry>();

    public void AddEntry(string prompt)
    {
        // Get user response
        Console.Write(prompt + ": ");
        string response = Console.ReadLine();

        // Create new entry and add to journal
        Entry entry = new Entry(prompt, response, DateTime.Now);
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        // Iterate through all entries and display them
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void LoadFromFile()
    {
        // Get file name from user
        Console.Write("Enter file name: ");
        string fileName = Console.ReadLine();

        // Clear current journal
        entries.Clear();

        // Load journal from file
        using (StreamReader sr = new StreamReader(fileName))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                // Split line into prompt, response, and date
                string[] parts = line.Split(',');
                string prompt = parts[0];
                string response = parts[1];
                DateTime date = DateTime.Parse(parts[2]);

                // Create new entry and add to journal
                Entry entry = new Entry(prompt, response, date);
                entries.Add(entry);
            }

            
        }
        public void SaveToFile()
{
    // Get file name from user
    Console.Write("Enter file name: ");
    string fileName = Console.ReadLine();

    using (StreamWriter sw = new StreamWriter(fileName))
    {
        foreach (Entry entry in entries)
        {
            string line = entry.Prompt + "," + entry.Response + "," + entry.Date.ToString();
            sw.WriteLine(line);
        }
    }
    Console.WriteLine("Journal saved to file: " + fileName);
}
    }