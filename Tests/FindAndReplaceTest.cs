using Xunit;
using System;
using System.Collections.Generic;

namespace FindAndReplaceFunction.Objects
{
  public class FindAndReplaceTest
  {
    [Fact]
    public void FindAndReplace_ReturnAllInputs_allInputs()
    {
      FindAndReplace testFindAndReplace = new FindAndReplace("hello cutie", "hello", "goodbye");
      List<string> expected = new List<string>{"hello cutie", "hello", "goodbye"};
      List<string> output = testFindAndReplace.GetAllInputs();
      Assert.Equal(expected, output);
    }
  }
}
