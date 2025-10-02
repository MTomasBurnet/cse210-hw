using System;

public class WritingAssignaments : Assignament
{
    private string _title = "";

    public WritingAssignaments(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title}";
    }
}