using System;
using System.Collections.Generic;

namespace PingPong
{
  public class PingPongGenerator
  {
    public List<string> IsPingPong(int maxNumber)
    {
      List<string> numberBank = new List<string> {};
      for ( int i = 1; i <= maxNumber; i++)
      {
        if(i % 15 == 0)
        {
          numberBank.Add("ping-pong");
        }
        else if(i % 5 == 0)
        {
          numberBank.Add("pong");
        }
        else if (i % 3 == 0)
        {
          numberBank.Add("ping");
        }
        else
        {
          string number = i.ToString();
          numberBank.Add(number);
        }
      }
      return numberBank;
    }
  }
}
