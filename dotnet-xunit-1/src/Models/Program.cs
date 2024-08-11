namespace Models
{
  public class Program
  {
    public static void Main(string[] args)
    {
      int[] baseValues = [2, 8, 10, 16];
      short value = short.MaxValue;
      foreach (int baseValue in baseValues)
      {
        string s = Convert.ToString(value, baseValue);
        short value2 = Convert.ToInt16(s, baseValue);
        Console.WriteLine($"{value} --> {s}\n{baseValue} --> {value2}");
      }
    }

  }
}
