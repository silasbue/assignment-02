namespace Assignment2;

public static class Extensions
{
  public static bool isSecure(Uri input) => input.Scheme == "https";

}
