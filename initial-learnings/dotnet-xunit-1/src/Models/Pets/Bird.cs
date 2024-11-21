namespace Models.Pets
{
  public class Bird : IPet
  {
    public string TalkToOwner() => "Tweet!";
  }
}