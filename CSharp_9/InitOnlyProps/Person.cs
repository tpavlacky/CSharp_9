using System;

namespace CSharp_9.InitOnlyProps
{
  internal class PersonOld
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
  }

  internal class PersonNew
  {
    public string FirstName { get; init; }
    public string LastName { get; init; }

    private readonly string _middleName = "unknown";
    public string MiddleName
    {
      get => _middleName;
      init => _middleName = value ?? throw new ArgumentNullException(nameof(MiddleName));
    }
  }

  internal class Test
  {
    internal void TestMethod()
    {
      var personOld = new PersonOld() {FirstName = "Karel", LastName = "Novak"};
      personOld.LastName = "Novak2"; 

      var personNew = new PersonNew() {FirstName = "Jan", LastName = "Novotny"};
      //personNew.LastName = "Novotny2"; //error
    }
  }
}
