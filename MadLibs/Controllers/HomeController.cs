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
    public ActionResult Story(string noun, string adjective, string adverb, string verb, string exclamation, string deviceNoun, string deviceRelatedVerb, string deviceRelatedNoun, string lengthExpression, string location)
    {
      StoryVariable myStory = new StoryVariable();
      myStory.Noun = noun;
      myStory.Adjective = adjective;
      myStory.Adverb = adverb;
      myStory.Verb = verb;
      myStory.Exclamation = exclamation;
      myStory.DeviceNoun = deviceNoun;
      myStory.DeviceRelatedVerb = deviceRelatedVerb;
      myStory.DeviceRelatedNoun = deviceRelatedNoun;
      myStory.LengthExpression = lengthExpression;
      myStory.Location = location;
      return View(myStory);
    }
  }
}