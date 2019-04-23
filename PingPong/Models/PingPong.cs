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
      return "false";
    }
  }
}
