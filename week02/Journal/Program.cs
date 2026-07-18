using System;
using System.Formats.Asn1;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
      int userChoice = 0;
      Journal journal = new Journal();
      string journalFile = "journal.txt";
      Console.WriteLine("Welcome to the Journal Program!");
      while (userChoice != 5)
    {
      Console.WriteLine("Please select one of the following choices:");
      Console.WriteLine("1. Write");
      Console.WriteLine("2. Display");
      Console.WriteLine("3. Load");
      Console.WriteLine("4. Save");
      Console.WriteLine("5. Quit");
      Console.Write("What would you like to do? ");
      userChoice = int.Parse(Console.ReadLine());
      if (userChoice > 5)
      {
        Console.WriteLine("Choice not recognized");
      }
      else if (userChoice == 1)
      {
        Entry latestEntry = new Entry();
        Console.WriteLine(latestEntry._promptText);
        Console.Write("> ");
        string userSubmission = Console.ReadLine();
        latestEntry._entryText = userSubmission;
        journal.AddEntry(latestEntry);
      } else if (userChoice == 2)
      {
        journal.DisplayAll();
      } else if (userChoice == 3)
      {
        journal.LoadFromFile(journalFile);
      } else if (userChoice == 4)
      {
        journal.SaveToFile(journalFile);
      }
    }
    }
}