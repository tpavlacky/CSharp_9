using System.Collections.Generic;

namespace CSharp_9.NewExpression
{
  internal class NewExpression
  {
    internal void Test()
    {
      //old
      List<string> oldList = new List<string>();
      var oldPoint = new Point(2, 3);


      //new
      List<string> newList = new();
      Point newPoint = new(2, 3);
      Point[] ps = { new(1, 2), new(5, 2), new(5, -3), new(1, -3) };
    }
  }

  internal class Point
  {
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
      X = x;
      Y = y;
    }
  }
}
