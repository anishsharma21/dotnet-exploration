using System.Collections;

namespace Models
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Console.ForegroundColor = ConsoleColor.Blue;
      ArrayList arrayList = [1, 2, 3, 4];
      List<int> ints = [1, 2, 3, 4];
      Dictionary<int, string> keyValuePairs = new()
      {
          { 1, "one" },
          { 2, "two" },
          { 3, "three" }
      };
      Hashtable hashtable = [];
      hashtable.Add("hi there", 1);

      foreach (KeyValuePair<int, string> kvp in keyValuePairs)
      {
        Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
      }
    }

  }
}
