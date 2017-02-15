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
      foreach(string word in words)
      {
        if (word == _oldWord)
        {
          _outputWords.Add(_oldWord);
          _outputWords.Add("Your word was a match");
        }
      }
      if (_outputWords.Count == 0)
      {
        _outputWords.Add("Your word was not a match");
      }
      return _outputWords;
    }
  }
}
