using System;

namespace snake
{
    class Program
    {
      
        static void Main( string[] args )
        {

      Point p1 = new Point();
         p1.x = 12;
         p1.y = 5;
         p1.sym = '$';
         p1.Drow();
        Console.ReadLine();
        

      Point p2 = new Point();
         p2.x = 12;
         p2.y = 15;
         p2.sym = '@';
         p2.Drow();
        Console.ReadLine();
        }
    }
}
