using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "How did I see the hand of the Lord in my life today?",
        "One thing that I was proud of today?",
        "If I had one thing I could do over today what would it be?",
        "What scripture inspired me today?",
        "What goal did I achieve today?",
    };

    public PromptGenerator()
    {
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        return prompt;
    }
}