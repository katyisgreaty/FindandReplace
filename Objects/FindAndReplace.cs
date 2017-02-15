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
    private List<string> _allInputs = new List<string>();

    public FindAndReplace (string phraseInput, string oldWord, string newWord)
    {
      _phraseInput = phraseInput;
      _oldWord = oldWord;
      _newWord = newWord;
    }

    public List<string> GetAllInputs()
    {
      _allInputs.Add(_phraseInput);
      _allInputs.Add(_oldWord);
      _allInputs.Add(_newWord);
      return _allInputs;
    }
  }
}
