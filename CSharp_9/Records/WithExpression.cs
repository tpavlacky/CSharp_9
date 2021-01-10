using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.Records
{
  public class TestClass
  {
    public void Test()
    {
      var karelNovak = new PersonRecord() {FirstName = "Karel", LastName = "Novak"}; //Karel Novak
      var karelNovak2 = karelNovak with {LastName = "Novak2"}; // Karel Novak2 -> copying full state of the karelNovak into the new object and then mutate it based on the initializer => 
      // => properties must have set or init accessor to be changed in a with-expressin

      var karelNovakBackAgain = karelNovak2 with {LastName = "Novak"};
      var equal = karelNovak == karelNovakBackAgain; //true
      var refEqual = ReferenceEquals(karelNovak, karelNovakBackAgain); //false
    }
  }
}
