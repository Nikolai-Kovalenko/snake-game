using System;

namespace snake 
{
   public class Figure 
     {
      protected List<Point> pList; 

      public void Drow() {
        foreach(Point p in pList)
        {
          p.Drow();
        }
      }

      internal bool IsHit(Figure figure) {
        foreach(var p in pList) {
          if(figure.IsHit(p)) {
            return true;
          }
        }
        return false;
      }

      private bool IsHit(Point point) {
        foreach(var p in pList) {
          if(p.IsHit(point)) {
            return true;
          }
        }
        return false;
      }
   }
}
