using Xunit;
using System;
using System.Collections.Generic;

namespace FindAndReplaceFunction.Objects
{
  public class FindAndReplaceTest
  {
    //COMMENTED OUT BECAUSE IT BECAME OBSOLETE
    // [Fact]
    // public void FindAndReplace_ReturnAllInputs_AllInputs()
    // {
    //   FindAndReplace testFindAndReplace = new FindAndReplace("hello cutie", "hello", "goodbye");
    //   List<string> expected = new List<string>{"hello cutie", "hello", "goodbye"};
    //   List<string> output = testFindAndReplace.FindAndReplaceMethod();
    //   Assert.Equal(expected, output);
    // }

    // [Fact]
    // public void FindAndReplace_ReturnMatchConfirmation_MatchConfirmation()
    // {
    //   FindAndReplace testFindAndReplace = new FindAndReplace("hello cutie", "cutie", "goodbye");
    //   List<string> expected = new List<string>{"cutie", "Your word was a match"};
    //   List<string> output = testFindAndReplace.FindAndReplaceMethod();
    //   Assert.Equal(expected, output);
    // }

    [Fact]
    public void FindAndReplace_ReturnNoMatch_NoMatch()
    {
      FindAndReplace testFindAndReplace = new FindAndReplace("hello cutie", "bills", "goodbye");
      List<string> expected = new List<string>{"Your word was not a match"};
      List<string> output = testFindAndReplace.FindAndReplaceMethod();
      Assert.Equal(expected, output);
    }

    [Fact]
    public void FindAndReplace_ReturnReplacedPhrase_ReplacedPhrase()
    {
      FindAndReplace testFindAndReplace = new FindAndReplace("hello cutie hello friend", "hello", "goodbye");
      List<string> expected = new List<string>{"goodbye cutie goodbye friend"};
      List<string> output = testFindAndReplace.FindAndReplaceMethod();
      Assert.Equal(expected, output);
    }
  }
}
