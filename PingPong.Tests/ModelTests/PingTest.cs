using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;

namespace Game.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void MakePingPong_NumberDivisibleByFifteen_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("PingPong", testPingPong.MakePingPong(15));
    }
    [TestMethod]
    public void MakePingPong_NumberDivisibleByThree_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("Ping", testPingPong.MakePingPong(3));
    }
    [TestMethod]
    public void MakePingPong_NumberDivisibleByFive_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("Pong", testPingPong.MakePingPong(5));
    }
    [TestMethod]
    public void MakePingPong_NumberNotDivisibleByThreeOrFive_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("7", testPingPong.MakePingPong(7));
    }
  }
}
