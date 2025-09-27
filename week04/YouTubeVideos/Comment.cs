using System;

namespace comment;

public class Comment
{
    public string _name;
    public string _text;

    public Comment()
    {
        
    }

    public void DisplayComment()
    {
        Console.WriteLine($"@{_name}:");
        Console.WriteLine(_text);
    }
}