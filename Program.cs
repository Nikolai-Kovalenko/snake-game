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
          Console.ReadLine();

          List<int> num_list = new List<int>();
          num_list.Add (0);
          num_list.Add (4);
          num_list.Add (6);
          num_list.Add (17);

          foreach(int i in num_list){
            Console.WriteLine(i);
          }
        }
    }
}
