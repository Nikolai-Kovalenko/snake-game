using System;

namespace snake
{
    class Snake : Figure
    {
      Direction direction;

        public Snake(Point  tail, int lenght, Direction _direction) {
          direction = _direction;
          pList = new List<Point>();
          for(int i = 0; i < lenght; i++) 
          {
            Point p = new Point(tail);
            p.Move(i, direction);
            pList.Add(p);
          }
        }

        public void Move() {
          Point tail = pList.First();
          pList.Remove(tail);
          Point head = GetNexPoint();
          pList .Add(head);

          tail.Clear();
          head.Drow();
        }

        public Point GetNexPoint() {
          Point head = pList.Last();
          Point nextPoint = new Point(head);
          nextPoint.Move(1, direction);
          return nextPoint;
        }

        public void HandLine(ConsoleKey key) {
          if(key == ConsoleKey.LeftArrow)
            direction = Direction.LEFT;
          else if(key == ConsoleKey.RightArrow)
            direction = Direction.RIHGT;
          else if(key == ConsoleKey.DownArrow)
            direction = Direction.DOWN;
          else if(key == ConsoleKey.UpArrow)
            direction = Direction.UP;
        }
    }
}
