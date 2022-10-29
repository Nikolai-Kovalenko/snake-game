using System;

namespace snake
{
    class Program
    {
        static void Main( string[] args )
        {
          int x1 = 13;
          int y1 = 5;
          char sym1 = '*';
          Drow(x1, y1, sym1);
          Console.ReadLine();
        }

        static void Drow(int x, int y, char sym)
        {
         Console.SetCursorPosition(x, y);   
         Console.Write(sym);               
        }
    }
}
