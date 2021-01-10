using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.CovariantReturn
{
  // not available for .net FW 4.8 => requires runtime changes
  abstract class Animal
  {
    //public abstract Food GetFood();
  }
  class Tiger : Animal
  {
    //public override Meat GetFood() => new Meat();
  }

  class Food
  {
  }

  class Meat : Food
  {
  }
}
