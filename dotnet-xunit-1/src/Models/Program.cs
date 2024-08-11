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
      Console.WriteLine(GC.GetTotalMemory(false));

      SimpleGeneric<int> simpleGeneric2 = new();
      Console.WriteLine(simpleGeneric2.GetType());
      Console.WriteLine(GC.GetTotalMemory(false));

      LinkedList<string> strings = new();
      strings.AddFirst("First");
      List<string> newList = [.. strings];
      Console.WriteLine(GC.GetTotalMemory(true));
    }

  }
}
