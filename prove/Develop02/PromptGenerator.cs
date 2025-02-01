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
        "What am I most grateful for today?",
        "What lesson did I learn today?",
        "How did I show kindness today?",
        "Who did I help today, and how did it impact me?",
        "What challenge did I face today, and how did I overcome it?",
        "What made me smile today?",
        "What moment brought me peace today?",
        "How did I take care of my mind, body, or spirit today?",
        "What did I do today that made me feel proud of myself?",
        "What did I do today that I could improve upon tomorrow?",
        "How did I see growth in myself today?",
        "What act of service or love did I experience today?",
        "What was a beautiful moment I witnessed today?",
        "What did I learn from someone else today?",
        "What was a moment today where I felt connected to something bigger than myself?",
        "What fear did I face today, and how did I handle it?",
        "What made me feel strong or empowered today?",
        "What did I do today that helped me move closer to my goals?",
        "How did I practice patience today?",
        "What was a moment today that made me feel truly alive?"
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