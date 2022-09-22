namespace Assignment2;

public class Queries
{
  public static IEnumerable<string> getNamesRowling1(WizardCollection wizards)
    => from wizard in wizards
       where wizard.Creator == "Rowling"
       select wizard.Name;

  public static IEnumerable<string> getNamesRowling2(WizardCollection wizards)
    => wizards
        .Where(w => w.Creator == "Rowling")
        .Select(w => w.Name);

  public static int? getFirstSithYear1(WizardCollection wizards)
    => (from wizard in wizards
        where wizard.Name.StartsWith("Darth")
        select wizard.Year).Min(w => w);


  public static int? getFirstSithYear2(WizardCollection wizards)
    => wizards
        .Where(w => w.Name
        .StartsWith("Darth")).Select(w => w.Year).Min();

  public static IEnumerable<(string, int?)> getHarryPotterWizardsNameAndYearTuple1(IEnumerable<Wizard> wizards)
    => (from wizard in wizards
        where wizard.Medium == "Harry Potter"
        select (wizard.Name, wizard.Year)).Distinct();

  public static IEnumerable<(string, int?)> getHarryPotterWizardsNameAndYearTuple2(WizardCollection wizards)
    => wizards
        .Where(w => w.Medium == "Harry Potter")
        .Select(w => (w.Name, w.Year)).Distinct();

  public static object getListOfNamesGroupedByCreatorDesc1(WizardCollection wizards)
    => from wizard in wizards
       orderby wizard.Creator descending, wizard.Name descending
       group wizard.Name by wizard.Creator into g
       select g;

  public static object getListOfNamesGroupedByCreatorDesc2(WizardCollection wizards)
    => (wizards
        .OrderByDescending(w => w.Creator)
        .ThenByDescending(w => w.Name)
        .GroupBy(w => w.Creator, w => w.Name)
        .Select(w => w));


}
