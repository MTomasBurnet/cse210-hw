using System;
using reference;
using word;

namespace scripture;

public class Scripture
{
    private Reference _reference;
    private List<Word> _word = new List<Word>();

    public Scripture(Reference refe, string phrase)
    {
        _reference = refe;

        List<string> _phrase = new List<string>();
        _phrase = phrase.Split(" ").ToList();

        foreach (string word in _phrase)
        {
            Word wordInside = new Word(word);
            _word.Add(wordInside);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        int quantity = _word.Count;
        Random randome = new Random();
        int index;
        bool ocult = false;

        for (int i = 0; i < numberToHide; i++)
        {

            do
            {
                index = randome.Next(0, quantity);

                if (!_word[index].IsHidden())
                {
                    _word[index].Hide();
                    ocult = true;
                }

            } while (ocult != true);

        }
    }

    public string GetDisplayText()
    {
        string phrase = "";

        foreach (Word word in _word)
        {
            phrase += word.GetDisplayText();
        }

        return phrase;
    }

    public bool IsCompletyHidden()
    {

        foreach (Word word in _word)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }

        return true;
    }
    
    public Reference GetReference()
    {
        return _reference;
    }

}