public class PromptGenerator
{
    public List<string> _prompts = ["Did you meet anyone new today?", "What is one thing you would change about your day?", "Who did you think about today?"];

    public PromptGenerator()
    {
    }
    public string GetRandomPrompt()
    {
        Random rGenerator = new Random();
        int promptQuantity = _prompts.Count;
        int promptNumber = rGenerator.Next(0,promptQuantity);
        string prompt = _prompts[promptNumber];
        return prompt;
    }
}