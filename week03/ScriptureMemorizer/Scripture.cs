using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Xml;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = [];
    private List<int> _unblankedIndices = []; // Additional functionality - Added to ensure each word is only "blanked" once

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(" ");
        foreach (string word in words)
        {
            Word madeObject = new Word(word);
            _words.Add(madeObject);
        }
        for (int i=0; i < _words.Count; i++)
        {
            _unblankedIndices.Add(i);
        }
    }

    public void CreateBlanks(int quantity)
    {
        for (int i = 0; i < quantity; i++)
        {
            if (!AllWordsBlank())
            {
                int randomRange = _unblankedIndices.Count;
                Random rGenerator = new Random();
                int rIndex = rGenerator.Next(0, randomRange);
                int indexToBlank = _unblankedIndices[rIndex];
                _words[indexToBlank].MakeBlank();
                _unblankedIndices.RemoveAt(rIndex);
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            displayText += $" {word.GetDisplayText()}";
        }
        return displayText;
    }

    public bool AllWordsBlank()
    {
        if (_unblankedIndices.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}