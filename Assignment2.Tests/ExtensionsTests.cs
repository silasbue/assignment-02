namespace Assignment2.Tests;

public class ExtensionsTests
{
  [Fact]
  public void isSecure_given_https_uri_returns_true()
  {
    var input = new Uri("https://www.google.com/");

    var result = Extensions.isSecure(input);

    result.Should().Be(true);
  }

  [Fact]
  public void isSecure_given_http_uri_returns_false()
  {
    var input = new Uri("http://www.google.com/");

    var result = Extensions.isSecure(input);

    result.Should().Be(false);
  }
}
