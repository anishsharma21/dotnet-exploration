using System.Drawing;

namespace Models.Points
{
  public enum CartesianType
  {
    XY,
    Imaginary,
  }
  public struct Point(int x, int y)
  {
    public int X { get; set; } = x;
    public int Y { get; set; } = y;

    public readonly void Display()
    {
      Console.WriteLine($"Point: ({X}, {Y})\nCartesian plane: {CartesianType.XY}");
    }
  }
}