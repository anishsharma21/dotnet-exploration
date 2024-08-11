using Models.Generics;

namespace Models
{
  public class Program
  {
    public static void Main(string[] args)
    {
      SimpleGeneric<string> simpleGeneric = new()
      {
        Field = "field init"
      };
      Console.WriteLine(simpleGeneric.Field);

      SimpleGeneric<int> simpleGeneric2 = new();
      Console.WriteLine(simpleGeneric2.GetType());

      LinkedList<string> strings = new();
      strings.AddFirst("First");
      List<string> newList = [.. strings];
    }

  }
}
