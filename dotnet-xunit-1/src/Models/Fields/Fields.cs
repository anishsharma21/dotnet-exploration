namespace Models.Fields
{
  public class Constants
  {
    public const double Pi = 3.1415;
    public readonly DateTime BirthDate;
    private int _age;
    public int Age
    {
      get { return _age; }
      set
      {
        ArgumentOutOfRangeException.ThrowIfNegative(value, "Age");
        _age = value;
      }
    }
    public Constants(DateTime birthDate)
    {
      BirthDate = birthDate;
    }

  }

  public class Example
  {
    public static void ExampleStart()
    {
      Constants con = new Constants(new DateTime(1999, 11, 23));
      Console.Write(Constants.Pi + "\n");
      Console.Write($"{con.BirthDate:d}\n");
    }
  }
}