using System;
using System.Collections.Generic;
using promptgenerator;

namespace entry;

public class Entry
{
    string _prompt;
    string _input;
    string _dateAndTime;

    public Entry()
    {
    }

    public void PutPrompt(string promt)
    {
        _prompt = promt;
        Console.WriteLine(_prompt);
    }

    public void PutInput(string input)
    {
        _input = input;
    }

    public void PutDateAndTimer(string dateTime)
    {
        _dateAndTime = dateTime;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetImput()
    {
        return _input;
    }

    public string GetDateAndTimer()
    {
        return _dateAndTime;
    }
}