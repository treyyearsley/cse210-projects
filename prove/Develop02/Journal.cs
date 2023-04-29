using System;

class Journal
{
    List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void CreateJournalEntry(Entry newEntry)
    {
        entries.Add(newEntry);     
    }

    public void SaveToCSV(string fileName)
    {
        

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry._prompt + "," + entry._response + "," + entry._date);
            }
        }
    }

    public Journal LoadFromCSV(string fileName)
    {
        Entry entry;
        Journal j = new Journal();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            entry = new Entry(parts[0],parts[1],parts[2]);
            j.CreateJournalEntry(entry);
        }
        return j;
    }

}