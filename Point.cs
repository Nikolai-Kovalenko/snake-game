using System;

namespace snake
{
    public class Point
    {
      public int x;  
      public int y;  
      public char sym;

    public Point()
    {
    }

    public Point(int _x, int _y, char _sym){
      x = _x;
      y = _y;
      sym = _sym;
    }
        
    public void Drow()
    {
     Console.SetCursorPosition(x, y);   
     Console.Write(sym);               
    }
  }
}
