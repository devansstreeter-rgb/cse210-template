// Stretch challenge: the program only selects words which have not already been hidden

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string response = "";
        Reference testReference = new Reference("Helaman", 12, 8, 9);
        string scriptureText = "For behold, the dust of the earth moveth hither and thither, to the dividing usunder, at the command of our great and everlasting God. Yea, behold at his voice do the hills and mountains tremble and quake";
        Scripture testScripture = new Scripture(testReference, scriptureText);
        while (response != "quit")
        {
            Console.Clear();
            Console.WriteLine(testScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter or type 'quit' to finish:");
            if (!testScripture.AllWordsBlank())
            {
                response = Console.ReadLine();
                testScripture.CreateBlanks(3);
            }
            else
            {
                Console.Clear();
                Console.WriteLine(testScripture.GetDisplayText());
                Console.WriteLine("\nCan you remember all the words?");
                response = "quit";
            }
        }
    }
}