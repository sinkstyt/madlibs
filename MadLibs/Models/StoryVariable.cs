namespace MadLibs.Models
{
  public class StoryVariable
  {
    public string Noun { get; set; }
    public string Adjective { get; set; }
    public string Adverb { get; set; }
    public string Verb { get; set; }
    public string Exclamation { get; set; }
    public string DeviceNoun { get; set; }

    public string DeviceRelatedVerb { get; set; }

    public string DeviceRelatedNoun { get; set; }

    public string LengthExpression { get; set; }

    public string Location { get; set; }
  }
}