using System;

namespace whiteboarding
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine(GenerateURL("this is a test"));

    }
    public static string GenerateURL(string input)
    {
      string output = "";
      foreach (char letter in input)
      {

        if (letter == ' ')
        {
          output += "%20";
        }
        else
        {
          output += letter;
        }
      }
      return output;
    }
  }
}
