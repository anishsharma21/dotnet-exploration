namespace Models.Pets
{
  class Dog : IPet
  {
    public string TalkToOwner()
    {
      return "Woof!";
    }
  }
}