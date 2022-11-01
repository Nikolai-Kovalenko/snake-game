using System;

namespace snake
{
    class Program
    {
      
        static void Main( string[] args )
        {

          Point p1 = new Point(4, 8, '#');
          p1.Drow();

          Point p2 = new Point(9, 18, '&');
          p2.Drow();

          Wertical_line line = new Wertical_line(8, 2, 12, '@');
          line.Drow();


          Console.ReadLine();
        }
    }
}
