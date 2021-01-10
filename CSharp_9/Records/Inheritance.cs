using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_9.Records
{
  //awesome syntax highlight btw
  public record StudentRecord : PersonRecord
  {
    public int ID;
  }

  public class Test
  {
    public void TestMethod()
    {
      //store new studentRecord into personRecord object
      PersonRecord studentRecord = new StudentRecord() {FirstName = "Karel", LastName = "Novak", ID = 123};

      //copy studentRecord instance withing studentRecord variable 
      var otherStudent = studentRecord with {LastName = "Novotny"};
      var isStudent = otherStudent is StudentRecord; //true => keeping runtime type (StudentRecord)
    }
  }
}
