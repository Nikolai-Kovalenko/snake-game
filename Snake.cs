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

        internal bool IsHitTail() 
        {
          var head = pList.Last();
            
          for(int i = 0; i < pList.Count - 2; i++) 
          {
            if(head.IsHit( pList[ i ] ) ) 
              return true;
          }
          return false;
        }

        public void HandLine(ConsoleKey key) {
          if(key == ConsoleKey.LeftArrow & direction != Direction.RIHGT)
            direction = Direction.LEFT;
          else if(key == ConsoleKey.RightArrow & direction != Direction.LEFT)
            direction = Direction.RIHGT;
          else if(key == ConsoleKey.DownArrow & direction != Direction.UP)
            direction = Direction.DOWN;
          else if(key == ConsoleKey.UpArrow & direction != Direction.DOWN)
            direction = Direction.UP;
        }

        internal bool Eat(Point food) {
          Point head = GetNexPoint();
          if(head.IsHit(food)) {
            food.sym = head.sym;
            pList.Add(food);
            return true;
          }
          else return false;
        }
    }
}
