namespace Models.Pets
{
  public class Cat : IPet
  {
    public string TalkToOwner() => "Meow!";
  }
}