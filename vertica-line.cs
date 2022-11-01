using System;

namespace snake
{
  public class Wertical_line
  {
    List<Point> pList; 

    public Wertical_line(int x, int yHight, int yLow, char sym) 
    {
      pList = new List<Point>();
      for(int y = yHight; y <= yLow; y++)
      {
        Point p = new Point(x, y, sym);
        pList.Add(p);
      }
    }
    public void Drow() {
      foreach(Point p in pList)
      {
        p.Drow();
      }
    }
  }
}
  
