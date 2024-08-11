namespace Models.Events
{
  public class ExampleEvent
  {
    public delegate void Notify();

    public class ProcessBusinessLogic
    {
      public event Notify? ProcessCompleted;
      public void StartProcess()
      {
        Console.WriteLine($"Process started for...");
        Thread.Sleep(3000);
        OnProcessComplete();
      }

      protected virtual void OnProcessComplete()
      {
        ProcessCompleted?.Invoke();
      }
    }
  }
}