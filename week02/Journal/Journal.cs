using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = [];

    public Journal()
    {
    }

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach(Entry entry in _entries) {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach(Entry entry in _entries) {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._promptText);
                outputFile.WriteLine(entry._entryText);
                outputFile.Write("\n");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string[] linesArray = System.IO.File.ReadAllLines(file);
        foreach (string line in linesArray)
        {
            Console.WriteLine(line);
        }
    }
}