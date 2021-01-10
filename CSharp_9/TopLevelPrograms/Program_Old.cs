using System;
using System.Threading.Tasks;

namespace CSharp_9.TopLevelPrograms
{
  internal class Program
  {
    private static async Task Main(string[] args)
    {
      await Task.Delay(100);
      Console.WriteLine("This is awesome project!");
      Console.WriteLine($"I am running with arguments: {string.Join(",", args)}");
      Console.ReadLine();
    }
  }
}
