using Microsoft.VisualStudio.TestTools.UnitTesting;
using Game;

namespace Game.Tests
{
  [TestClass]
  public class PingPongTest
  {
    [TestMethod]
    public void MakePingPong_NumberDivisiibleByFifteen_True()
    {
      PingPong testPingPong = new PingPong();
      Assert.AreEqual("PingPong", testPingPong.MakePingPong(15));
    }
  }
}
