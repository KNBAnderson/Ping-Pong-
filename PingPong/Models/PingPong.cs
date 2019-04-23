// using System;

namespace Game
{
  public class PingPong
  {
    public string MakePingPong(int number)
    {
      if (number % 15 == 0)
      {
        return "PingPong";
      }
      else if (number % 3 == 0)
      {
        return "Ping";
      }
      else if (number % 5 == 0)
      {
        return "Pong";
      }
      return number.ToString();
    }
  }
}
