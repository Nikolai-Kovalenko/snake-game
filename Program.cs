using System;

namespace snake
{
  class Program
  {
    static void Main( string[] args )
    {
     // Console.SetBufferSize(80, 25);
      Console.CursorVisible = false;
      Horisontal_line upLine     = new Horisontal_line( 10, 78, 7, '+' );
      Horisontal_line downLine   = new Horisontal_line( 10, 78, 24, '+' );
      Wertical_line leftLine    = new Wertical_line( 10, 7, 24, '+' );
      Wertical_line rightLine   = new Wertical_line( 78, 7, 24, '+' );

      upLine.Drow();
      downLine.Drow();
      leftLine.Drow();
      rightLine.Drow();

      // Отрисовка точкк
      Point p = new Point(12, 10, '∎');
      Snake snake = new Snake(p, 4, Direction.RIHGT);
      snake.Drow();

      FoodCreator foodCreator = new FoodCreator(78, 24, '$');
      Point food = foodCreator.Createfood();
      food.Drow();

 
      while(true) {
        if(snake.Eat(food)) {
          food = foodCreator.Createfood();
          food.Drow();
        }
        else {
          snake.Move();
        }
        Thread.Sleep(100);

        if(Console.KeyAvailable) {
          ConsoleKeyInfo key = Console.ReadKey();
          snake.HandLine(key.Key);
        }
      }
        Console.CursorVisible = true;
    }   
  }
}
