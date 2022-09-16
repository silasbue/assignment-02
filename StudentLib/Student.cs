namespace StudentLib;
public class Student
{
  public Student(int id, string givenName, string surName, DateTime startDate, DateTime endDate, DateTime graduationDate)
  {
    this.id = id;
    GivenName = givenName;
    SurName = surName;
    StartDate = startDate;
    EndDate = endDate;
    GraduationDate = graduationDate;
  }

  public int id { get; init; }
  public string GivenName { get; set; } = null!;
  public string SurName { get; set; } = null!;

  public Status status
  {
    get
    {
      var date = DateTime.Now;
      if (date > StartDate && date < StartDate.AddMonths(2))
      {
        return Status.New;
      }
      else if (date > StartDate && date < EndDate)
      {
        return Status.Active;
      }
      else if (date > EndDate && EndDate < GraduationDate)
      {
        return Status.Dropout;
      }
      else
      {
        return Status.Graduated;
      }
    }
  }

  public DateTime StartDate { get; set; }
  public DateTime EndDate { get; set; }
  public DateTime GraduationDate { get; set; }
}

public enum Status
{
  New,
  Active,
  Dropout,
  Graduated
}
