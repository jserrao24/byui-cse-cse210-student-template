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
