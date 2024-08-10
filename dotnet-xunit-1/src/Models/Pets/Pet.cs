namespace Models.Pets
{
  public abstract class Pet : IPet
  {
    public abstract string TalkToOwner();

    public virtual void Eating()
    {
      Console.WriteLine("Nom nom");
    }
  }
}