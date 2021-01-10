using System;
using System.Runtime.Remoting.Messaging;
using System.Xml;

namespace CSharp_9.PatternMatching
{
  internal class RelationalPattern
  {
    public static decimal NewWay(int value) =>
      value switch
      {
        > 400 => 100,
        <= 100 => 10,
        _ => 10,
      };
  }
}
