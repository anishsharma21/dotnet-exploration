using Models.Generics;
using Models.Pets;

namespace Models
{
  public class Program
  {
    public static void Main(string[] args)
    {
      List<IPet> pets = [new Dog(), new Cat()];
      foreach (Pet pet in pets.Cast<Pet>())
      {
        pet.Eating();
      }
    }

  }
}
