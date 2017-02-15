using Nancy;
using System;
using System.Collections.Generic;

namespace FindAndReplaceFunction.Objects
{
  public class FindAndReplace
  {
    private string _phraseInput;
    private string _oldWord;
    private string _newWord;
    private List<string> _outputWords = new List<string>{};

    public FindAndReplace (string phraseInput, string oldWord, string newWord)
    {
      _phraseInput = phraseInput;
      _oldWord = oldWord;
      _newWord = newWord;
    }

    public List<string> FindAndReplaceMethod()
    {
      string[] words = _phraseInput.Split(' ');
      string newPhrase = string.Join(" ", words);
      if (_phraseInput.Contains(_oldWord))
      {
        Console.WriteLine("match");
        for(int i = 0; i < words.Length; i++)
        {
          if (words[i].Contains(_oldWord))
          {
            //replace just that part of the word
            words[i] = words[i].Replace(_oldWord, _newWord);
            newPhrase = string.Join(" ", words);
          }
        }
        Console.WriteLine(newPhrase);
        _outputWords.Add(newPhrase);
      }
      else
      {
        _outputWords.Add("Your word was not a match");
      }
      return _outputWords;
    }
  }
}
