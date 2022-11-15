using System;

namespace snake 
{
    class Horisontal_line : Figure
    {
      public  Horisontal_line(int xLeft, int xRight, int y, char sym)
      {
        pList = new List<Point>();
        for(int x = xLeft; x <= xRight; x++){
          Point p = new Point(x, y, sym);
          pList.Add(p);
        }
      }
    }
}
