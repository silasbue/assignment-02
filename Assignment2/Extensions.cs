namespace Assignment2;

public static class Extensions
{
  public static bool IsSecure(this Uri uri) => uri.Scheme == "https";

  public static object WordCount(this string str) => str.Split(" ").Length;
}
