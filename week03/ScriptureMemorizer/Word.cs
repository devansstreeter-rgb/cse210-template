using System.Reflection.PortableExecutable;

public class Word
{
    public bool _isBlank;
    private string _charas;
    
    public Word(string word)
    {
        _isBlank = false;
        _charas = word;
    }

    public void MakeBlank()
    {
        string blankWord = "";
        foreach (char letter in _charas)
        {
            blankWord += '_';
        }
        _charas = blankWord;
        _isBlank = true;
    }

    public string GetDisplayText()
    {
        return _charas;
    }
}