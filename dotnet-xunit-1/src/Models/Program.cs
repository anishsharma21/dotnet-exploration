using Models.Pets;

namespace Models
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<IPet> pets = [new Dog(), new Cat(), new Bird()];

      foreach (IPet pet in pets)
      {
        Console.WriteLine(pet.TalkToOwner());
      }
    }
  }
}
