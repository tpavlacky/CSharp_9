namespace CSharp_9.Records
{
  internal record FullPersonRecord
  {
    public string FirstName { get; init; }

    public string LastName { get; init; }

    public FullPersonRecord(string firstName, string lastName)
      => (FirstName, LastName) = (firstName, lastName);

    public void Deconstruct(out string firstName, out string lastName)
      => (firstName, lastName) = (FirstName, LastName);
  }

  internal record PositionalPersonRecord(string FirstName, string LastName);

  //FullPersonRecord is basically the same as the PositionalPersonRecord

  //can call base ctor
  internal record StudentPositionalPersonRecord(string FirstName, string LastName, int ID) : PositionalPersonRecord(FirstName, LastName);

  internal class RecordTest
  {
    internal void TestMethod()
    {
      var person = new PositionalPersonRecord("Karel", "Novak"); // positional construction
      var (firstName, lastName) = person;                        // positional deconstruction
    }
  }
}
