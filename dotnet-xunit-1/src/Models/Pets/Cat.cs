namespace Models.Pets
{
  public class Cat : Pet
  {
    public override string TalkToOwner() => "Meow!";

    public override void Eating()
    {
      Console.WriteLine("munching");
    }
  }
}