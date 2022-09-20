namespace StudentLib.Tests;

public class StudentTests
{
  [Fact]
  public void Student_status_given_Dates_With_Years_2002_2004_2004_returns_Status_Graduated()
  {
    Student student = new Student(1, "John", "Doe", new DateTime(2002, 12, 4), new DateTime(2004, 5, 5), new DateTime(2004, 5, 5));

    var result = student.status;

    result.Should().Be(Status.Graduated);
  }

  [Fact]
  public void Student_status_given_Dates_With_Years_2021_2023_2023_returns_Status_Active()
  {
    Student student = new Student(1, "John", "Doe", new DateTime(2021, 10, 2), new DateTime(2023, 4, 4), new DateTime(2023, 4, 4));

    var result = student.status;

    result.Should().Be(Status.Active);
  }

  [Fact]
  public void Student_status_given_Dates_With_Years_2022_2024_2024_returns_Status_New()
  {
    Student student = new Student(1, "John", "Doe", new DateTime(2022, 8, 30), new DateTime(2024, 4, 4), new DateTime(2024, 4, 4));

    var result = student.status;

    result.Should().Be(Status.New);
  }

  [Fact]
  public void Student_status_given_Dates_With_Years_2020_2021_2024_returns_Status_Dropout()
  {
    Student student = new Student(1, "John", "Doe", new DateTime(2020, 8, 30), new DateTime(2021, 4, 4), new DateTime(2024, 4, 4));

    var result = student.status;

    result.Should().Be(Status.Dropout);
  }

  [Fact]
  public void TestName()
  {
    Student student = new Student(1, "John", "Doe", new DateTime(2020, 8, 30), new DateTime(2021, 4, 4), new DateTime(2024, 4, 4));

    var result = student.toString();

    result.Should().Be($@"StudentID: 1
    First name: John
    Surname: Doe
    Status: Dropout");
  }
}
