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
        
    public Point(Point p){
      x = p.x;
      y = p.y;
      sym = p.sym;
    }

    public void Move(int offset, Direction direction_) {
      if(direction_ == Direction.UP) {
        y = y - offset;
      }
      else if(direction_ == Direction.DOWN) {
        y = y + offset;
      }
      else if (direction_ == Direction.RIHGT)
      {
        x = x + offset;
      }
      else if (direction_ == Direction.LEFT)
      {
        x = x - offset;
      }
    }

    public bool IsHit(Point p) {
      return p.x == this.x && p.y == this.y;
    }

    public void Drow()
    {
     Console.SetCursorPosition(x, y);   
     Console.Write(sym);               
    }

    public override string ToString() {
        return x + ", " + y + ", " + sym;
    }

    public void Clear() {
      sym = ' ';
      Drow();
    }
  }
}
