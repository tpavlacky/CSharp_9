using System;

namespace CSharp_9.PatternMatching
{
  internal class SimpleTypePattern
  {
    //even ReSharper does not like this anymore
    public static decimal OldWay(object vehicle) =>
      vehicle switch
      {
        DeliveryTruck t when t.GrossWeightClass > 5000 => 10.00m + 5.00m,
        DeliveryTruck t when t.GrossWeightClass < 3000 => 10.00m - 2.00m,
        DeliveryTruck _ => 10.00m, //also ReSharper encourages you to remove discard 

        _ => throw new ArgumentException("Not a known vehicle type", nameof(vehicle))
      };

    public static decimal NewWay(object vehicle) =>
      vehicle switch
      {
        DeliveryTruck t when t.GrossWeightClass > 5000 => 10.00m + 5.00m,
        DeliveryTruck t when t.GrossWeightClass < 3000 => 10.00m - 2.00m,
        DeliveryTruck => 10.00m, //previously identifies needed to be declared even if it was discard ... this is no longer needed

        _ => throw new ArgumentException("Not a known vehicle type", nameof(vehicle))
      };
  }
}
