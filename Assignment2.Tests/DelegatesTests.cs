namespace Assignment2.Tests;

public class DelegatesTests
{
  [Fact]
  public void lambda_test1()
  {
    var printReverse = (string str) => str.Reverse().ToList().ForEach(x => Console.Write(x));

    printReverse("hello world");
  }

  [Fact]
  public void lambda_test2()
  {
    var product = (int x, int y) => x * y;

    var result = product(2, 3);

    result.Should().Be(6);
  }

  [Fact]
  public void lambda_test3()
  {
    var numericallyEqual = (string str, int x) => Int32.Parse(str) == x;

    var result = numericallyEqual(" 0042", 42);

    result.Should().Be(true);
  }
}
