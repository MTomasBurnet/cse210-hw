using System;

namespace word;

public class Word
{
    string _text;
    bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public Word(string text, bool hide)
    {

        _text = text;
        _isHidden = hide;

    }

    public void Hide()
    {
        string newText = "";

        foreach (char ch in _text)
        {
            newText += "_";
        }

        _text = newText;

        _isHidden = true;
    }

    public void Show()
    {
        Console.Write(_text);
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _text + " ";
    }


}