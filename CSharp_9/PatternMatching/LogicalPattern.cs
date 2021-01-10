using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.PatternMatching
{
  class LogicalPattern
  {
    public static bool IsLetter(char c) =>
      c is >= 'a' and <= 'z' or >= 'A' and <= 'Z';

    public static bool IsLetterOrSeparator(char c) =>
      c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',';

    public static decimal GetWeight(object vehicle) =>
      vehicle switch
      {
        //...
        DeliveryTruck {GrossWeightClass: >= 100} => 50,
        not null => throw new ArgumentException($"Not a known vehicle type: {vehicle}", nameof(vehicle)),
        null => throw new ArgumentNullException(nameof(vehicle)),
      };
  }

  public class BestFeatureOfAllTimes
  {
    public void Test(object obj)
    {
      //old ugly
      if (!(obj is TestClass))
      {
        //...
      }

      //new awesome
      if (obj is not TestClass)
      {
        //do something
      }

      if (obj is not TestClass tc) { throw new Exception(); } // if this branch throws or returns...
      var n = tc.Name; // ... tc is definitely assigned here
    }
  }

  internal class TestClass
  {
    public string Name { get; set; }
  }
}
