namespace StudentLib.Tests;

public class ImmutableStudentsTests{

    [Fact]
    public void has_ImmutableStudent_Graduated()
    {
        var startDate = new DateTime(2001, 1, 1);
        var endDate = new DateTime(2003, 2, 4);
        var graduationDate = new DateTime(2003, 2, 4);

        ImmutableStudents immutableStudents = new ImmutableStudents(1, "John", "Doe", startDate, endDate, graduationDate);
    
        var expected = StudentLib.ImmutableStudents.Status.Graduated;
        var actual = immutableStudents.getStatus;

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void compare_Two_Students()
    {
        var startDate = new DateTime(2004, 5, 6);
        var endDate = new DateTime(2008, 9, 10);
        var graduationDate = new DateTime(2008, 9, 10);
    
        ImmutableStudents immutableStudent1 = new ImmutableStudents(23, "John", "Doe", startDate, endDate, graduationDate);
        ImmutableStudents immmutableStudent2 = new ImmutableStudents(23, "John", "Doe", startDate, endDate, graduationDate);
    
        bool compareStudents = immutableStudent1.Equals(immmutableStudent2);

        Assert.True(compareStudents);
    }

    [Fact]
    public void expected_Output_Test()
    {
        var startDate = new DateTime(2010, 11, 12);
        var endDate = new DateTime(2020, 12, 13);
        var graduationDate = new DateTime(2020, 12, 13);
    
        ImmutableStudents immutableStudent = new ImmutableStudents(264, "John", "Doe", startDate, endDate, graduationDate);
    
        var expected_Output = $@"StudentID: 264, FirstName: John, Surname: Doe, Status: Graduated, Start Date: {startDate}, 
        End Date: {endDate}, Graduation Date: {graduationDate}";

        var toString_Output = immutableStudent.ToString();

        Assert.Equal(expected_Output, toString_Output);
    }
}