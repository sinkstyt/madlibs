using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult MadLibForm()
    {
      return View();
    }

    [Route("/story")]
    public ActionResult Story(string noun, string adjective, string adverb, string verb, string exclamation)
    {
      StoryVariable myStory = new StoryVariable();
      myStory.Noun = noun;
      myStory.Adjective = adjective;
      myStory.Adverb = adverb;
      myStory.Verb = verb;
      myStory.Exclamation = exclamation;
      return View(myStory);
    }
  }
}