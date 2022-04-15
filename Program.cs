using System;

namespace whiteboarding
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter in a string to get the URL out");
      string input = Console.ReadLine();
      Console.WriteLine("Standard: " + GenerateURL(input));
      Console.WriteLine("Recursively: " + GenerateURLRecursion(input));

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

    public static string GenerateURLRecursion(string input, string output = "", int count = 0)
    {
      if (count == input.Length)
      {
        return output;
      }
      if (input[count] == ' ')
      {
        output += "%20";
      }
      else
      {
        output += input[count];
      }
      count++;
      return GenerateURLRecursion(input, output, count);

    }
  }
}
