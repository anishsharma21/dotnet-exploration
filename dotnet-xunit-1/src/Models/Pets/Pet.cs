namespace Models.Pets
{
  public abstract class Pet : IPet
  {
    public abstract string TalkToOwner();
  }
}