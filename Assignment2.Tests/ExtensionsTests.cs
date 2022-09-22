namespace Assignment2.Tests;

public class ExtensionsTests
{
  [Fact]
  public void IsSecure_given_https_uri_returns_true()
  {
    var input = new Uri("https://www.google.com/");

    var result = input.IsSecure();

    result.Should().Be(true);
  }

  [Fact]
  public void IsSecure_given_http_uri_returns_false()
  {
    var input = new Uri("http://www.google.com/");

    var result = input.IsSecure();

    result.Should().Be(false);
  }

  [Fact]
  public void WordCount_given_2_words_returns_2()
  {
    var input = "hello world";

    var result = input.WordCount();

    result.Should().Be(2);
  }

  [Fact]
  public void WordCount_given_6_words_and_punctuation_returns_6()
  {
    var input = "hello world, this is a test.";

    var result = input.WordCount();

    result.Should().Be(6);
  }
}
