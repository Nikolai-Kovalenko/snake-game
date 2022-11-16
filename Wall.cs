using System;

namespace snake
{
    class Wall
    {
      List<Figure> wallList;

      char sym = 'X';

        public Wall(int xLeft, int xRight, int yUp, int yDowd) {
          wallList = new List<Figure>();

            Horisontal_line upLine      = new Horisontal_line   ( xLeft,   xRight,    yUp,   sym );
            Horisontal_line downLine    = new Horisontal_line   ( xLeft,   xRight,    yDowd, sym );
            Wertical_line   leftLine    = new Wertical_line     ( xLeft,   yUp,       yDowd, sym );
            Wertical_line   rightLine   = new Wertical_line     ( xRight,  yUp,       yDowd, sym );

            wallList.Add(upLine);
            wallList.Add(downLine);
            wallList.Add(leftLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figure figure) {
          foreach(var wall in wallList) {
            if(wall.IsHit(figure)) {
              return true;
            }
          }
          return false;
        }

        public void Drow() {
          foreach(var wall in wallList) {
            wall.Drow();
          }
        }
    }
}
