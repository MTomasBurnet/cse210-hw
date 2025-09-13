using System;
using entry;

namespace journal;

public class Journal
{
    public List<Entry> _data = new List<Entry>();

    public Journal()
    {
    }

    public void Save(Entry newEntry)
    {
        _data.Add(newEntry);
    }

    public List<Entry> GetList()
    {
        return _data;
    }
}
