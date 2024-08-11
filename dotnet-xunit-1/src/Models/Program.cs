using Models.Fields;

namespace Models
{
  public class Program
  {
    public static void Main(string[] args)
    {
      Example.ExampleStart();
      Constants con = new(new DateTime())
      {
        Age = 5
      };
      Console.WriteLine(con.Age);
      con.Age = -5;
    }
  }
}
