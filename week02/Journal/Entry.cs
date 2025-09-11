using System; 
using System.Collections.Generic;

public class Entry
{
    string _prompt;
    string _input;
    List<string> _dateAndTime = new List<string>();

    public Entry()
    {
    }

    public void PutName(string prompt)
    {
        _prompt = prompt;
    }

    public void PutInput(string input)
    {
        _input = input;
    }

    public void PutDateAndTimer(List<string> dateTime)
    {
        _dateAndTime = dateTime;
    }
}