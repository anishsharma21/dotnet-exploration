using System.Reflection.Metadata;
using Models.Events;

namespace Models
{
  public class Program
  {
    public static void Main(string[] args)
    {
      ExampleEvent.ProcessBusinessLogic processBusinessLogic = new ExampleEvent.ProcessBusinessLogic();
      processBusinessLogic.ProcessCompleted += Bl_ProcessCompleted;
      processBusinessLogic.StartProcess();
    }

    private static void Bl_ProcessCompleted()
    {
      Console.WriteLine("Process completed!");
    }
  }
}
