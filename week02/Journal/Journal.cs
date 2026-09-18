using System;
using System.Collections.Generic;
using System.IO;

class Journal
{
    private List<Entry> _userEntries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _userEntries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry newEntry in _userEntries)
        {
            newEntry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry newEntry in _userEntries)
            {
                writer.WriteLine(newEntry.ToFileString());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        _userEntries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            Entry newEntry = Entry.FromFileString(line);
            if (newEntry != null)
            {
                _userEntries.Add(newEntry);
            }
        }
    }
}
