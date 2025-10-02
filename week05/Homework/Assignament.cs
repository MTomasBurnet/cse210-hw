using System;

public class Assignament
{
    private string _name = "";
    private string _topic = "";

    public Assignament(string name, string topic)
    {
        _name = name;
        _topic = topic;
    }

    public string GetSummary()
    {
        return $"{_name} - {_topic}";
    }
}