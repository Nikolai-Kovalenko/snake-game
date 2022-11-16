using System;

namespace snake
{
  class Program
  {
    static void Main( string[] args )
    {
     // Console.SetBufferSize(80, 25);
      Console.CursorVisible = false;

      Wall wall = new Wall(9, 100, 5, 39);
      wall.Drow();

      // Отрисовка точкк
      Point p = new Point(42, 27, '∎');
      Snake snake = new Snake(p, 4, Direction.RIHGT);
      snake.Drow();

      FoodCreator foodCreator = new FoodCreator(98, 38, '$');
      Point food = foodCreator.Createfood();
      food.Drow();

 
      while(true) {
        if(wall.IsHit(snake) || snake.IsHitTail() ) {
          break; 
        }

        if(snake.Eat(food)) {
          food = foodCreator.Createfood();
          food.Drow();
        }
        else {
          snake.Move();
        }
        Thread.Sleep(60);

        if(Console.KeyAvailable) {
          ConsoleKeyInfo key = Console.ReadKey();
          snake.HandLine(key.Key);
        }
      }
        Console.SetCursorPosition(1, 40);
        Console.CursorVisible = true;
    }   
  }
}
