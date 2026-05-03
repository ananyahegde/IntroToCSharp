namespace IntroApp
{
  internal class LimitsApp
  {
    internal void ShowLimits()
    {
      int max = int.MaxValue;
      int min = int.MinValue;
      Console.WriteLine($"The range of integers is {min} to {max}");

      int what = max + 1;
      Console.WriteLine($"An example of overflow(max): {what}");
      
      int excuseMe = min - 1;
      Console.WriteLine($"An example of overflow(min): {excuseMe}");
      
      // this is how you prevent it
      // throws exception
      checked
      {
        int x1 = min - int.MinValue;
        int x2 = max + int.MaxValue;
      }
    }
  }
}
