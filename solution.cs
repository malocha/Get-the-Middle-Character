public class Kata
{
  public static string GetMiddle(string s)
  {
    if (s.Length % 2 == 0) {
      return s.Substring(s.Length/2-1,2);
    }
    else {
      return s.Substring(s.Length/2,1);
    }
  }
}
