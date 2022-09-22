namespace Assignment2.Tests;

public class QueriesTests
{
  [Fact]
  public void getNamesRowling1_given_wizards_returns_Harry_Potter()
  {
    var wizards = WizardCollection.Create();

    var result = Queries.getNamesRowling1(wizards);

    result.Should().BeEquivalentTo(new List<string> { "Harry Potter", "Harry Potter", "Ron Weasley" });
  }

  [Fact]
  public void getNamesRowling2_given_wizards_returns_Harry_Potter()
  {
    var wizards = WizardCollection.Create();

    var result = Queries.getNamesRowling2(wizards);

    result.Should().BeEquivalentTo(new List<string> { "Harry Potter", "Harry Potter", "Ron Weasley" });
  }

  [Fact]
  public void getFirstSithYear1_given_wizards_returns_1932()
  {
    var wizards = WizardCollection.Create();

    var result = Queries.getFirstSithYear1(wizards);

    result.Should().Be(1932);
  }

  [Fact]
  public void getFirstSithYear2_given_wizards_returns_1932()
  {
    var wizards = WizardCollection.Create();

    var result = Queries.getFirstSithYear2(wizards);

    result.Should().Be(1932);
  }

  [Fact]
  public void getHarryPotterWizardsList1_given_wizards_returns_Harry_and_Ron()
  {
    var wizards = WizardCollection.Create();

    var result = Queries.getHarryPotterWizardsNameAndYearTuple1(wizards);

    result.Should().BeEquivalentTo(new[] { ("Harry Potter", 1954), ("Ron Weasley", 1980) });
  }

  [Fact]
  public void getHarryPotterWizardsList2_given_wizards_returns_Harry_and_Ron()
  {
    var wizards = WizardCollection.Create();

    var result = Queries.getHarryPotterWizardsNameAndYearTuple2(wizards);

    result.Should().BeEquivalentTo(new[] { ("Harry Potter", 1954), ("Ron Weasley", 1980) });
  }

  [Fact]
  public void getListOfNamesGroupedByCreatorDesc1()
  {
    var wizards = WizardCollection.Create();

    var result = Queries.getListOfNamesGroupedByCreatorDesc1(wizards);

    result.Should().BeEquivalentTo(new List<List<string>> {new List<string>{ "Ron Weasley", "Harry Potter", "Harry Potter" },
    new List<string>{ "Sauron5", "Sauron4", "Sauron3", "Sauron2", "Sauron1", "Sauron" },
    new List<string>{ "Darth Vader", "Darth Revan", "Ajunta Pall" }});
  }

  [Fact]
  public void getListOfNamesGroupedByCreatorDesc2()
  {
    var wizards = WizardCollection.Create();

    var result = Queries.getListOfNamesGroupedByCreatorDesc2(wizards);

    result.Should().BeEquivalentTo(new List<List<string>> {new List<string>{ "Ron Weasley", "Harry Potter", "Harry Potter" },
    new List<string>{ "Sauron5", "Sauron4", "Sauron3", "Sauron2", "Sauron1", "Sauron" },
    new List<string>{ "Darth Vader", "Darth Revan", "Ajunta Pall" }});
  }
}
