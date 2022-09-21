namespace StudentLib;
public record ImmutableStudents{
    public int Id{get; init;}
    public string GivenName{get; init;}
    public string Surname{get; init;}
    public enum Status{
        New, Active, Dropout, Graduated
    }
    public DateTime StartDate{get; init;}
    public DateTime EndDate{get; init;}
    public DateTime GraduationDate{get; init;}

    public ImmutableStudents(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate){
        Id = id;
        GivenName = givenName;
        Surname = surname;
        StartDate = startDate;
        EndDate = endDate;
        GraduationDate = graduationDate;
    }

    public Status getStatus{
        get{
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

    public override string ToString()
    {
        return $@"StudentID: {Id}, FirstName: {GivenName}, Surname: {Surname}, Status: {getStatus}, Start Date: {StartDate}, 
        End Date: {EndDate}, Graduation Date: {GraduationDate}";
    }
    
}