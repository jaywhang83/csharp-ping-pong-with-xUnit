using System;
using System.Collections.Generic;
using Xunit;

namespace PingPong
{
  public class PingPongTest
  {
    [Fact]
    public void PingPongGenerator_ForNumberDivisibleByThree_true()
    {
      PingPongGenerator pingpong = new PingPongGenerator();
      List<string> result = pingpong.IsPingPong(3);
      foreach (string index in result)
      {
        Console.WriteLine(index);
      }
      Assert.Equal(result, pingpong.IsPingPong(3));
    }
    [Fact]
    public void PingPongGenerator_ForNumberDivisibleByFive_true()
    {
      PingPongGenerator pingpong = new PingPongGenerator();
      List<string> result = pingpong.IsPingPong(5);
      foreach (string index in result)
      {
        Console.WriteLine(index);
      }
      Assert.Equal(result, pingpong.IsPingPong(5));
    }
    [Fact]
    public void PingPongGenerator_ForNumberDivisibleByFifteen_true()
    {
      PingPongGenerator pingpong = new PingPongGenerator();
      List<string> result = pingpong.IsPingPong(15);
      foreach (string index in result)
      {
        Console.WriteLine(index);
      }
      Assert.Equal(result, pingpong.IsPingPong(15));
    }
  }

}
