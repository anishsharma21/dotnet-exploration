using System.Drawing;

namespace Models.Points
{
  public enum CartesianType
  {
    XY,
    Imaginary,
  }
  public struct Point
  {
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y)
    {
      X = x;
      Y = y;
    }

    public void Display()
    {
      Console.WriteLine($"Point: ({X}, {Y})\nCartesian plane: {CartesianType.XY}");
    }
  }
}