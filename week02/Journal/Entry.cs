public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        DateTime current = DateTime.Now;
        _date = current.ToShortDateString();
        PromptGenerator randomPrompt = new PromptGenerator();
        _promptText = randomPrompt.GetRandomPrompt();
    }

    public void Display()
    {
        Console.WriteLine(_date);
        Console.WriteLine(_promptText);
        Console.WriteLine(_entryText);
    }
}