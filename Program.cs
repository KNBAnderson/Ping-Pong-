using System;

namespace Game
{
  class Program
  {
    public static void Main()
    {
      Console.WriteLine("Give me a number");
      string userNumberString = Console.ReadLine();
      int userNumber = int.Parse(userNumberString);

      for (int number = 1; number <= userNumber; number++)
      {
        Game.PingPong instance = new Game.PingPong(number);
        string result = instance.MakePingPong(number);
        Console.WriteLine(result);
      }
    }
  }
}
