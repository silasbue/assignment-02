namespace Assignment2.Tests;

public class QueriesTests
{
  [Fact]
  public void Test1()
  {
    var wizards = WizardCollection.Create();

    var result = from wizard in wizards
                 where wizard.Creator == "Rowling"
                 select wizard.Name;

    result.Should().BeEquivalentTo(new List<string> { "Harry Potter" });
  }

  [Fact]
  public void Test2()
  {
    var wizards = WizardCollection.Create();

    var result = from wizard in wizards
                 where wizard.Name.StartsWith("Darth")
                 group wizard by true into siths
                 select siths.Min(s => s.Year);

    result.Should().BeEquivalentTo(new List<int> { 1977 });
  }
}
