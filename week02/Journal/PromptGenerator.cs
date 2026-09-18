using System;
using System.Collections.Generic;

class PromptGenerator
{
    private List<string> _randomPrompts = new List<string>()
    {
        "Who was the most interesting person you interacted with today?",
        "What was the best part of your day?",
        "How did you see the hand of the Lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If you had one thing you could do over today, what would it be?",
        "If you had one thing you could do differently, what would it be?",
        "Looking back on today, what fills your heart with gratitude?"
    };

    private Random _rand = new Random();

    public string GetRandomPrompt()
    {
        return _randomPrompts[_rand.Next(_randomPrompts.Count)];
    }
}
