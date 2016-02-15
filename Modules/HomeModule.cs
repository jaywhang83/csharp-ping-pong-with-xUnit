using Nancy;
using System.Collections.Generic;

namespace PingPong{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["input_form.cshtml"];
      Post["/results"] = _ => {
        int maxNumber = int.Parse(Request.Form["number"]);
        PingPongGenerator pingpong = new PingPongGenerator();
        List<string> results = pingpong.IsPingPong(maxNumber);
        return View["results.cshtml", results];
      };
    }
  }
}
