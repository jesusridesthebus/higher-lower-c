using System;

namespace HigherLower {

  public class HighLow
  {
    public static void Main()
    {
      Console.WriteLine("Would you like to play the higher/lower game? (Yes/No)");
      string userResponse = (Console.ReadLine()).ToLower();

      if (userResponse == "yes")
      {
        Console.WriteLine("Ok!");
      }
    }
  }
}
