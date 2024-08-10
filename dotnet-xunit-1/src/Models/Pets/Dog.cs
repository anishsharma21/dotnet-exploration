namespace Models.Pets
{
  public class Dog : IPet
  {
    public string TalkToOwner() => "Woof!";
  }
}