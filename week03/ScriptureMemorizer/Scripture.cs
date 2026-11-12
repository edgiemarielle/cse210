using System;
using System.Collections.Generic;


public class Scripture
{
    private Reference _reference;

    private List<Word> _words = new List<Word>();


    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] wordList = text.Split(' ');
        foreach (string wordText in wordList)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        if (numberToHide <= 0)
        {
            return;
        }

        Random random = new Random();
        int hiddenWords = 0;

        while (hiddenWords < numberToHide)
        {
            int index = random.Next(_words.Count);

            if (!_words[index].isHidden())
            {
                _words[index].Hide();
                hiddenWords++;
            }
            else if (_words.All(word => word.isHidden()))
            {
                break;
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";

        foreach (Word word in _words)
        {
            if (displayText.Length > 0)
            {
                displayText += " ";
            }

            displayText += word.GetDisplayText();
        }
        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return true;
    }
}