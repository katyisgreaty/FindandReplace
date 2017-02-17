using Nancy;
using FindAndReplaceFunction.Objects;
using System.Collections.Generic;

namespace FindAndReplaceFunction
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };

      Post["/results"] = _ => {
        FindAndReplace newFindAndReplace = new FindAndReplace(Request.Form["phrase"], Request.Form["word1"], Request.Form["word2"]);
        return View["results.cshtml", newFindAndReplace];
      };
    }
  }
}
