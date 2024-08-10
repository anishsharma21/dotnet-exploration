namespace Models.Pets
{
  public class Dog : IPet
  {
    public class Tail
    {
      public int TailLength { get; set; }

      public void PrintTailLength()
      {
        Console.WriteLine(TailLength);
      }
    }
    public string TalkToOwner() => "Woof!";
  }
}