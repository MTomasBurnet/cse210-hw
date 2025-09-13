using System;
using System.Collections.Generic;

namespace promptgenerator;
public class PromptGenerator
{
    List<string> _prompts = new List<string> { "What was my favorite part of the day?", "What made me happy today?", "How was the weather of the day?", "Which interaction did I like the most?", "I learned today?", "How did I see the hand of the Lord today?", "How did I feel today?" };

    public PromptGenerator()
    {
    }

    public string GetPrompt()
    {
        Random randomNumber = new Random();
        int number = randomNumber.Next(0, _prompts.Count);
        string prompt = _prompts[number];
        return prompt;

    }
}